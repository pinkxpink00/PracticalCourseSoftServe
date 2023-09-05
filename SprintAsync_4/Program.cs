using System;
using System.Collections.Generic;
using System.Threading.Tasks;
class Calc
{
	public static int Seq(int n)
	{
		return n * n;
	}
}

class CalcAsync
{
	async IAsyncEnumerable<int> SeqStreamAsync(int n)
	{
		for (int i = 0; i < 10; i++)
		{
			await Task.Delay(100);
			yield return i;
		}
	}

	public static async Task PrintStreamAsync(IAsyncEnumerable<(int, int)> stream)
	{
		await foreach (var item in stream)
		{
			Console.WriteLine($"Seq[{item.Item1}] = {item.Item2}");
		}
	}
}