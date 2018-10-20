using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 7. 간단한 C# 속성(Property) 예문 입니다. 결과를 보고 괄호를 채우세요
//[결과]

//Student Info: Code = 001, Name = Zara, Age = 9

//Student Info: Code = 001, Name = Zara, Age = 10

namespace Test7
{
    class Student
    {

        private string code = "N.A";

        private string name = "not known";

        private int age = 0;



        // Declare a Code property of type string:

        public string Code
        {

            get { return this.code; }
            set { this.code = value; }


        }



        // Declare a Name property of type string:

        public string Name
        {

            get { return this.name; }
            set { this.name = value; }

        }



        // Declare a Age property of type int:

        public int Age
        {

            get { return this.age; }
            set { this.age = value; }

        }

        public override string ToString()
        {

            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {   // Create a new Student object:

            Student s = new Student();



            // Setting code, name and the age of the student

            s.Code = "001";

            s.Name = "Zara";

            s.Age = 9;

            Console.WriteLine("Student Info: {0}", s);



            //let us increase age

            s.Age += 1;

            Console.WriteLine("Student Info: {0}", s);

            Console.ReadKey();
        }
    }
}
