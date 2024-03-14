using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<string> tempTable = new List<string>();
        List<string> shaiee = new List<string>();
        SimpleTcpServer server;
        static List<string> ipPort = new List<string>();
        static List<SimpleTcpClient> clientTable = new List<SimpleTcpClient>();
        static int i = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            shaiee.Add("nima");
            shaiee.Add("amir");
            shaiee.Add("mohamad");
            shaiee.Add("hamid");



            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            txtMyHost.Text = Form1.ipList[Form1.ipList.Count - 1];
            txtMyPort.Text = Form1.portList[Form1.portList.Count - 1];
            


        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                //txtStatus.Text += e.MessageString;
                string message= e.MessageString;
                Boolean b = true;
                for(int i=0; i < shaiee.Count; i++)
                {
                    if (message == shaiee[i])
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    shaiee.Add(message);
                    Rscatter(message);

                }
                for (int i = 0; i < shaiee.Count; i++)
                {
                    txtStatus.Text += shaiee[i];
                }

                
                
                
                //e.ReplyLine(string.Format("you said : {0}", e.MessageString));


            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SimpleTcpClient client;
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            string Hosttxt = txtHost.Text;
            int port = Convert.ToInt32(txtPort.Text);
            if (isConnect(Hosttxt, port))
            {
                if (isThereIp(Hosttxt, port))
                {
                    client.Connect(Hosttxt, port);
                    //btnConnect.Enabled = false;
                    clientTable.Add(client);
                    ipPort.Add(Hosttxt + "." + port.ToString());
                    txtNews.Text += "Connected to" + Hosttxt + "\n";
                    
                    scatter();
                    

                }
                else
                {
                    MessageBox.Show("No server is on with this ip and port", "Alert", MessageBoxButtons.OK);

                }

                

            }
            else
            {
                MessageBox.Show("we already connected to this peer", "Alert", MessageBoxButtons.OK);

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ipPort.Count; i++)
            {
                clientTable[i].WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(0));
                shaiee.Add(txtMessage.Text);

            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtNotif.Text = "server starting....";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtMyHost.Text);
            server.Start(ip, Convert.ToInt32(txtMyPort.Text));
            Form1.startIpTable.Add(txtMyHost.Text);
            Form1.startPortTable.Add(txtMyPort.Text);


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                txtNotif.Text = "server stoped";
                server.Stop();
            }

        }


        public static Boolean isConnect(String ip, int port)
        {
            string Tip = null;
            string Tport = null;

            for (int i = 0; i < ipPort.Count; i++)
            {
                string[] ar = ipPort[i].Split('.');
                Tip = ar[0] + "." + ar[1] + "." + ar[2] + "." + ar[3];
                Tport = ar[4];
                if (ip == Tip && Tport == port.ToString())
                {
                    return false;

                }


            }
            return true;

        }


        public void scatter()
        {
            
            for (int i = 0; i < clientTable.Count; i++)
            {
                for (int j = 0; j < shaiee.Count; j++)
                {
                    clientTable[i].WriteLineAndGetReply(shaiee[j], TimeSpan.FromSeconds(0.1));
                    
                }




            }
        }

        public void Rscatter(string message)
        {

            for (int i = 0; i < clientTable.Count; i++)
            {
                
                    clientTable[i].WriteLineAndGetReply(message, TimeSpan.FromSeconds(0.1));
            }
        }

    

        public static Boolean isThereIp(string ip, int port)
        {
            for(int i = 0; i < Form1.startIpTable.Count; i++)
            {
                if(Form1.startIpTable[i]==ip&& Form1.startPortTable[i] == port.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void showRumerbtn_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < shaiee.Count; i++)
            {
                rumortxt.Text += shaiee[i] + "   ";
            }

        }
    }
}
