using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            int[] arr2 = new int[2] { 10, 20 };
            int[] arr3 = new int[] { 10, 20 };
            int[] arr4 = { 10, 20 };
            for (int i = 0; i < 2; i++)
            {
                Console.Write(arr4[i]);
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            foreach(int i in arr2){
                Console.WriteLine(i);
            }
        }
    }
}
