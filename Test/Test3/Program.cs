using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 3. 사용자로 부터 두수를 입력받아 변수에 넣고 변수값을 뒤짚어서 출력하는 프로그램 입니다.
//    코드를 완성하세요.



namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.Write("\nEnter the First Number : ");

            num1 = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the Second Number : ");

            num2 = int.Parse(Console.ReadLine());



            temp = num1;
            num1 = num2;
            num2 = temp;



            Console.Write("\nAfter Swapping : ");

            Console.Write("\nFirst Number : " + num1);

            Console.Write("\nSecond Number : " + num2);

            Console.Read();
        }
    }
}
