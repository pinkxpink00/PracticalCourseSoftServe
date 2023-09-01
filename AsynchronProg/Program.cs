class Program
{
	static void Main()
	{
		FactorialAsync();
        Console.WriteLine("Enter the number:");
		int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Square equals:{n*n}");
		Console.ReadLine();
    }

	static void Factorial()
	{
		int result = 1;

		for (int i = 0; i < 6; i++)
		{
			result *= i;
		}
		Thread.Sleep(8000);
        Console.WriteLine($"Factorial result:{result}");
    }

	static async void FactorialAsync()
	{
		Console.WriteLine("Begin FactorialAsync");
		await Task.Run(() => Factorial());
		Console.WriteLine("End FactorialAsync");
    }
}