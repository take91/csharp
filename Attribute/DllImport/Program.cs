using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace DllImport
{
    class Program
    {   
        [DllImport("User32.dll")]
        public static extem int MessageBox(int h, string m, string c, int type)
        {

        }

        static void Main(string[] args)
        {
            MessageBox(0,"hello","inC#",0);
        }
    }
}
