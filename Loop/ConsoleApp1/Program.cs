using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Swap( int a, int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
			Console.Write("{0}, {1}, {2}", a, b, tmp);

		}



		static void Main(string[] args)
		{
			int a = 10;
			int b = 20;

			Console.WriteLine("a={0}, b={1}", a, b);
			Swap(a, b);
			Console.WriteLine("a={0}, b={1}", a, b);
		}
	}
}
