using System.Collections.Generic;

public class PowersOf2
{
	static void Main(string[] args)
	{
		foreach (int i in Power(2, 5))
		{
			Console.WriteLine("{0}", 1);
		}
	}
	public static IEnumerable<int> Power(int number, int exponent)
	{
		int result = 1;
		for (int i = 0; i < exponent; i++)
		{
			result = result * number;
			yield return result;
		}
	}

}