public class Person
{
	public string LastName { get; set; }
	public string FirstName { get; set; }
}

public static class StringExtension
{
	public static bool EqualIgnoreCase(this string s1, string s2)
	{
		return string.Equals(s1, s2,StringComparison.OrdinalIgnoreCase);
	}

}

class Program
{
	public static List<Person> GetPeople()
	{
		List<Person> people = new List<Person>()
		{
			new Person{FirstName="Tod",LastName="Cerw"},
			new Person{FirstName="Ben",LastName="Smith"}
		};
		return people;
	}
	static void Main()
	{
		List<Person> people =GetPeople();

		var filteredPeople = people.Where(Person => Person.LastName.EqualIgnoreCase("Smith")).ToList();
	}
}