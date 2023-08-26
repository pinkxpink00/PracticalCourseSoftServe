public static class StringExt
{
	public static string Reverse(this string s)
	{
		char[] charArray = s.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}
}

class Program
{
	static void Main(string[] args)
	{
		string original = "Hello World";
		string reversed = original.Reverse();
        Console.WriteLine(original);
		Console.WriteLine(reversed);
    }
}