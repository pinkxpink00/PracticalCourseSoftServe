class Program
{
	public delegate void PrintSomething(int value); 
	static void Main(string[] args)
	{
		PrintSomething delFunc = PrintNum;

		delFunc += PrintHexDecimal;
		delFunc += PrintMoney;

		PrintHelper(delFunc, 200);
		PrintHelper(delFunc, 40000);

		delFunc -= PrintMoney;
		PrintHelper(delFunc, 100);
	}

	public static void PrintHelper(PrintSomething delFunc, int someValue)
	{
		delFunc(someValue);
	}
	public static void PrintNum(int num)
	{
		Console.WriteLine(num);
	}

	public static void PrintMoney(int money)
	{
        Console.WriteLine(money);
    }

	public static void PrintHexDecimal(int dec)
	{
        Console.WriteLine(dec);
    }
}
