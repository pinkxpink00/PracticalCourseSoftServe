using System.Threading.Channels;

interface IMovable
{
	void Move();
}

class Program
{
	static void Action(IMovable movable)
	{
		movable.Move();
	}
	static void Main(string[] args)
	{
		Person person = new Person();
		Car car = new Car();

		Action(car);
		Action(person);
		Console.Read();
	}
}

class Person : IMovable
{
	public void Move()
	{
        Console.WriteLine("Walking");
	}
}

struct Car : IMovable
{
	public void Move()
	{
        Console.WriteLine("Driving");
    }
}