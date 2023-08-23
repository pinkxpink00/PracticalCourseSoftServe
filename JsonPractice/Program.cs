using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args) 
    {
        Person tom = new Person("Tom", 24);
        string json = JsonSerializer.Serialize(tom);
        Console.WriteLine(json);
        Person? restoredPerson = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine(restoredPerson.Name,restoredPerson.Age);
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