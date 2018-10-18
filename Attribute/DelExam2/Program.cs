using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelExam2
{
    class Program
    {
        public delegate int MyDelegate(int i, int j);
        static void Main(string[] args)
        {
            TakesADelegate(new MyDelegate(Add));
            TakesADelegate(new MyDelegate(Minus));
            TakesADelegate(new MyDelegate(Gop));
            TakesADelegate(new MyDelegate(Nanugi));
        }
        public static void TakesADelegate(MyDelegate SomeFunction)
        {
            Console.WriteLine(SomeFunction(1, 2));
        }
        public static int Add(int i , int j)
        {
            return i + j;
        }
        public static int Minus(int i , int j)
        {
            return i - j;
        }
        public static int Gop(int i , int j)
        {
            return i * j;
        }
        public static int Nanugi(int i , int j)
        {
            return i / j;
        }

    }
}
