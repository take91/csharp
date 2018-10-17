using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력숫자 : ");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            int sum = 0;
            Console.Write("{0}까지의 숫자 : ", num);
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("{0}까지의 숫자합은 : ", num);
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
                Console.WriteLine(sum);
        }
    }
}
