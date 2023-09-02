using System.Diagnostics;

class Calc
{
	static int Seq(int n)
	{
		return n * n;
	}
}

class CalcAsync
{
	static async Task PrintSeqAsync(int n)
	{
		int result = await Task.Run(() => Calc.Seq(n));

		Console.WriteLine($"Seq[{n}] = {result}");
	}
}