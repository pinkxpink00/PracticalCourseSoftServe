using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Type myType = typeof(PeopleTypes.Person);
        Console.WriteLine($"Full Name:{myType.FullName}");
        Console.WriteLine($"Name:{myType.Name}");
        Console.WriteLine($"Namespace:{myType.Namespace}");
        Console.WriteLine($"IsStruct:{myType.IsValueType}");
        Console.WriteLine($"IsClass:{myType.IsClass}");

    }
}
namespace PeopleTypes
{
    class Person
    {
        string Name { get; }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}