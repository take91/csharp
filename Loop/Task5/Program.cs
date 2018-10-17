using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	class Employee
	{
		int[] _teams;
		public Employee(int[] teams)

		{
			_teams = teams;

		}
		public int[] Teams

		{

			get

			{

				return _teams;

			}

		}

	}


	class Program
	{
		static void Main(string[] args)
		{
			// Declare new int array.

			int[] teams = new int[3];

			teams[0] = 1;

			teams[1] = 2;

			teams[2] = 3;



			// New employee that stores int array reference.

			Employee employee = new Employee(teams);



			// Loop through each int in employee's class.

			foreach (int team in employee.Teams)

			{

				Console.WriteLine(team);

			}
		}
	}
}