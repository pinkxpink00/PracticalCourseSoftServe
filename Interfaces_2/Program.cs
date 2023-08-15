using System;

namespace Interfaces_Two
{
	class Program
	{
        interface IMovable
        {
            void Move()
			{
                Console.WriteLine("Move");
            }

            int MaxSpeed { get { return 0; }}
        }
        static void Main(string[] args)
		{
            
        }
	}
}