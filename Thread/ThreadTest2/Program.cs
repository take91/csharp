using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTest2
{
    class Program
    {
        public bool sleep = false;

        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        public void FirstWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);
                if (i == 5)
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first 쉼...");
                    autoEvent.WaitOne();
                }
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            Thread first = new Thread(new ThreadStart(p.FirstWork));
            first.Start();

            while (p.sleep == false) { }

            Console.WriteLine("first를 깨웁니다...2초 후 깨어납니다.");
            Thread.Sleep(2000);
            autoEvent.Set();
        }
    }
}
