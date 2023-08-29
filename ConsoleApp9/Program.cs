using System;
using System.Threading.Tasks;

class MyTasks
{
	public static void Tasks()
	{
		int[] sequence_array = new int[10];

		Task[] taskArray = new Task[3]
		{
			new Task(() => {
				for (int i = 0; i < 10; i++)
				{
					sequence_array[i] = i * i;
				}
				Console.WriteLine("Calculated");
			}),
			new Task(() =>
			{
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine(i);
				}
				Console.WriteLine("Bye!");
			}),
			new Task(() =>
			{
				
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine(sequence_array[i]);
				}
				Console.WriteLine("Bye!");
			})
		};


		foreach (var task in taskArray)
		{
			task.Start();
			task.Wait();
		}
        Console.WriteLine("Well done!");
    }
}




class Program
{
	static void Main(string[] args)
	{
		MyTasks.Tasks();
	}
}