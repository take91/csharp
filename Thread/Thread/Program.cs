using System;
using System.Threading;

namespace ThreadTest
{
    public class Program
    {
        public void FirstWork()
        {
            for(int i =0;i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("F{0} ",i);
            }
        }

        public void SecondWork()
        {
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("S{0} ", i);
            }
        }

        [MTAThread]
        static void Main(string[] args)
        {
            Program p = new Program();

            Thread first = new Thread(p.FirstWork);
            Thread second = new Thread(new ThreadStart(p.SecondWork));

            first.Priority = ThreadPriority.Lowest;
            second.Priority = ThreadPriority.Highest;

            first.Start();
            second.Start();

        }
    }
}
