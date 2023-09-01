using System.Diagnostics;

class Program
{
	//static void Main(string[] args)
	//{
	//	PrintName("German");
	//	PrintName("Lucas");
	//	PrintName("Bobo");
	//}

	//static void PrintName(string name)
	//{
	//	Thread.Sleep(3000);
 //       Console.WriteLine(name);
 //   }

	static async Task Main()
	{
		var germanTask = PrintNameAsync("German");
	    var lucasTask = PrintNameAsync("Lucas");
		var boboTask = PrintNameAsync("Bobo");

		await germanTask;
		await lucasTask;
		await boboTask;
	}
	static async Task PrintNameAsync(string name)
	{
		await Task.Delay(2000);
		Console.WriteLine(name);
	}

}