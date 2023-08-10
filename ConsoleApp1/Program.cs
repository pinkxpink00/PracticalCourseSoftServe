class Bird
{
	public void Voice()
	{
        Console.WriteLine("1");
    }
}

class Eagle : Bird
{
	public void Voice()
	{
		base.Voice();
        Console.WriteLine("2");
    }
	
}

class Program
{
	static void Main(string[] args)
	{
		Eagle eagle = new Eagle();
		eagle.Voice();
	}
}