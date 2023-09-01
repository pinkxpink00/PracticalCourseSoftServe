class Program
{
	static async Task Main()
	{
		var result = await AddSync(4, 5);
		Console.WriteLine(result);
	}
	static ValueTask<int> AddSync(int a, int b)
	{
		return new ValueTask<int>(a + b);
	}
}

