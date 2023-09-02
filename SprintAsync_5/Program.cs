using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;


class Calc
{
	public static int Seq(int n)
	{
		return n * n;
	}
}
public class CalcAsync
{
	public async static void PrintSpecificSeqElementsAsync(int[] array)
	{
		var exeptions = new List<Exception>();
		var tasks = new List<Task>();
		foreach (var n in array)
		{
			tasks.Add(Task.Run(() =>
			{
				try
				{
					Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}");
				}
				catch (Exception ex)
				{
					exeptions.Add(ex);
				}
			}));

		}
		await Task.WhenAll(tasks);
		if (exeptions.Count > 0)
		{
			foreach (var ex in exeptions)
			{
				Console.WriteLine("Inner exception: " + ex.Message);
			}
		}
	}
}

class Program
{
	static async Task Main(string[] args)
	{
		int[] numbers = { -3, -5, -12, 0 };
		CalcAsync.PrintSpecificSeqElementsAsync(numbers);
		Thread.Sleep(1000);
	}
}