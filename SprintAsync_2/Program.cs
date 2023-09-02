using System.Threading.Tasks;

public class Calc
{
	
	public static int Seq(int n)
	{
		
		return n * n;
	}
}

public static class CalcAsync
{
	public static async Task TaskPrintSeqAsync(int n)
	{
		try
		{
			int result = await Task.Run(() => Calc.Seq(n));
			Console.WriteLine($"Seq[{n}] = {result}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}

	public static void PrintStatusIfChanged(this Task task, ref TaskStatus previousStatus)
	{
		if (task == null)
			throw new ArgumentNullException(nameof(task));

		if (task.Status != previousStatus)
		{
			Console.WriteLine(task.Status.ToString());
			previousStatus = task.Status;
			
		}
	}

	public static async void TrackStatus(this Task task)
	{
		if (task == null)
			throw new ArgumentNullException(nameof(task));

		TaskStatus previousStatus = TaskStatus.Created;

		while (!task.IsCompleted)
		{
			task.PrintStatusIfChanged(ref previousStatus);
			await Task.Delay(100);
		}

		task.PrintStatusIfChanged(ref previousStatus);
	}
}

class Program
{
	static async Task Main(string[] args)
	{
		Task t = CalcAsync.TaskPrintSeqAsync(35);
		t.TrackStatus();
	}
}