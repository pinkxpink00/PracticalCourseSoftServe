using System;
using System.Collections;
using System.Collections.Generic;

public class ShowPower
{
	public static IEnumerable<double> SuperPower(int number, int degree)
	{
		if (degree == 0)
		{
			yield return 1;
			yield break;
		}
		if (number == 0)
		{
			yield return 0;
			yield break;
		}
		double result = 1;
		if (degree > 0)
		{
			for(int i =1; i < degree; i++)
			{
				result *= number;
				yield return result;
			}
		}
		if (degree < 0)
		{
			for (int i = 1; i < Math.Abs(degree);i--)
			{
				result *= number;
				yield return 1 / result;
			}
		}
	}
}
