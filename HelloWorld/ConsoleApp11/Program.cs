using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //int num = int.Parse(str);
            int num;
            if (int.TryParse(str, out num)) Console.WriteLine("OK-");
            int sum = 0;
            int i = 0;

            while (i++ < num)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine("{0}까지의 짝수의 합은 {1}", num, sum);
            num = 0;
            do
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            } while (i++ < num);
            Console.WriteLine("{0}까지의 짝수의 합은 {1}", num, sum);

            num = 0;
            for (i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("{0}까지의 짝수의 합은 {1}", num, sum);

        }
    }
}
