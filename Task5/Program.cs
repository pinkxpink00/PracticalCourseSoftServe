public class Person
{
	protected int yearOfBirth;
	protected string healthInfo;
	protected string name;

    public Person(int yearOfBirth,string healthInfo,string name)
    {
        this.yearOfBirth = yearOfBirth;
		this.healthInfo = healthInfo;
		this.name = name;
    }
    public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
}

public class Child : Person
{
	private string childIDNumber;
	public Child(int yearOfBirth, string name, string healthInfo, string childIDNumber) : base (yearOfBirth,  healthInfo, name)
	{
		this.yearOfBirth = yearOfBirth;
		this.name = name;
		this.healthInfo = healthInfo;
		this.childIDNumber = childIDNumber;
	}


	public override string ToString()
	{
		return $"{name} {healthInfo}";
	}
}

public class Adult : Person
{
	private string passportNumber;


	public Adult(int yearOfBirth, string name, string healthInfo, string passportNumber): base (yearOfBirth, healthInfo, name)
	{
		this.yearOfBirth = yearOfBirth;
		this.name = name;
		this.healthInfo = healthInfo;
		this.passportNumber = passportNumber;
	}

	public override string ToString()
	{
		return $"{name} {passportNumber}";
	}
}
