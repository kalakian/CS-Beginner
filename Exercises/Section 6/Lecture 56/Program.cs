using System;
using System.Collections.Generic;
using System.Linq;

namespace Section_6
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

			var likes = new List<string>();

			while (true)
			{
				Console.Write("Enter friend's name: ");
				var input = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(input))
				{
					break;
				}
				likes.Add(input);
			}

			switch (likes.Count)
			{
				case 0:
					break;

				case 1:
					Console.WriteLine("{0} likes your post.", likes[0]);
					break;

				case 2:
					Console.WriteLine("{0} and {1} like your post.", likes[0], likes[1]);
					break;

				default:
					Console.WriteLine("{0}, {1} and {2} others like your post.", likes[0], likes[1], likes.Count - 2);
					break;
			}
		}

		static void Question2()
		{
			Console.WriteLine("Question 2\n----------\n");

			Console.Write("Enter your name: ");
			var input = Console.ReadLine();
			var array = input.ToCharArray();
			Array.Reverse(array);
			var reversedString = new string(array);
			Console.WriteLine("Your name in reverse is: " + reversedString);
		}

		static void Question3()
		{
			Console.WriteLine("Question 3\n----------\n");

			var numbers = new List<int>();

			while (numbers.Count < 5)
			{
				Console.Write("Enter a number: ");
				var input = Console.ReadLine();
				var number = Convert.ToInt32(input);

				if (numbers.Contains(number))
				{
					Console.WriteLine("You've already entered that number, try again");
				}
				else
				{
					numbers.Add(number);
				}
			}

			numbers.Sort();
			var strNumbers = string.Join(", ", numbers);
			Console.WriteLine("The numbers you entered, in increasing order: " + strNumbers);
		}

		static void Question4()
		{
			Console.WriteLine("Question 4\n----------\n");

			var numbers = new List<int>();

			while(true)
			{
				Console.Write("Enter a number, or 'Quit' to exit: ");
				var input = Console.ReadLine();
				if (input.ToLower() == "quit")
				{
					break;
				}
				else
				{
					var number = Convert.ToInt32(input);

					if (!numbers.Contains(number))
					{
						numbers.Add(number);
					}
				}
			}

			var strNumbers = string.Join(", ", numbers);
			Console.WriteLine("The unique numbers you entered are: " + strNumbers);
		}

		static void Question5()
		{
			Console.WriteLine("Question 5\n----------\n");

			Console.WriteLine("Enter a comma-separated 5 or more numbers");

			var input = Console.ReadLine();
			var numStrings = input.Split(',');
			var numList = new List<int>();
			if (numStrings.Length < 5)
			{
				Console.WriteLine("Invalid List");
			}
			else
			{
				foreach (var str in numStrings)
				{
					numList.Add(Convert.ToInt32(str));
				}
				numList.Sort();
				Console.WriteLine("3 smallest numbers are: {0}, {1}, {2}", numList[0], numList[1], numList[2]);
			}
		}
	}
}
