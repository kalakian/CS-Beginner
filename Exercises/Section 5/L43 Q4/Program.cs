using System;

namespace L43_Q4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the speed limit in km/hr");
			var speedLimit = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the speed of the car in km/hr");
			var carSpeed = Convert.ToInt32(Console.ReadLine());

			if (carSpeed <= speedLimit)
			{
				Console.WriteLine("Speed is ok");
			}
			else
			{
				const int kmPerDemeritPoint = 5;
				var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
				Console.WriteLine("You were going too fast, and have incurred {0} demerit points", demeritPoints);

				if (demeritPoints > 12)
				{
					Console.WriteLine("you incurred over 12 demerit points, and as a result  your license has been suspended!");
				}
			}
		}
	}
}
