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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static Socket sktLisener;
        static void main()
        {
            sktLisener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, 1800);
            sktLisener.Bind(ipLocal);
            sktLisener.Listen(100);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sktLisener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, 1800);
            sktLisener.Bind(ipLocal);
            sktLisener.Listen(100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
