using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelExam4
{
    delegate void OnjDelegate(int a, int b);

    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiple(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        void Divide(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, Math.Round((a / (float)b),2)); }

        static void Main(string[] args)
        {
            Program m = new Program();

            //OnjDelegate CallBack = new OnjDelegate(Program.Plus);
            //CallBack += new OnjDelegate(Program.Minus);
            //CallBack += new OnjDelegate(m.Multiple);
            //CallBack += new OnjDelegate(m.Divide);

            //OnjDelegate CallBack1 = new OnjDelegate(Program.Plus);
            //OnjDelegate CallBack2 = new OnjDelegate(Program.Minus);
            //OnjDelegate CallBack3 = new OnjDelegate(m.Multiple);
            //OnjDelegate CallBack4 = new OnjDelegate(m.Divide);
            //OnjDelegate CallBack = CallBack1 + CallBack2 + CallBack3 + CallBack4;

            OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
                new OnjDelegate(Program.Plus),
                new OnjDelegate(Program.Minus),
                 new OnjDelegate(m.Multiple),
                 new OnjDelegate(m.Divide)
                );



            CallBack(4, 3);
        }
    }
}
