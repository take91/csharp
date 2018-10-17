using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            int b;
            if (a.HasValue) b = a.Value;
            else b = 0;

            Console.WriteLine("Value of b is {0}", b);


            int c = a ?? 0;
            Console.WriteLine("Value of c is {0}", c);
            Console.ReadLine();

        }
    }
}
