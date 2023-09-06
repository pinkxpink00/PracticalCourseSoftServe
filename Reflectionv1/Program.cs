using System.Diagnostics;

class Program
{
	static void Main(string[] args)
	{
        Type myType = typeof(Person);
        Console.WriteLine(myType.FullName);
    }
}
class Person
{
	string Name { get; }

    public Person(string name)
    {
        this.Name = name;
    }
}