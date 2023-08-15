delegate void Message();

class Program
{
	static void Main()
	{
		Message mes = Hello;
		Message mes1 = Hi;
		mes();
		mes1();
	}

	public static void Hello()
	{
        Console.WriteLine("Hello World");
    }

	public static void Hi()
	{
        Console.WriteLine("Hi");
    }
}