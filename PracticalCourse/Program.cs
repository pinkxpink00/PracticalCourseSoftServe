using System;

public class Fraction
{
	private int numerator;
	private int denominator;

	public Fraction(int numerator, int denominator)
	{
		
		if (denominator == 0)
		{
			throw new ArgumentException("Denominator cannot be zero.");
		}

		
		Simplify(ref numerator, ref denominator);

		if (denominator < 0)
		{
			this.numerator = -numerator;
			this.denominator = -denominator;
		}
		else
		{
			this.numerator = numerator;
			this.denominator = denominator;
		}
	}


	private void Simplify(ref int numerator, ref int denominator)
	{
		int gcd = GetGCD(numerator, denominator);
		numerator /= gcd;
		denominator /= gcd;
	}

	
	private int GetGCD(int a, int b)
	{
		while (b != 0)
		{
			int temp = b;
			b = a % b;
			a = temp;
		}
		return Math.Abs(a);
	}

	
	public static Fraction operator -(Fraction fraction)
	{
		return new Fraction(-fraction.numerator, fraction.denominator);
	}


	public static Fraction operator +(Fraction fraction)
	{
		return new Fraction(fraction.numerator, fraction.denominator);
	}

	
	public static Fraction operator -(Fraction left, Fraction right)
	{
		int newNumerator = left.numerator * right.denominator - right.numerator * left.denominator;
		int newDenominator = left.denominator * right.denominator;
		return new Fraction(newNumerator, newDenominator);
	}

	
	public static Fraction operator +(Fraction left, Fraction right)
	{
		int newNumerator = left.numerator * right.denominator + right.numerator * left.denominator;
		int newDenominator = left.denominator * right.denominator;
		return new Fraction(newNumerator, newDenominator);
	}

	
	public static Fraction operator *(Fraction left, Fraction right)
	{
		int newNumerator = left.numerator * right.numerator;
		int newDenominator = left.denominator * right.denominator;
		return new Fraction(newNumerator, newDenominator);
	}

	
	public static Fraction operator /(Fraction left, Fraction right)
	{
		if (right.numerator == 0)
		{
			throw new DivideByZeroException("Cannot divide by zero.");
		}
		int newNumerator = left.numerator * right.denominator;
		int newDenominator = left.denominator * right.numerator;
		return new Fraction(newNumerator, newDenominator);
	}

	
	public static Fraction operator !(Fraction fraction)
	{
		return new Fraction(fraction.denominator, fraction.numerator);
	}

	
	public override string ToString()
	{
		return $"{numerator} / {denominator}";
	}

	
	public override bool Equals(object obj)
	{
		if (obj is Fraction other)
		{
			return this.numerator == other.numerator && this.denominator == other.denominator;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return numerator.GetHashCode() ^ denominator.GetHashCode();
	}

	
	public static bool operator ==(Fraction left, Fraction right)
	{
		if (ReferenceEquals(left, null))
		{
			return ReferenceEquals(right, null);
		}
		return left.Equals(right);
	}

	public static bool operator !=(Fraction left, Fraction right)
	{
		return !(left == right);
	}
}
