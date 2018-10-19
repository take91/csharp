using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    class Program
    {
        delegate int Calc(int i);
        static void Main(string[] args)
        {

            Calc c = x =>
            {
                int sum = 0;
                for (int i = 1; i <= x; i++)
                {
                    sum += i;
                }
                return sum;
            };
           


            Console.WriteLine("임의의 수를 입력 해 주세요.");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("1부터 {0}까지의 합은 {1} 입니다.",input, c(input));



        }
    }
}
