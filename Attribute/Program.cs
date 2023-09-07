class Program
{
    static void Main(string[] args)
    {
		Person tom = new Person("Tom", 35);
		Person bob = new Person("Bob", 16);
		bool tomIsValid = ValidateUser(tom);    // true
		bool bobIsValid = ValidateUser(bob);    // false

		Console.WriteLine($"Результат валидации Тома: {tomIsValid}");
		Console.WriteLine($"Результат валидации Боба: {bobIsValid}");
	}

	static bool ValidateUser(Person person)
	{
        Type type = typeof(Person);
        object[] attributes = type.GetCustomAttributes(false);

        foreach (Attribute attr in attributes)
        {
            if (attr is AgeVallidationAttribute ageAttribute)
            {
                return person.Age >=ageAttribute.Age;
            }
        }

        return true;
	}
}
[AttributeUsage(AttributeTargets.All)]
class AgeVallidationAttribute : Attribute
{
	public int Age { get; }
    public AgeVallidationAttribute(){ }
	public AgeVallidationAttribute(int age) { Age = age; }
}

[AgeVallidation(18)]
class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
    public Person(string name,int age)
    {
        Name = name;
        Age = age;
    }
}