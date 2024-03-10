using MikrotikUserMonitoring.controller;
using MikrotikUserMonitoring.model;
using tik4net.Objects;

namespace MikrotikUserMonitoring
{
    public partial class MainApp : Form, ImplEventChangeListener
    {
        private Transaction transaction;
        public MainApp()
        {
            InitializeComponent();

            checkAppConfig();
        }

        public void onPushToUpdateData()
        {

        }

        private void checkAppConfig()
        {
            string filename = "mikro.config";
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }
            else
            {
                string[] configs = File.ReadAllLines(filename);
                this.transaction = new Transaction(this);
                this.transaction.HOSTNAME = configs[0];
                this.transaction.USERNAME = configs[1];
                this.transaction.PASSWORD = configs[2];
                this.transaction.openConnection();
                //MessageBox.Show("HostnamePasswordusernameHostnamePasswordusername");
                //MessageBox.Show(transaction.HOSTNAME+transaction.USERNAME+transaction.PASSWORD);

            }
            if (transaction != null)
            {
                this.Text = "Routerboard : " + transaction.getIdentity();
                string hosts = "";
                int lineNumber = 0;
                foreach (UserDevice uDevice in transaction.getHostsWithDhcpServer())
                {
                    dgvHosts.Rows.Add(++lineNumber, uDevice.MacAddress, uDevice.ToAddress, "", "", "", uDevice.DeviceName, uDevice.Comment);
                }
            }
            //MessageBox.Show(hosts);
        }

        private void settingConnectionBtn_Click(object sender, EventArgs e)
        {
            AppConfigConnection appConfig = new AppConfigConnection();
            appConfig.ShowDialog();
        }


    }
}