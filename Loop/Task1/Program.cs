using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			//가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4

			int[][] a = new int[3][];
			a[0] = new int[] { 1, 2 };
			a[1] = new int[] { 1, 2, 3 };
			a[2] = new int[] { 1, 2, 3, 4 };


			//3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)

			int[,] b = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

			//가변배열 출력

		


			foreach(int[] i in a)
			{
				foreach(int j in i)
				{
					Console.Write(j + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("\n---------------\n");

			//이차원 배열 출력



			foreach (int i in b)
			{
				Console.Write(i + " ");
			}

		}
	}
}
