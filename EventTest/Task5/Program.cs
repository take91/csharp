using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class MyClass

    {

        public void Process()

        {

            Console.WriteLine("Process() begin");

            Console.WriteLine("Process() end");

        }

    }
    class Program
    {
        public delegate void Action();
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.Process();

            Console.WriteLine("----------------------------");

            Action doAction = myClass.Process;

            doAction();
            





        }
    }
}
