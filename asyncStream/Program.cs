class Program
{
	static async Task Main()
	{
		await foreach (var number in GetNumbersAsync())
		{
			Console.WriteLine(number);
		}
	}

	static async IAsyncEnumerable<int> GetNumbersAsync()
	{
		for (int i = 0; i < 10; i++)
		{
			await Task.Delay(1000);
			yield return i;
		}
	}
}