using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("출력을 원하는 구구단 단수 : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 2; j <=9; j++)
                {
                    Console.Write("{0}x{1} = {2}  ", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
