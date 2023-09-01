class Program
{
	static async Task Main(string[] args)
	{
		await PrintAsync();
		Console.WriteLine("Some actions in method Main");

    }
	
	static void Print()
	{
        Console.WriteLine("Hello C#");
    }

	static async Task PrintAsync()
	{
		
		Console.WriteLine("Start Async");
		await Task.Delay(4000);
		await Task.Run(()=>Print());
		await Task.Delay(2000);
		Console.WriteLine("End Async");

    }
}