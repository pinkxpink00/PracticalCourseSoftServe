class Program
{
	static void Main(string[] args)
	{
		string[] people = { "Tom", "Bob", "Lorry", "Ted" };

		var selectedPeople = from p in people
							 where p.ToUpper().StartsWith("T")
							 orderby p
							 select p;

		foreach (string person in selectedPeople)
		{
            Console.WriteLine(person);
        }
	}
}