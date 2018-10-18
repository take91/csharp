using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Test
    {
        public event EventHandler MyEvent

        {

            add

            {

                Console.WriteLine("add operation");

            }



            remove

            {

                Console.WriteLine("remove operation");

            }
            
        }
        static void Main(string[] args)
        {
            Test t = new Test();



            t.MyEvent += new EventHandler(t.DoNothing);

            t.MyEvent -= null;
        }
        void DoNothing(object sender, EventArgs e)

        {

            Console.WriteLine("DoNothing Called...");

        }
    }
}
