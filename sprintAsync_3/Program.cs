using System.Threading;
using System.Threading.Tasks;

class Calc
{
	public static int Seq(int n)
	{
		return n * n;
	}
}

class CalcAsync
{
	static async Task<int> SeqAsync(int n)
	{
		int result = await Task.Run(() => Calc.Seq(n));
		Console.WriteLine($"Seq[{n}] = {result}");
	}

	
}