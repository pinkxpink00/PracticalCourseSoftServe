using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Type myType = typeof(PeopleTypes.Person);

        Console.WriteLine("Realized Interface");
        foreach (Type t in myType.GetInterfaces())
        {
            Console.WriteLine(t.Name);
        }

    }
}
namespace PeopleTypes
{
    interface IEat
    {
        void Eat();
    }
    interface IMove
    {
        void Move();
    }

    class Person : IEat, IMove
    {
        string Name { get; }

        public Person(string name)
        {
            this.Name = name;
        }

        public void Eat()
        {
            Console.WriteLine("I Eat");
        }

        public void Move()
        {
            Console.WriteLine("I Move");
        }
    }
}