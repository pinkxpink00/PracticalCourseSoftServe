using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person("Tom",55);

        var option = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
        };
        string json = JsonSerializer.Serialize(tom,option);
        Console.WriteLine(json);
        Person? person = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine($"Name: {person?.Name} Age:{person?.Age}");
    }
}

class Person
{
    [JsonPropertyName("firstName")]
	public string Name {get;set;}
    [JsonIgnore]
	public int Age { get; set;}
    public Person(string name,int age)
    {
        this.Name = name;
        this.Age = age;
    }
}