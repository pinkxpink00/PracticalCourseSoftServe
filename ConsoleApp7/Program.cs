class Program
{
	static void Main(string[] args)
	{
		string[] names = { "Jai", "Jayesh", "Joy" };
		IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4).Select(n => n.Length.ToString());
		foreach(var item in filteredNames)
		{
            Console.WriteLine(item);
        }
	}
}