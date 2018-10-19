using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    delegate double Root(double i);
    class Program
    {
        static void Main(string[] args)
        {
            Root r = i => Math.Sqrt(i);
            Console.WriteLine("제곱근을 구하고자 하는 수를 입력하세요.");
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine(r(input));
        }
    }
}
