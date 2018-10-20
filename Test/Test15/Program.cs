using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 15.  실행결과는? (먼저 예측하고 코딩해보세요.)


namespace Test15
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] t = new Thread[10];

            for (int tNum = 0; tNum < 10; tNum++)

            {

                t[tNum] = new Thread(() =>
                {

                    Thread.Sleep(new Random().Next(20));

                    Console.Write(tNum + " ");

                });

                t[tNum].Start();

            }

            // wait for the threads to finish

            for (int tNum = 0; tNum < 10; tNum++)

            {

                t[tNum].Join();

            }

            Console.WriteLine("\nPress a key...");

            Console.Read();
        }
    }
}
