using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 10. 실행결과는?(먼저 예측하고 코딩해보세요.)

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };

            // ... Find index of first odd element.

            int oddIndex = elements.FindIndex(x => x % 2 != 0);

            Console.WriteLine(oddIndex);
        }
    }
}
