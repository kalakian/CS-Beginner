using System;

namespace L43_Q3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the width of the image");
			var width = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter the height of the image");
			var height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("The image is in the {0} orientation", (width > height) ? "landscape" : "portrait");
		}
	}
}
