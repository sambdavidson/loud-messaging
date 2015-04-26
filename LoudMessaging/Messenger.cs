using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using StringSocket;

namespace LoudMessaging
{
    public partial class Messenger : Form
    {
        private TcpClient tcpClient;
        private TcpListener tcpHost;
        private StringSocket.StringSocket stringSocket;

        public Messenger()
        {
            InitializeComponent();

        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            int port = Decimal.ToInt32(portSelector.Value);
            tcpHost = new TcpListener(port);
            tcpHost.Start();
            Socket socket = tcpHost.AcceptSocket();
            stringSocket = new StringSocket.StringSocket(socket, Encoding.ASCII);
            ToggleServerEntry();
            stringSocket.BeginReceive(ReceiveLoop, null);
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            int port = Decimal.ToInt32(portSelector.Value);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipBox.Text, port);
            stringSocket = new StringSocket.StringSocket(tcpClient.Client, Encoding.ASCII);
            ToggleServerEntry();
            stringSocket.BeginReceive(ReceiveLoop,null);
        }

        private void ReceiveLoop(String str, Exception e, Object payload)
        {
            
            MessageBox.Show(str.ToUpper() + "!!!");
            stringSocket.BeginReceive(ReceiveLoop, null);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (stringSocket != null && messageBox.Text.Length > 0)
            {
                stringSocket.BeginSend(messageBox.Text + "\n", sendCallback,null);
                messageBox.Text = "";
            }
        }

        private void sendCallback(Exception e, Object payload)
        {
            //Error check
        }

        private void ToggleServerEntry()
        {
            ipBox.Enabled = !ipBox.Enabled;
            portSelector.Enabled = !portSelector.Enabled;
            hostButton.Enabled = !hostButton.Enabled;
            connectButton.Enabled = !connectButton.Enabled;
        }


    }
}
