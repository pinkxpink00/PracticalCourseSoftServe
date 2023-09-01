using System.Runtime.InteropServices;

class Program
{
	static async Task Main()
	{
		var task1 = SquareAsync(5);
		var task2 = SquareAsync(4);
		var task3 = SquareAsync(6);

		int[] result = await Task.WhenAll(task1, task2, task3);

		foreach (int i in result)
		{
			Console.WriteLine(i);
		}
	}

	static async Task<int> SquareAsync(int n)
	{
		await Task.Delay(1000);
		return n*n;
	}
}