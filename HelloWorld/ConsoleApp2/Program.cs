using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyConstants
    {
        public const double PI = 3.141592;  // const == static final
        public const int MYAGE = 22;
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyConstants m = new MyConstants();
            double radius = 2;
            double area = MyConstants.PI * (radius * radius);
            Console.WriteLine("Area = {0}, Age = {1}", area, MyConstants.MYAGE);

            const string name = "홍길동";
            Console.WriteLine("name : " + name);


        }
    }
}
