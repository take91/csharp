using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> myMethod = (i, j) => Console.WriteLine(i + j);
            myMethod(10, 20);
        }
    }
}