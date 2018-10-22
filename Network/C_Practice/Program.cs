using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace C_Practice
{
    class ServerHandler
    {
        private StreamReader reader = null;


        public ServerHandler(StreamReader reader)
        {
            this.reader = reader;
        }

        public void Chat()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }

    class Client
    {
        public static void Main()
        {
            TcpClient client = null;


            try
            {
                client = new TcpClient();
                client.Connect("192.168.0.39", 5001);

                NetworkStream stream = client.GetStream();
                Encoding encode = Encoding.GetEncoding("utf-8");

                StreamReader reader = new StreamReader(stream, encode);
                StreamWriter writer = new StreamWriter(stream, encode) { AutoFlush = true };

                ServerHandler serverHandler = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(serverHandler.Chat));
                t.Start();

                string dataToSend = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(dataToSend);
                    if (dataToSend.IndexOf("<EOF>") > -1) break;
                    dataToSend = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                client.Close();
                client = null;
            }
        }
    }



}
