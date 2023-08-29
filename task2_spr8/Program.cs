using System.Collections.Generic;
using System.Threading;

public class MainThreadProgram
{
	public void Sum()
	{
		double sum = 0;

		for (int i = 1; i <= 5; i++)
		{
			Console.Write($"Enter the {i}st number: ");
			double number = double.Parse(Console.ReadLine());
			sum += number;
		}

		Console.WriteLine($"Sum is: {sum}");
	}

	public void Product()
	{
		List<int> numbers = new List<int>();

		for (int i = 1; i <= 10; i++)
		{
			numbers.Add(i);
		}

		int product = 1;

		foreach (int num in numbers)
		{
			product *= num;
		}

		Console.WriteLine($"Product is: {product}");

		Thread.Sleep(10000); // Wait for 10 seconds
	}

	public Tuple<Thread, Thread> Calculator()
	{
		Thread sumThread = new Thread(Sum);
		Thread productThread = new Thread(Product);

		sumThread.Start();
		productThread.Start();

		return new Tuple<Thread, Thread>(sumThread, productThread);
	}
}