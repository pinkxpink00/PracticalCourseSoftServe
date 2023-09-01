class Program
{
	static void Main(string[] args)
	{
		PrintName("German");
		PrintName("Lucas");
		PrintName("Bobo");
	}

	static void PrintName(string name)
	{
		Thread.Sleep(3000);
        Console.WriteLine(name);
    }
}