using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        Type myType = typeof(Person);

        Console.WriteLine("Fields:");

        foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic
            | BindingFlags.Public | BindingFlags.Static))
        {
            string modificator = "";

            if (field.IsPublic)
                modificator += "public";
			else if (field.IsPrivate)
				modificator += "private ";
			else if (field.IsAssembly)
				modificator += "internal ";
			else if (field.IsFamily)
				modificator += "protected ";
			else if (field.IsFamilyAndAssembly)
				modificator += "private protected ";
			else if (field.IsFamilyOrAssembly)
				modificator += "protected internal ";

			if (field.IsStatic) modificator += "static ";

			Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
		}
    }
}

class Person
{
	static int minAge = 0;
	string name;
	int age;
    private int hashCode;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print() => Console.WriteLine($"{name} - {age}");
}