//using System.Diagnostics.Metrics;

//We have the class MainThreadProgram. Please create three methods: Calculator, Product, and Sum.

//Method Sum() should ask the user to enter 5 numbers in the form “Enter the 1st number:”, “Enter the 2nd number:” etc.and calculate their sum. After that, it should output the message “Sum is: < sum >”. 

//Method Product() should generate a List of 10 consequent integer numbers from 1 to 10 and calculate their product. Then it should wait for 10 seconds. After that, it should output the message “Product is: < product >”. 

//The Calculator() method should create two threads: productThread and sumThread, and call the Product and Sum methods in appropriate threads. This method should return a tuple of two threads: (sumThread, productThread).


//Answer:(penalty regime: 0 %)

class MainThreadProgram
{
	public void Calculator()
	{
		Thread productThread = new Thread(Product);
		Thread sumThread = new Thread(Sum);
		sumThread.Start();


	}

	public void Product()
	{
		int productResult = 1;

		List<int> numbers = new List<int>();
		for (int i = 1; i <= 10; i++)
		{
			numbers.Add(i);
			productResult *= i;
		}
		Thread.Sleep(10000); 
		Console.WriteLine($"Product is: {productResult}");
	}

	public void Sum()
	{
		string[] numberEnding = { "st", "nd", "rd", "th", "th" };
		int sum = 0;
		for (int i = 1; i <= 5; i++)
		{
			Console.WriteLine($"Enter the {i}{numberEnding[i - 1]} number: ");
			int number = Convert.ToInt32(Console.ReadLine());
			sum += number;
		}
		Console.WriteLine($"Sum is: {sum}");
	}
}

class Program
{
	static void Main()
	{
	 MainThreadProgram mainThreadProgram = new MainThreadProgram();
		mainThreadProgram.Calculator();
	}
}