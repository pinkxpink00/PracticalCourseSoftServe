using System;
using System.Text.Json;

class Program
{
	static void Main(string[] args)
	{
		using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
		{
			Person tom = new Person("Tom",53);
			JsonSerializer.SerializeAsync<Person>(fs, tom);
            Console.WriteLine("Data has been saved to file");
        }

		using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
		{
			Person? person = JsonSerializer.Deserialize<Person>(fs);
			Console.WriteLine($"Name:{person?.Name}, Age: {person?.Age}");
        }
	}
			


}

public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
    public Person(string name,int age)
    {
        this.Name = name;
		this.Age = age;
    }
}