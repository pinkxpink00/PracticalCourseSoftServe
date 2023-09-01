class Program
{
	static async Task Main(string[] args)
	{
		var task = PrintAsync("Hello Tasks");
		Console.WriteLine("Hello World");
		await task;
    }

	static async Task PrintAsync(string message)
	{
		await Task.Delay(3000);
		Console.WriteLine(message);  
	}
}
