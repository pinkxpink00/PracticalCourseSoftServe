interface IFlyable
{
	void Fly();
}

interface IEating
{
	void Eat();
}

interface IMoving
{
	void Move();
}

interface IBasking
{
	void Bask();
}

interface IKryaking
{
	void Krya();
}


class Bird : IFlyable, IEating, IMoving, IBasking, IKryaking
{
	public void Fly()
	{
		Console.WriteLine("I believe, I can fly");
	}

	public void Eat()
	{
		Console.WriteLine("Oh! My corn!");
	}

	public void Move()
	{
		Console.WriteLine("I can jump!");
	}

	public void Bask()
	{
		Console.WriteLine("Bird likes to bask in the sun.");
	}

	public void Krya()
	{
		Console.WriteLine("Bird makes a Krya sound.");
	}
}

class Cat : IEating, IMoving, IBasking, IKryaking
{
	public void Eat()
	{
		Console.WriteLine("Oh! My milk!");
	}

	public void Move()
	{
		Console.WriteLine("I can jump!");
	}

	public void Bask()
	{
		Console.WriteLine("Mrrr-Mrrr-Mrrr...");
	}

	public void Krya()
	{
		Console.WriteLine("Cat makes a Krya sound.");
	}
}

class Parrot : Bird
{
	public static void Fly()
	{
		Console.WriteLine("I believe, I can fly");
	}

	public static void Eat()
	{
		Console.WriteLine("Oh! My seeds and fruits!");
	}

	public static void Move()
	{
		Console.WriteLine("I can jump!");
	}

	public static void Bask()
	{
		Console.WriteLine("Chuh-Chuh-Chuh...");
	}

	public  static void Krya()
	{
		Console.WriteLine("Krya-Krya-Krya...");
	}
}

class Duck : IFlyable, IEating, IMoving, IBasking, IKryaking
{
	public void Fly()
	{
		Console.WriteLine("I believe, I can fly");
	}

	public void Eat()
	{
		Console.WriteLine("Oh! My corn!");
	}

	public void Move()
	{
		Console.WriteLine("I can swimm!");
	}

	public void Bask()
	{
		Console.WriteLine("Duck likes to bask in the water.");
	}

	public void Krya()
	{
		Console.WriteLine("Krya-Krya!");
	}
}