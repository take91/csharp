using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    delegate int Calc(int i, int j);
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc(MySum);
            Console.WriteLine("1+2={0}",c(1,2));


            Calc c1 = delegate (int i, int j)
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}", c1(3, 4));


            Calc c2 = (int a, int b) => a + b;
            Console.WriteLine("3+4={0}", c2(3, 4));



            Calc c3 = (a,b) => a + b;
            Console.WriteLine("5+6={0}", c3(5, 6));
        }

        static int MySum(int i , int j)
        {
            return i + j;
        }
    }
}
