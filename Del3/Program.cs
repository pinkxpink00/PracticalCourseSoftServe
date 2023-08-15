using System;

namespace Del_3
{
	delegate int Operation(int x, int y);
	class Program
	{
		static void Main(string[] args)
		{
			Operation op1 = Add;
			int result = op1(1, 99);
            Console.WriteLine(result);

			op1 = Multiply;
			result = op1(1, 5);
            Console.WriteLine(result);
        }

		static int Add (int x, int y)
		{
			return x + y;
		}

		static int Multiply(int x, int y)
		{
			return (x * y);
		}
	}
}