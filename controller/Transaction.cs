using MikrotikUserMonitoring.model;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Ip;
using tik4net.Objects.System;

namespace MikrotikUserMonitoring.controller
{
    internal class Transaction
    {
        private ITikConnection connection;
        private ImplEventChangeListener listener;
        public Transaction(ImplEventChangeListener listener) {
            this.connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);
            this.listener = listener;
        }

        public void openConnection() {
            this.connection.Open(HOSTNAME, USERNAME, PASSWORD);
            this.connection.OnReadRow += connectionOnReadRow;
        }

        private void connectionOnReadRow(object sender, TikConnectionCommCallbackEventArgs args) {
            listener.onPushToUpdateData();
        }

        void connect() {
           connection = ConnectionFactory.CreateConnection(TikConnectionType.Api); // Use TikConnectionType.Api for mikrotikversion prior v6.45
            
                ITikCommand command = connection.CreateCommand("/system/identity/print");
                string identity = command.ExecuteScalar();
                string routerboard = "";
                foreach (ITikReSentence item in command.ExecuteList()) {
                    routerboard += item.ToString() + "";
                }
                //MessageBox.Show( " Routerboard " + routerboard);
                var ipaddresslist = "";
                var ipAddresses = connection.LoadList<IpAddress>();
                foreach (var addr in ipAddresses)
                {
                    ipaddresslist += addr.EntityToString() + "\n";
                }

                var sysRes = connection.LoadSingle<SystemResource>();
                string systemResource = sysRes.EntityToString();
                //Console.WriteLine("Router identity: {0}", identity);
                //Console.WriteLine("Hello World");

                ITikCommand cmdListHost = connection.CreateCommand("/ip/hotspot/host/print");
                string host = "";
                foreach (ITikReSentence item in cmdListHost.ExecuteList())
                {
                    host += item.ToString() + "\n";
                }
                //MessageBox.Show("UserConnected in router : \n" + host  );
            
            //    var connection = ConnectionFactory.OpenConnection(TikConnectionType.Api, HOST, USER, PASS);
            //ITikCommand command = connection.CreateCommand("/system/identity/print");
            //string identity = command.ExecuteScalar();
            //Console.WriteLine("Router identity: {0}", identity);
        }

        public string getIdentity() {
            
                ITikCommand command = connection.CreateCommand("/system/identity/print");
                return command.ExecuteScalar();
            
        }

        public string getResources()
        {
           
                var sysRes = connection.LoadSingle<SystemResource>();
                return sysRes.EntityToString();
            
        }

        public List<UserDevice> getHostsWithDhcpServer() {
          
                List<UserDevice> devices = new List<UserDevice>();
                ITikCommand cmdListHost = connection.CreateCommand("/ip/hotspot/host/print");
               
                foreach (ITikReSentence item in cmdListHost.ExecuteList())
                {
                    string []attributes = item.ToString().Split("|");
                    UserDevice userDevice = new UserDevice();
                    foreach(string attr in attributes) {
                        if (attr.Contains("mac-address")) {
                            userDevice.MacAddress = attr.Split("=")[1];
                        }
                        else if (attr.Contains("to-address"))
                        {
                            userDevice.ToAddress = attr.Split("=")[1];
                        }
                        else if (attr.Contains("up-time"))
                        {
                            userDevice.UpTime = attr.Split("=")[1];
                        }
                        else if (attr.Contains("authorized"))
                        {
                            //userDevice.Authorized = attr.Split("=")[1];
                        }
                        else if (attr.Contains("bypassed"))
                        {
                            //userDevice.Bypassed = attr.Split("=")[1].to;
                        }
                        else if (attr.Contains("comment"))
                        {
                            userDevice.Comment = attr.Split("=")[1];
                        }
                    }
                    devices.Add(userDevice);
                }
            ITikCommand leases = connection.CreateCommand("/ip/dhcp-server/lease/print");

            foreach (ITikReSentence item in leases.ExecuteList())
            {
                string[] leaseAttributes = item.ToString().Split("|");
                string addressCompare = "",hostname="";
                //MessageBox.Show(item.ToString());
                foreach (string attr in leaseAttributes)
                {
                    if (attr.Contains("address") && !attr.Contains("mac-address"))
                    {
                        addressCompare = attr.Split("=")[1];
                    }
                    if (attr.Contains("host-name"))
                    {
                        hostname = attr.Split("=")[1];
                        //MessageBox.Show(addressCompare+" => "+hostname);
                        mappingHostnameByAddress(devices,addressCompare,hostname);
                        break;
                    }

                } 
                
            }
                return devices;
        }

        private void mappingHostnameByAddress(List<UserDevice> userDevices,string address,string hostname) {
            for (int idx=0; idx<userDevices.Count; idx++) {
                if (userDevices[idx].ToAddress.Equals(address)) {
                    userDevices[idx].DeviceName = hostname;
                }
            }
        }

        private string hostname;
        private string username;
        private string password;

        public string HOSTNAME{
            get { return hostname; }
            set { hostname = value; }
        }
        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }
        public string PASSWORD {
            get { return password; }
            set { password = value; }
        }

        


    }

   
}
