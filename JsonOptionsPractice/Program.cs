using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person("Mike",23);

        var option = new JsonSerializerOptions()
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
        };

        string json = JsonSerializer.Serialize(tom, option);
        Console.WriteLine(json);
        Person? person = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine(person?.Name);
    }
}

class Person
{
	public string Name { get; set; }
	public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}