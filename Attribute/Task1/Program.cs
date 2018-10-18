using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate void doCalc(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("임의의 두 수를 입력하십시오. ex.(1,2)");
            int[] result = Array.ConvertAll((Console.ReadLine()).Split(','), i => int.Parse(i));


            doCalc Calc = (doCalc)Delegate.Combine(
               new doCalc(Add),
                new doCalc(Substract),
                new doCalc(Multiple),
                new doCalc(Divide)
                );

            Calc(result[0], result[1]);
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public static void Multiple(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, Math.Round((a / (float)b),2));
        }

    }
}
