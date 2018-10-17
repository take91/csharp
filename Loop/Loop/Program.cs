using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr1 = { 10, 30, 20, 50, 40 };
			BubbleSort(arr1);
			foreach (int a in arr1)
			{
				Console.Write("{0}, ", a);
			}

		}


		static int[] BubbleSort(int[] arr)
		{
			int temp;

			for (int i = 0; i < arr.Length - 2; i++)
			{
				for (int j = i + 1; j < arr.Length - 1; j++)
				{
					if (arr[i] > arr[j])
					{
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}



			return null;
		}
		static int[] SelectionSort(int[] arr)
		{
			return null;
		}


	}
}
