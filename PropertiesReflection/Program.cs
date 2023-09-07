using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(Person);

        foreach(PropertyInfo prop in type.GetProperties(BindingFlags.Instance|BindingFlags.Public|BindingFlags.Static))
        {
            Console.WriteLine($"{prop.PropertyType} {prop.Name}");
            if (prop.CanRead)
            {
                Console.WriteLine("get;");
            }
            if(prop.CanWrite)
            {
                Console.WriteLine("set;");
            }
        }
    }
}

class Person
{
	public string Name { get; set; }
	public int Age { get; }
    public Person(string name,int age)
    {
        Name = name;
        Age = age;
    }
}