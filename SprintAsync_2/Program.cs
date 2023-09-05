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
		await Task.Run(() => Console.WriteLine("Seq[" + n + "] = " + Calc.Seq(n)));
	}

	public static void PrintStatusIfChanged(this Task task, ref TaskStatus previousStatus)
	{
		if (task.Status != previousStatus)
		{
			Console.WriteLine(task.Status);
			previousStatus = task.Status;
		}
	}

	public static void TrackStatus(this Task task)
	{
		TaskStatus previousStatus = TaskStatus.Created;

		while (!task.IsCompleted)
		{
			task.PrintStatusIfChanged(ref previousStatus);
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