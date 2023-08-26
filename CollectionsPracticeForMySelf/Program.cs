class Program
{
	static void Main(string[] args)
	{
		List<Person> list = new List<Person>();

		var employee = new List<string>() { "Tom", "Bob" };
        var employee2 = new List<string>(employee) { "Sonya" };
        var mainVar = employee2;

        foreach (var personName in mainVar)
        {
            Person person = new Person(personName);
            list.Add(person);
            Console.WriteLine(person.Name);
        }
    }
}

class Person
{
	public string Name { get; }
    public Person(string name)
    {
        Name = name;
    }
}