using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14. 괄호를 채워주세요.




//[실행결과]

//Number: 10,000 

//Number: 200 

//Money: $ 10,000.00 

//Money: $ 200.00




namespace Test14
{
    public delegate void Print(int value);
    class Program
    {
        static void Main(string[] args)
        {      // Print delegate points to PrintNumber

            Print printDel = PrintNumber;



            printDel(100000);

            printDel(200);



            // Print delegate points to PrintMoney

            printDel = PrintMoney;



            printDel(10000);

            printDel(200);
        }
        public static void PrintNumber(int num)

        {

            Console.WriteLine("Number: {0,-12:N0}", num);

        }



        public static void PrintMoney(int money)

        {

            Console.WriteLine("Money: {0:C}", money);

        }
    }
}
