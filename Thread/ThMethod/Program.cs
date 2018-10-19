using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThMethod
{
    class Program
    {
        static void Thmethod()
        {
            int id = AppDomain.GetCurrentThreadId();
            Console.WriteLine("Thread[{0}] Thmethod Method Running",id);
        }


        static void Main(string[] args)
        {
            int id = AppDomain.GetCurrentThreadId();
            Console.WriteLine("Main Thread[{0}]",id);

            for(int i = 0; i < 10; i++)
            {
                Thread th = new Thread(new ThreadStart(Thmethod));
                th.Start();
            }

        }
    }
}
