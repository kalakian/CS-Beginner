using System;

namespace L43_Q1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number from 1 to 10");

			var numEntered = Convert.ToInt32(Console.ReadLine());

			if(numEntered >= 1 && numEntered <= 10)
			{
				Console.WriteLine("{0} is a valid number", numEntered);
			}
			else
			{
				Console.WriteLine("{0} is an invalid number", numEntered);
			}
		}
	}
}
