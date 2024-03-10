using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikrotikUserMonitoring.model
{
    public  class UserDevice
    {
        private string macAddress;
        private string address;
        private string toAddress;
        private string upTime;
        private bool authorized;
        private bool bypassed;
        private string deviceName;
        private string comment;

        public UserDevice()
        {

        }

        public string MacAddress { get => macAddress; set => macAddress = value; }
        public string Address { get => address; set => address = value; }
        public string ToAddress { get => toAddress; set => toAddress = value; }
        public string UpTime { get => upTime; set => upTime = value; }
        public bool Authorized { get => authorized; set => authorized = value; }
        public bool Bypassed { get => bypassed; set => bypassed = value; }
        public string DeviceName { get => deviceName; set => deviceName = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
