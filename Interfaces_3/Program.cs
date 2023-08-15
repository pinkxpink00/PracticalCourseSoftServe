using System;


namespace Interfaces_Three
{
	class Program
	{
		interface IMovable
		{
			public const int minSpeed = 0;
			private static int maxSpeed = 60;
			static double GetTime (double distance, double speed) => distance / speed;
			static int MaxSpeed
			{
				get { return maxSpeed; }
				set { if (value > 0) maxSpeed = value; }
			}
		}

		static void Main(string[] args)
		{
            Console.WriteLine(IMovable.MaxSpeed);
			IMovable.MaxSpeed = 65;
            Console.WriteLine(IMovable.MaxSpeed);
			double time = IMovable.GetTime(100, 10);
            Console.WriteLine(time);
        }
	}
}