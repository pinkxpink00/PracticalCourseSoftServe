using System.Reflection;
class ReflectFields
{
	public static string Name;
	public static int MeasureX;
	public static int MeasureY;
	public static int MeasureZ;

	public static void OutputFields()
	{
		Type type = typeof(ReflectFields);
		FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

		foreach (FieldInfo field in fields)
		{
			object? value = field.GetValue(null);
			string fieldType = field.FieldType.Name;
			fieldType = fieldType.Replace("String", "string");
			fieldType = fieldType.Replace("Int32", "int");

			Console.WriteLine("{0} ({1}) = {2}", field.Name, fieldType, value);
		}
	}
}