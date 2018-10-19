using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 1. 콤마로 구분해서 여러 숫자를 입력받아 합을 구하는 프로그램을 작성하세요.

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("합을 구하고자 하는 숫자들을 입력해주세요. ex(1,2,3,4,5)");
            int[] input = Array.ConvertAll((Console.ReadLine().Split(',')), i => int.Parse(i));
            int sum = 0;
            foreach (int i in input)
            {
                sum += i;
            }
                Console.WriteLine("입력하신 숫자들의 합은 {0} 입니다.", sum);
        }
    }
}
