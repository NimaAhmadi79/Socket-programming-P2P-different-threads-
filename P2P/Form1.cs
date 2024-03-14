using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P
{
    public partial class Form1 : Form
    {
        public static List<Form> formList = new List<Form>();
        public static List<string> ipList = new List<string>();
        public static List<string> portList = new List<string>();
        public static List<string> nameList = new List<string>();
        public static List<string> startIpTable = new List<string>();
        public static List<string> startPortTable = new List<string>();

        static int count = 2;
        static Thread t2;
        static Thread t3;
        static Thread t4;
        static Thread t5;
        static Thread t6;
        static Thread t7; 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formList.Add(new Form2());
            formList.Add(new Form3());
            formList.Add(new Form4());
            formList.Add(new Form5());
            formList.Add(new Form6());
            formList.Add(new Form7());
            t2 = new Thread(f2);
            t3 = new Thread(f3);
            t4 = new Thread(f4);
            t5 = new Thread(f5);
            t6 = new Thread(f6);
            t7 = new Thread(f7);

        }


        public static void f2()
        {

            Application.Run(formList[0]);

        }


        public static void f3()
        {

            Application.Run(formList[1]);

        }

        public static void f4()
        {

            Application.Run(formList[2]);

        }
        public static void f5()
        {

            Application.Run(formList[3]);

        }
        public static void f6()
        {

            Application.Run(formList[4]);

        }
        public static void f7()
        {

            Application.Run(formList[5]);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            switch (count)
            {
                case 2:
                    {
                        
                        ipList.Add(iptxt.Text);
                        portList.Add(porttxt.Text);
                        t2.Start();
                        count++;
                        break;
                    }
                case 3:
                    {
                        
                        ipList.Add(iptxt.Text);
                        portList.Add(porttxt.Text);
                        t3.Start();
                        count++;
                        break;
                    }
                case 4:
                    {
                        
                        ipList.Add(iptxt.Text);
                        portList.Add(porttxt.Text);
                        t4.Start();
                        count++;
                        break;
                    }
                case 5:
                    {
                        
                        ipList.Add(iptxt.Text);
                        portList.Add(porttxt.Text);
                        t5.Start();
                        count++;
                        break;
                    }
                case 6:
                    {
                        
                        ipList.Add(iptxt.Text);
                        portList.Add(porttxt.Text);
                        t6.Start();
                        count++;
                        break;
                    }
                case 7:
                    {
                        
                        ipList.Add(iptxt.Text);
                        portList.Add(porttxt.Text);
                        t7.Start();
                        count++;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("You can not add more 6 peer", "Alert", MessageBoxButtons.OK);
                        break;
                    }

            }

        }
    }
}
