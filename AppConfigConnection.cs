using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikrotikUserMonitoring
{
    public partial class AppConfigConnection : Form
    {
        public AppConfigConnection()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //string ipaddress = ipAddressField.TextMaskFormat.ToString();
            //string IpAddress = ipAddressField.Text.ToString();
            //MessageBox.Show(ipaddress + " : " + IpAddress);
        }

        private void firstColumIP_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
