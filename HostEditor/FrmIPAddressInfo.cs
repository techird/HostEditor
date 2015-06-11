using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace HostEditor
{
    public partial class FrmIPAddressInfo : Form
    {
        public IPAddress ip;
        public FrmIPAddressInfo()
        {
            InitializeComponent();
        }

        private void IPAddressInfo_Load(object sender, EventArgs e)
        {
            if (ip != null)
            {
                txtIP.Text = ip.ToString();
                Clipboard.SetText(txtIP.Text);
                if (txtIP.Text.IndexOf(':') > 0)
                {
                    txtType.Text = "IPv6";
                    if (ip.IsIPv6LinkLocal) txtType.Text += "，连接本地地址";
                    if (ip.IsIPv6Multicast) txtType.Text += "，多路广播全局地址";
                    if (ip.IsIPv6SiteLocal) txtType.Text += "，站点本地地址";
                }
                else txtType.Text = "IPv4";
            }
        }
    }
}
