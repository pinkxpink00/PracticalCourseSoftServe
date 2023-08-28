class Program
{
	static void Main(string[] args)
	{
	    Task task = new Task(() => Console.WriteLine("Hello Task"));
		task.Start();
		task.Wait();

        Task task1 = Task.Factory.StartNew(() => Console.WriteLine("Hello Factory Task!"));
		task1.Wait();

		Task task2 = Task.Run(() => Console.WriteLine("Hello task Run "));
		task2.Wait();
	}

}