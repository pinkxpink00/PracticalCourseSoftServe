using System;

namespace Del_Ev
{
	class Program
	{
		public delegate void PrintSomething(int value);
		static void Main(string[] args)
		{
			PrintSomething printDel = PrintNumber;

			printDel(1000);
			printDel(10002222);

			printDel = PrintMoney;

			printDel(2323);
			printDel(2222222);
		}

		public static void PrintNumber(int num)
		{
            Console.WriteLine("Number {0}",num);
        }

		public static void PrintMoney(int money)
		{
			Console.WriteLine("Money: {0}", money);
		}
	}
}