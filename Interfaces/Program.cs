using System;

namespace Interfaces
{
	class Program
	{
		interface IMovable
		{
			const int minSpeed = 0;
			static int maxSpeed = 60;
			void Move();
			string Name { get; set; }
			delegate void MoveHandler(string name);
			event MoveHandler MoveEvent;

		}

		static void Main(string[] args)
		{
            Console.WriteLine(IMovable.minSpeed);
            Console.WriteLine(IMovable.maxSpeed);
			Console.ReadKey();
        }
	}
}