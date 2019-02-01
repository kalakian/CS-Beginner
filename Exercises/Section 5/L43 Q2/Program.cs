using System;
using System.Runtime.ConstrainedExecution;

namespace L43_Q2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the first number");
			var firstNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter the second number");
			var secondNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("{0} is the greater of the two numbers entered", (firstNumber > secondNumber) ? firstNumber : secondNumber);
		}
	}
}
