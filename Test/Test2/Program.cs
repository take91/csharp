using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 2. 하나의 숫자를 입력받아서 홀수/짝수를 판정하세요.

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 하나를 입력하십시오.");
            Console.WriteLine(int.Parse(Console.ReadLine()) % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
