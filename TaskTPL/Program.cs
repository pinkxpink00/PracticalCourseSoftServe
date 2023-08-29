class Program
{
	static void Main(string[] args)
	{
        Console.WriteLine("Main Starts");
		Action action = new Action(TaskTest);
		Task ts1 = new Task(action);
	    
		ts1.RunSynchronously();
        Console.WriteLine("Main Ends");

    }

	static void TaskTest()
	{
        Console.WriteLine("#Task Starts");
		Thread.Sleep(1000);
		Console.WriteLine("#Task Ends");
    }

}