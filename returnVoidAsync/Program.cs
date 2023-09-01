class Program
{
	static async Task Main(string[] args)
	{
		Account account = new Account();
		account.Added += PrintAsync;

		account.Put(500);

		await Task.Delay(2500);
	}

	static async void PrintAsync(object? obj, string message)
	{
		await Task.Delay(3000);
		Console.WriteLine(message);  
	}
}

class Account
{
	int sum = 0;
	public event EventHandler<string>? Added;
	public void Put(int sum)
	{
		this.sum += sum;
		Added?.Invoke(this, $"На счёт поступило:{sum}$");
	}
}