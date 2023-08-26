using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
    public Person() { }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Dobby", 24);

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

        using (FileStream fs = new FileStream("per.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, p1);
            Console.WriteLine("xml created");
        }

        using (FileStream fs2 = new FileStream("per.xml", FileMode.Open))
        {
            Person? person = xmlSerializer.Deserialize(fs2) as Person;
            Console.WriteLine($"Name:{person?.Name}, Age: {person?.Age}");
        }
    }
}