abstract class Car
{
	internal string mark;
	internal int prodYear;

    public Car(string mark, int prodYear)
    {
        this.mark = mark;
		this.prodYear = prodYear;
    }
    
    public void ShowInfo()
    {
		Console.WriteLine("Mark:{0}, Producted in:{1}", mark, prodYear);
	}

}

class SportCar : Car
{
	private int maxSpeed;

    public SportCar(string mark, int prodYear, int maxSpeed) : base(mark, prodYear)
    {
        this.maxSpeed = maxSpeed;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Maximum speed is {0}",maxSpeed);
    }
}

class Lory : Car
{
	private double loadCapacity;

    public Lory(string mark, int prodYear, double loadCapacity) : base(mark, prodYear)
    {
        this.loadCapacity = loadCapacity;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("The load capacity is {0}",loadCapacity);
    }
}