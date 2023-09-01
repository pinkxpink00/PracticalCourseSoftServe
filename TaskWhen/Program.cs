class Program
{
	static async Task Main()
	{
		var german = PrintAsync("German");
		var jett = PrintAsync("Jett");
		var luca = PrintAsync("Luca");

		await Task.WhenAll(german, jett, luca);
	}

	static async Task PrintAsync(string message)
	{
		await Task.Delay(1000);
		Console.WriteLine(message);
	}
}