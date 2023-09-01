class Program
{
	static async Task Main()
	{
		Person person = await GetPersonAsync("Tom");
        Console.WriteLine(person.name);

    }
	static async Task<Person> GetPersonAsync(string name)
	{
		await Task.Delay(1000);
		return new Person(name);
	}
}
public record class Person(string name);
