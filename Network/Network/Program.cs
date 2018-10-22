using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client
{

    class ServerHandler
    {
        StreamReader reader = null;

        public ServerHandler(StreamReader reader)
        {
            this.reader = reader;
        }

        public void chat()
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



    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient();
                client.Connect("192.168.0.39", 5001);

                NetworkStream stream = client.GetStream();
                Encoding encode = Encoding.GetEncoding("utf-8");

                StreamWriter writer = new StreamWriter(stream, encode) { AutoFlush = true };
                StreamReader reader = new StreamReader(stream, encode);

                ServerHandler serverHandler = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(serverHandler.chat));
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
