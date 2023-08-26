class Program
{
	static void Main()
	{
		int[] numbers = { 1, 2, 3, 4, 5, 6, };
		int dob = numbers.Aggregate((d,e)  => d * e);
        Console.WriteLine(dob);
    }
}