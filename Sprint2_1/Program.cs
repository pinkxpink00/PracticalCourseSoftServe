class Employee
{
	internal string name;
	private DateTime hiringDate;

    public Employee(string name, DateTime hiringDate)
    {
        this.name = name;
		this.hiringDate = hiringDate;
    }

	public int Experience()
	{
		DateTime currentDate = DateTime.Now;
		int yearOfExperience = currentDate.Year-hiringDate.Year;

		 if (currentDate < hiringDate.AddYears(yearOfExperience))
		{
			yearOfExperience--;
		}
		 return yearOfExperience;
	}

	public void ShowInfo()
	{
        Console.WriteLine("{0} has {1} year of experince",name,Experience());
    }
}

class Developer : Employee
{
	private string programmingLanguage;

    public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name,hiringDate)
    {
        this.programmingLanguage = programmingLanguage;
    }

	public new void ShowInfo()
	{
		base.ShowInfo();
        Console.WriteLine("{0} is {1} programmer", name,programmingLanguage);
    }
}

class Tester : Employee
{
	private bool isAuthomation;

    public Tester(string name, DateTime hiringDate, bool isAutomation) : base(name,hiringDate)
    {
        this.isAuthomation = isAutomation;
    }

	public new void ShowInfo()
	{
		base .ShowInfo();
		if (isAuthomation == true)
		{
			Console.WriteLine("{0} is authomated tester and has {1} year(s) of experience",name,Experience());
        }
		else
		{
			Console.WriteLine("{0} is manual tester and has {1} year(s) of experience");
		}
	}
}