class Person
{
	public string Name { get; }
    public Person(string Name)
    {
        this.Name = Name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<string> people = new List<string>() { "Tom" };

        people.Add("Chris");

    }
}