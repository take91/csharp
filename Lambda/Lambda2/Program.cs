using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda2
{
    delegate int Sum(int[] arg);
    class Program
    {
        static void Main(string[] args)
        {
            Sum sumdele = (arg) =>
            {
                int mySum = 0;
                foreach(int i in arg)
                {
                    mySum += i;
                }
                return mySum;
            };

            int sum = sumdele(new int[] {1,2,3,4,5 });
            Console.WriteLine("1+2+3+4+5 = "+sum);

        }
    }
}
