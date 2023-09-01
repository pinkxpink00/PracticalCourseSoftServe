class Program
{
	static async Task Main(string[] args)
	{

		await Task.Delay(2500);
		await PrintAsync("Hello");
	}

	static async Task PrintAsync(string message)
	{
		await Task.Delay(3000);
		Console.WriteLine(message);  
	}
}
