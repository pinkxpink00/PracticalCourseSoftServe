class Program
{
	static async Task Main(string[] args)
	{
		await PrintAsync();
		Console.WriteLine("Some actions in method Main");

    }
	
	static void Print()
	{
		Thread.Sleep(3000);
        Console.WriteLine("Hello C#");
    }

	static async Task PrintAsync()
	{
		Console.WriteLine("Start Async");
		await Task.Run(()=>Print());
		Console.WriteLine("End Async");

    }
}