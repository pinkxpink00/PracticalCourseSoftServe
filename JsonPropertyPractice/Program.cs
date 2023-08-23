using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person("Tom",55);

        string json = JsonSerializer.Serialize(tom);
        Console.WriteLine(json);
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