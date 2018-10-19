using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

5. 실행결과가 아래와 같다.

Enter a Number : 123

Reverse of Entered Number : 321

코드를 완성하세요
 */



namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");

            num = int.Parse(Console.ReadLine());

            while (num != 0)

            {
                reverse = (reverse * 10) + (num % 10);
                num = num / 10;

            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);

            Console.ReadLine();
        }
    }
}
