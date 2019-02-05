using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Lecture_68
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
			Console.WriteLine("Question 1\n----------\n");

			Console.WriteLine("Enter a series of numbers separated by a hyphon: ");
			var input = Console.ReadLine();
			var strArray = input.Split('-');

			var prev = Convert.ToInt32(strArray[0]) - 1;

			foreach (var strVal in strArray)
			{
				var num = Convert.ToInt32(strVal);

				if (num == prev + 1)
				{
					prev = num;
				}
				else
				{
					Console.WriteLine("Not Consecutive");
					return;
				}
			}

			Console.WriteLine("Consecutive");
		}

		static void Question2()
		{
			Console.WriteLine("Question 2\n----------\n");

			Console.WriteLine("Enter a series of numbers separated by a hyphon: ");
			var input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				return;
			}

			var strArray = input.Split('-');
			var numbers = new List<int>();

			foreach(var strVal in strArray)
			{
				var num = Convert.ToInt32(strVal);

				if(numbers.Contains(num))
				{
					Console.WriteLine("Duplicate");
					return;
				}
				
				numbers.Add(num);
			}
		}

		static void Question3()
		{
			Console.WriteLine("Question 3\n----------\n");

			Console.WriteLine("Enter a 24-hour time value as HH:mm");
			var input = Console.ReadLine();

			var timeParts = input.Split(':');
			if (timeParts.Length == 2)
			{
				var hours = Convert.ToInt32(timeParts[0]);
				var minutes = Convert.ToInt32(timeParts[1]);

				if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
				{
					Console.WriteLine("Ok");
					return;
				}
			}

			Console.WriteLine("Invalid Time");
		}

		static void Question4()
		{
			Console.WriteLine("Question 4\n----------\n");

			Console.WriteLine("Please enter a few words separated by a space:");
			var input = Console.ReadLine();
			var words = input.Split(' ');

			var builder = new StringBuilder();
			foreach (var word in words)
			{
				builder.Append(char.ToUpper(word[0]));
				if (word.Length > 1)
				{
					builder.Append(word.Substring(1).ToLower());
				}
			}

			Console.WriteLine(builder);
		}

		static void Question5()
		{
			Console.WriteLine("Question 5\n----------\n");

			Console.Write("Enter an English word: ");

			var input = Console.ReadLine().ToLower();
			var vowels = "aeiou";
			var count = 0;

			foreach (var c in input)
			{
				if (vowels.IndexOf(c) != -1)
				{
					++count;
				}
			}

			Console.WriteLine("Vowels found: " + count);
		}
	}
}
