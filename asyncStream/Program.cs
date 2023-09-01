class Program
{
	static async Task Main(string[] args)
	{
		Repository repository = new Repository();
		IAsyncEnumerable<string> data = repository.GetDataAsync();

		await foreach (var item in data)
		{
			Console.WriteLine(item);
		}
	}
}

class Repository
{
	string[] data = { "German", "Tom", "Bob", "Lucas" };

	public async IAsyncEnumerable<string> GetDataAsync()
	{
		for (int i = 0; i < data.Length; i++)
		{
			Console.WriteLine($"Get {i + 1} element");
			await Task.Delay(1000);
			yield return data[i];
		}
	}
}