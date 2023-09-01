class Program
{
	static async Task Main(string[] args)
	{
		try
		{
			await PrintAsync("Hello World");
			await PrintAsync("Hu");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	static async Task PrintAsync(string message)
	{
		if (message.Length < 3)
		{
			throw new ArgumentException($"Invalid string length: {message.Length}");
		}
		await Task.Delay(1000);
		Console.WriteLine(message);
	}
}