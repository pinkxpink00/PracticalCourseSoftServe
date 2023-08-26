using System.Xml.Serialization;
using System.IO;

[Serializable]
public class Person
{
	private int _id;
	public string FirstName;
	public string LastName;
	public void SetId(int id)
	{
		_id = id;
	}

	public override string ToString()
	{
		return $"ID: {_id}, FirstName: {FirstName}, LastName: {LastName}";
	}
}

class Program
{
	static void Main(string[] args)
	{
		Person st1 = new Person();
		st1.FirstName = "German";
		st1.LastName = "Gritsenko";
		XmlSerializer xmlser = new XmlSerializer(typeof(Person));
		using (Stream serialStream = new FileStream("person.xml", FileMode.Create))
		{
			xmlser.Serialize(serialStream, st1);
		}
		using (Stream serialStream = new FileStream("person.xml", FileMode.Open))
		{
			Person st2 = xmlser.Deserialize(serialStream) as Person;
			Console.WriteLine(st2);
		}
    }
}