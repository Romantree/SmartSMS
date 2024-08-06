using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views
{
    public partial class ServerView : UserControl
    {
        public ServerView()
        {
            InitializeComponent();;
            GetUserInfo();
        }

        
        public string[] GetUserInfo()
        {
            string[] userInfo = new string[2];

            string hostName = Dns.GetHostName();
            IPAddress[] addresses = Dns.GetHostEntry(hostName).AddressList;


            string ipv4Address = null;
            string ipv6Address = null;

            foreach(IPAddress address in addresses)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipv4Address = address.ToString();
                }
                else if (address.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    ipv6Address = address.ToString();
                }
            }

            userInfo[0] = ipv4Address ?? "No IPv4 address found";
            string machineName = Environment.MachineName;

            // Add the IP addresses and machine name to the ListBox
            lblIP4.Items.Add("IPv4 Address: " + (ipv4Address ?? "Not available"));
            lblIP6.Items.Add("IPv6 Address: " + (ipv6Address ?? "Not available"));
            lblIP6.Items.Add("Machine Name: " + machineName);

            return userInfo;
        }

 
    }
}
