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
using System.IO;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        private TcpClient client; //Listens for connections from TCP network clients.
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string textToSend;

        // KNAS?
        public Form1()
        {
            InitializeComponent();
            //The name localhost normally resolves to the IPv4 loopback address 127.0.0.1, and to the IPv6 loopback address ::1
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress adress in localIP)
            {
                //Checks for ipV4
                if (adress.AddressFamily == AddressFamily.InterNetwork)
                {
                    edtServerIP.Text = adress.ToString();
                }
            }
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Check with ex Wireshark 
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(edtServerPort.Text));
                listener.Start();
                this.BackColor = Color.Green;
                this.Update();
                redtHistory.AppendText("Server started" + "\n");
                redtHistory.Update();
                client = listener.AcceptTcpClient(); //Accept a pending connection request 
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnClientStart_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();

                //Represents a network endpoint as an IP address and a port number.
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(edtClientIP.Text), int.Parse(edtClientPort.Text));

                //Connects the client to a remote TCP host using the specified host name and port number.
                client.Connect(ipEnd);
                if (client.Connected)
                {
                    this.BackColor = Color.Green;
                    this.Update();
                    redtHistory.AppendText("Connected to Server" + "\n");
                    redtHistory.Update();
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.redtHistory.Invoke(new MethodInvoker(delegate ()
                    {
                        redtHistory.AppendText("You:" + recieve + "\n");
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(textToSend);
                this.redtHistory.Invoke(new MethodInvoker(delegate ()
                {
                    redtHistory.AppendText("Me:" + textToSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (edtToSend.Text != "")
            {
                textToSend = edtToSend.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            edtToSend.Text = "";
        }
    }
}
