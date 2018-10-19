using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

4. 아래와 같이 출력하는 프로그램을 작성하세요.
*
***
*****

 */




namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 1; i <= 3; i++)
            {
               for(int j = 0; j < i+2; j++)
                {   
                    Console.Write("*");
                    if (i == 1) break;
                }
                Console.WriteLine();
            }
        }
    }
}
