using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Method1() & Method2())
            {
                Console.WriteLine("Both methods ruturned true");
            }
            else
            {
                Console.WriteLine("둘중 하나의 메소드는 false"); 
            }

            if (Method1() && Method2())
            {
                Console.WriteLine("Both methods ruturned true");
            }
            else
            {
                Console.WriteLine("둘중 하나의 메소드는 false");
            }


            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);
            bool x = false;
            Console.WriteLine(x ? "참" : "거짓");


        }


        static bool Method1()
        {
            Console.WriteLine("메소드1...");
            return false;
        }

        static bool Method2()
        {
            Console.WriteLine("메소드2...");
            return true;
        }


    }
}
