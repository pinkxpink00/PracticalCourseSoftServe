using System.Threading;
using System.Threading.Tasks;

public class CalcAsync
{
	public static async Task<int> SeqAsync(int n)
	{
		return await Task.Run(() => Calc.Seq(n));
	}

	public static async void PrintSeqElementsConsequentlyAsync(int quant)
	{
		for (int i = 1; i <= quant; i++)
		{
			int result = await SeqAsync(i);
			Console.WriteLine($"Seq[{i}] = {result}");

		}

	}

	public static async void PrintSeqElementsInParallelAsync(int quant)
	{
		Task<int>[] tasks = GetSeqAsyncTasks(quant);
		await Task.WhenAll(tasks);

		for (int i = 1; i <= quant; i++)
		{
			int result = tasks[i - 1].Result;
			Console.WriteLine($"Seq[{i}] = {result}");

		}
	}

	public static Task<int>[] GetSeqAsyncTasks(int quant)
	{
		Task<int>[] tasks = new Task<int>[quant];
		for (int i = 1; i <= quant; i++)
		{
			int index = i;
			tasks[i - 1] = Task.Run(() => Calc.Seq(index));
		}
		return tasks;
	}
}