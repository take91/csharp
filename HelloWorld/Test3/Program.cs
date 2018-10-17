using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.Write("숫자-{0} : ", i);
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("합 : {0}",sum);
            Console.WriteLine("평균 : {0}",(sum/10.0));

        }
    }
}
