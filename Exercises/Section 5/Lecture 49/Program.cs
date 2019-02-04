using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_49
{
	class Program
	{
		static void Main(string[] args)
		{
			Question1();
			Console.WriteLine();
			Question2();
			Console.WriteLine();
			Question3();
			Console.WriteLine();
			Question4();
			Console.WriteLine();
			Question5();
		}

		static void Question1()
		{
			Console.WriteLine("Question1\n---------\n");
			var count = 0;

			for (var i = 1; i <= 100; ++i)
			{
				if (i % 3 == 0)
				{
					++count;
				}
			}

			Console.WriteLine("There are {0} numbers between 1 and 100 divisible by 3", count);
		}

		static void Question2()
		{
			Console.WriteLine("Question2\n---------\n");

			var sum = 0;

			while (true)
			{
				Console.Write("Enter a number (type 'ok' to end): ");
				var input = Console.ReadLine();

				if (input == "ok")
				{
					Console.WriteLine("The sum of all numbers entered is {0}", sum);
					break;
				}
				else
				{
					sum += Convert.ToInt32(input);
				}
			}
		}

		static void Question3()
		{
			Console.WriteLine("Question3\n---------\n");

			Console.Write("Enter a number: ");
			var number = Convert.ToInt32(Console.ReadLine());

			var factorial = number;
			for (var i = number - 1; i >= 1; --i)
			{
				factorial *= i;
			}

			Console.WriteLine("{0}! = {1}", number, factorial);
		}

		static void Question4()
		{
			Console.WriteLine("Question4\n---------\n");

			var chosenNumber = new Random().Next(1, 11);	// from 1 to 11 (max is excluded)
			Console.WriteLine("I chose {0}, but don't tell anyone", chosenNumber);

			var guessesRemaining = 4;
			while(true)
			{
				Console.Write("Enter your guess ({0} guesses remaining): ", guessesRemaining);

				var guess = Convert.ToInt32(Console.ReadLine());
				if (guess == chosenNumber)
				{
					Console.WriteLine("You won");
					break;
				}
				else
				{
					--guessesRemaining;
					if (guessesRemaining == 0)
					{
						Console.WriteLine("You lost");
						break;
					}
				}
			}
		}

		static void Question5()
		{
			Console.WriteLine("Question5\n---------\n");

			Console.WriteLine("Enter a comma-separated series of numbers");

			var input = Console.ReadLine();
			var numStrings = input.Split(',');
			var max = 0;
			foreach (var str in numStrings)
			{
				var num = Convert.ToInt32(str);
				if (num > max)
				{
					max = num;
				}
			}

			Console.WriteLine("Max number is {0}", max);
		}
	}
}
