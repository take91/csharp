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
using System.Threading;

namespace ChatPractice
{

    delegate void CallBack(string s);
    public partial class Form1 : Form
    {
        TcpListener tcpListener = new TcpListener(IPAddress.Parse("192.168.0.39"), 5001);
        NetworkStream stream = null;
        Socket socket = null;
        static List<Socket> list = new List<Socket>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn1.Tag.Equals("Stop"))
            {
                tcpListener.Start();

                Thread thread = new Thread(new ThreadStart(WaitSocket));
                thread.Start();
                btn1.Tag = "Start";
                btn1.Text = "Start";
            }
            else
            {
                btn1.Tag = "Stop";
                btn1.Text = "Stop";

                tcpListener.Stop();
                foreach (Socket s in list)
                {
                    s.Close();
                }
            }
        }

        private void WaitSocket()
        {
            Socket socket = null;

            while (true)
            {
                try
                {
                    socket = tcpListener.AcceptSocket();
                    Chat chat = new Chat(socket, this.logWindow);
                    Thread thread = new Thread(new ThreadStart(chat.doChat));
                    thread.Start();

                }
                catch
                {
                    list.Remove(socket);
                    break;
                }
            }

        }
    }

    class Chat
    {
        Encoding encode = Encoding.GetEncoding("euc-kr");
        private Socket socket;
        private StreamReader reader;
        private StreamWriter writer;
        private NetworkStream stream;
        private System.Windows.Forms.TextBox logWindow;

        public Chat(Socket socket, System.Windows.Forms.TextBox logWindow)
        {
            this.logWindow = logWindow;
            this.socket = socket;
            this.stream = new NetworkStream(socket);
            this.reader = new StreamReader(stream, encode);
        }

        public void doChat()
        {
            while (true)
            {
                try
                {
                    string str = reader.ReadLine();

                    if(str!=null && str != "")
                    {
                        CallBack cb = new CallBack((string s) =>logWindow.AppendText(s+"\r\n") );
                        cb.Invoke(str);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
