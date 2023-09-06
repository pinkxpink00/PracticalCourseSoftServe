using System.Threading.Channels;
using System.Reflection;
class Program
{
    public static void Main(string[] args)
    {
        Type myType = typeof(Person);

        foreach (MemberInfo memberInfo in myType.GetMembers())
        {
            Console.WriteLine($"{memberInfo.DeclaringType} {memberInfo.MemberType} {memberInfo.Name}");
        }
    }
}

class Person
{
	public string Name { get;}
	public int Age { get; set; }

    public Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public void Print() => Console.WriteLine($"Name:{Name},Age:{Age}");
}