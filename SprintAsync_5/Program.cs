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
	public static async void PrintSpecificSeqElementsAsync(int[] array)
	{
		List<Exception> exceptions = new List<Exception>();
		List<Task> tasks = new List<Task>();

		foreach (int number in array)
		{

			tasks.Add(Task.Run(() =>
			{
				try
				{
					int result = Calc.Seq(number);
					Console.WriteLine($"Seq[{number}] = {result}");
				}
				catch (Exception ex)
				{
					exceptions.Add(ex);
				}
			}));
		}

		await Task.WhenAll(tasks);
		if (exceptions.Count > 0)
		{

			foreach (var ex in exceptions)
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