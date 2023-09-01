class Program
{
	static async Task Main()
	{
		var german = PrintAsync("German");
		var jett = PrintAsync("Jett");
		var luca = PrintAsync("Luca");

		await Task.WhenAny(german, jett, luca);
	}

	static async Task PrintAsync(string message)
	{
		await Task.Delay(new Random().Next(1000,2000));
		Console.WriteLine(message);
	}
}