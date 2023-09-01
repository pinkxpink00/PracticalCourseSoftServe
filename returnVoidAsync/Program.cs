class Program
{
	static async Task Main(string[] args)
	{
		int n1 = await SquareAsync(5);
		int n2 = await SquareAsync(3);

		Console.WriteLine($"n1 = {n1}  n2 = {n2}");
    }
	static async Task<int> SquareAsync(int n)
	{
		await Task.Delay(1000);
		return n*n;
	}
}
