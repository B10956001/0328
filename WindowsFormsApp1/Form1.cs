using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UdpClient U;
        Thread Th;
        
        private void Listen()
        {
            int Port = int.Parse(textBox_listen_port.Text);

            U = new UdpClient(Port);

            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);

            while (true)
            {
                byte[] B = U.Receive(ref EP);
                textBox_recive_msg.Text = Encoding.Default.GetString(B);
            }
        }

        private void textBox_listen_port_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
