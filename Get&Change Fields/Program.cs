using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(Person);

        Person tom = new Person("Tom", 45);

        var name = type.GetField("name",BindingFlags.Instance | BindingFlags.Public);
        
        var value = name?.GetValue(tom);
        Console.WriteLine(value);

        name?.SetValue(tom, "Bob");
        tom.Print();

        var age = type.GetField("age", BindingFlags.Instance | BindingFlags.Public);

        var valueAge  = age?.GetValue(tom);
        Console.WriteLine(valueAge);

        age?.SetValue(tom, 10);
        tom.Print();
    }
}

class Person
{
    static int minAge = 1;
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print() => Console.WriteLine($"{name} - {age}");
}