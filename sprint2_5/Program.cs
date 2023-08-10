class Acinonychini
{
	public string Genus { get; set; }

	public Acinonychini(string genus)
	{
		Genus = genus;
	}

	public virtual void Roar()
	{
		Console.WriteLine("The Acinonychini big cat roars.");
	}
}

sealed class Acinonyx : Acinonychini
{
	public Acinonyx() : base("Acinonyx")
	{
	}

	public override void Roar()
	{
		Console.WriteLine("The Acinonyx (cheetah) roars with a unique chirping sound.");
	}
}

class Puma : Acinonychini
{
	public Puma() : base("Puma")
	{
	}

	public override void Roar()
	{
		Console.WriteLine("The Puma (mountain lion) roars.");
	}
}