using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;




namespace S_Practice
{
    class ClientHandler
    {
        private Socket socket = null;
        private NetworkStream stream = null;
        private StreamReader reader = null;
        private StreamWriter writer = null;


        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            Server.list.Add(socket);
        }

        public void Chat()
        {
            Encoding encode = Encoding.GetEncoding("utf-8");
            stream = new NetworkStream(socket);
            reader = new StreamReader(stream, encode);

            try
            {
                while (true)
                {
                    int count = 1;
                    string str = reader.ReadLine();
                    Console.WriteLine("사용자" + count + ">" + str);
                    foreach (Socket s in Server.list)
                    {
                        stream = new NetworkStream(s);

                        writer = new StreamWriter(stream, encode) { AutoFlush = true };
                        writer.WriteLine("사용자" + count + ">" + str);
                        count++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Server.list.Remove(socket);
                socket.Close();
                socket = null;
            }



        }



    }


    class Server
    {
        public static List<Socket> list = new List<Socket>();



        public static void Main()
        {
            TcpListener tcpListener = null;
            Socket clientsocket = null;


            try
            {
                IPAddress ipAd = IPAddress.Parse("192.168.0.39");
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();


                while (true)
                {
                    clientsocket = tcpListener.AcceptSocket();

                    ClientHandler clientHandler = new ClientHandler(clientsocket);
                    Thread t = new Thread(new ThreadStart(clientHandler.Chat));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }





}
