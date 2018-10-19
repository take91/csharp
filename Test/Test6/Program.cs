using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6. 사용자로 부터 하나의 수를 입력받고 그수까지의 소수의 합을 구하는 프로그램을 작성하세요.


namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 하나를 입력하시오.");
            int input = int.Parse(Console.ReadLine());
            int sum = 2;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1) { break; }
                    else if (i % 2 == 0) { break; }
                    else if ((j != 1 && i != j) && i % j == 0) { break; }
                    else if (i == j) { sum += i; }
                }
            }
            Console.WriteLine("1부터 {0} 까지의 소수의 합은 : {1}", input, sum);
        }
    }
}
