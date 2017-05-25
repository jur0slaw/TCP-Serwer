using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace TCP_Serwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopbutton.Enabled = false;
        }

        private TcpListener server = null;
        private TcpClient client = null;

        private void button2_Click(object sender, EventArgs e)
        {
            int p = Convert.ToUInt16(port.Value);
            IPAddress ip = null;

            try
            {
                ip = IPAddress.Parse(Adress.Text); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong IP adress format.", " Error ");
                Adress.Text = string.Empty;
                return;
            }

            try
            {
                server = new TcpListener(ip, p);
                server.Start();

                client = server.AcceptTcpClient();

                info_feed.Items.Add("Connection established.");

                IPEndPoint srv  = (IPEndPoint)client.Client.RemoteEndPoint;

                info_feed.Items.Add("[" + srv.ToString() + "] : Connection established");

                startbutton.Enabled = false;
                stopbutton.Enabled = true;

                client.Close();
                server.Stop();
            }
            catch(Exception ex)
            {
                info_feed.Items.Add("Error establishing a server.");
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            startbutton.Enabled = true;
            stopbutton.Enabled = false;
            MessageBox.Show("Connection closed");

            server.Stop();
            client.Close();
        }
    }
}
