using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 8. 자동구현 속성 입니다. 괄호를 채워주세요.


namespace Test8
{
    public class Customer

    {

        public int ID
        {
            get; set;
        }

        public string Name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();



            cust.ID = 1;

            cust.Name = "Amelio Rosales";



            Console.WriteLine(

                "ID: {0}, Name: {1}",

                cust.ID,

                cust.Name);



            Console.ReadKey();
        }
    }
}
