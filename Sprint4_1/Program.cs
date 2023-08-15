interface ISwimmable
{
	void Swim()
	{
        Console.WriteLine("I can swim!");
    }
}

interface IFlyable
{
	int MaxHeight { get; }

	void Fly()
	{
        Console.WriteLine("I can fly at {0} meters height!", MaxHeight);
    }
}

interface IRunnable
{
	int MaxSpeed { get; }

	void Run()
	{
        Console.WriteLine("I can run up to {0} kilometers per hour!",MaxSpeed);
    }
}

interface IAnimal
{
	int LifeDuration { get; }

	void Voice()
	{
        Console.WriteLine("No voice!");
    }

	void ShowInfo()
	{
        Console.WriteLine("I am a {0} and I live approximately {1} years.",GetType().Name,LifeDuration);
    }
}

class Cat : IAnimal, IRunnable
{
	public int LifeDuration { get; } = 110;
	public int MaxSpeed { get; } = 10000;
	void Voice()
	{
        Console.WriteLine("Meow");
    }
}

class Eagle : IAnimal, IFlyable
{
	public int LifeDuration { get; } = 45;
	public int MaxHeight { get; } = 20;
}

class Shark : IAnimal, ISwimmable
{
	public int LifeDuration { get; } = 430000;
}