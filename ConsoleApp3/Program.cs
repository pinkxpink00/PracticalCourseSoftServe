using System;

namespace Interfaces_Four
{
	interface IMovable
	{
		void Move()
		{
			Console.WriteLine("Moving");
		}
	}
	class Program
	{
		

		static void Main(string[] args)
		{
			IMovable tom = new Person();
			tom.Move();

			Car audi = new Car();
			audi.Move();
		}
	}

	class Person : IMovable { }
	class Car : IMovable
	{
		public void Move()
		{
            Console.WriteLine("Driving");
        }
	}
}