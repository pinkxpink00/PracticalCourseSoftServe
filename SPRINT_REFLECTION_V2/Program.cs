using System;
using System.Reflection;

namespace ReflectMethodExample
{
	public class ReflectMethod
	{
		public static class Methods
		{
			public static void Hello(string parameter)
			{
				Console.WriteLine($"Hello:parameter={parameter}");
			}

			public static void Welcome(string parameter)
			{
				Console.WriteLine($"Welcome:parameter={parameter}");
			}

			public static void Bye(string parameter)
			{
				Console.WriteLine($"Bye:parameter={parameter}");
			}
		}

		public static void InvokeMethod(string[] parameters)
		{
			foreach (string parameter in parameters)
			{
				MethodInfo[] methodInfos = typeof(Methods).GetMethods(BindingFlags.Public | BindingFlags.Static);

				foreach (MethodInfo methodInfo in methodInfos)
				{
					
				}
			}
		}

		public static void Main()
		{
			string[] parameters = { "Jhon", "Elly" };
			ReflectMethod.InvokeMethod(parameters);
		}
	}
}