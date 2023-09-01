class Program
{
	static void Main()
	{
		CancellationTokenSource cts = new CancellationTokenSource();
		CancellationToken token = cts.Token;
		Factorial(6, token);
		Thread.Sleep(3000);
		cts.Cancel();
		Console.Read();
	}

	static void Factorial(int n, CancellationToken token)
	{
		int result = 1;

		for(int i = 0; i <= n; i++)
		{
			if (token.IsCancellationRequested)
			{
				Console.WriteLine("Aborted");
				return;
            }
			result *= i;
            Console.WriteLine($"The factorial of {i} equals {result}");

			Thread.Sleep(1000);
        }
	}

	static async void FactorialAsync(int n, CancellationToken token)
	{
		if (token.IsCancellationRequested)
		{
			return;
		}
		await Task.Run (()=> Factorial(n, token));
	}
}