using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelExam3
{
    class Program
    {
        delegate void Dele(string s);
        static void Main(string[] args)
        {
            Dele d0 = (v) => Console.WriteLine(v);
            d0.Invoke("OJC");


            Dele d1 = new Dele(d);
            d1.Invoke("OJC");


            Dele d2 = d;
            d2.Invoke("OJC");

            Dele x = (z) => Console.WriteLine(z);
            x("aaaa");
        }
        static void d(string s)
        {
            Console.WriteLine(s);
        }
    }
}
