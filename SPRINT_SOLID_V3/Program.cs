using System.Reflection;

public class ReflectProperties
{
	public class TestProperties
	{
		public string FirstName { get; set; }
		internal string LastName { get; set; }
		protected int Age { get; set; }
		private string PhoneNumber { get; set; }
	}

	public static void WriteProperties()
	{
		Type type = typeof(TestProperties);
		PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

		foreach (PropertyInfo property in properties)
		{
			string name = property.Name;
			Type propertyType = property.PropertyType;
			bool canRead = property.CanRead;
			bool canWrite = property.CanWrite;
			string accessibility = GetAccessibility(property);


			Console.WriteLine($"Property name: {name}");
			Console.WriteLine($"Property type: {propertyType.FullName}");
			Console.WriteLine($"Read-Write:{canRead}");
			Console.WriteLine($"Accessibility: {accessibility}");
			Console.WriteLine();
		}
	}

	private static string GetAccessibility(PropertyInfo property)
	{
		if (property.GetGetMethod(true) != null && property.GetGetMethod(true).IsPublic)
		{
			return "Public";
		}
		else if (property.GetGetMethod(true) != null && property.GetGetMethod(true).IsFamily)
		{
			return "Protected";
		}
		else if (property.GetGetMethod(true) != null && property.GetGetMethod(true).IsAssembly)
		{
			return "Internal";
		}
		else
		{
			return "Private";
		}
	}
}