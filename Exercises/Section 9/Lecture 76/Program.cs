using System;
using System.IO;

namespace Lecture_76
{
	class Program
	{
		static void Main(string[] args)
		{
			var path = @"..\..\words.txt";	// up two directories from bin\Debug

			var text = File.ReadAllText(path);
			var words = text.Split(' ');

			Console.WriteLine("Number of words in '{0}' is {1}", Path.GetFileName(path), words.Length);

			var longestWord = "";
			foreach (var word in words)
			{
				if (word.Length > longestWord.Length)
				{
					longestWord = word;
				}
			}

			Console.WriteLine("Longest word in '{0}' is {1}", Path.GetFileName(path), longestWord);
		}
	}
}
