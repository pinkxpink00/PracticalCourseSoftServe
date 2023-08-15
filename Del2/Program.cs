class Program
{
	public delegate void PrintSomething(int value);

	public static void Main(string[] args)
	{
		PrintHelper(PrintMoney, 20000);
		PrintHelper(PrintNum, 2333);
	}

	public static void PrintHelper(PrintSomething delegateFunc, int numToPrint)
	{
		delegateFunc(numToPrint);
	}

	public static void PrintMoney(int money)
	{
        Console.WriteLine("Money: {0}", money);
    }

	public static void PrintNum(int num)
	{
		Console.WriteLine("num{0}", num);
	}
}