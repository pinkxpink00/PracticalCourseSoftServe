using System.Net.Security;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type myType = typeof(Printer);

        Console.WriteLine("Methods...");

        foreach(MethodInfo method in myType.GetMethods())
        {
            Console.WriteLine($"{method.ReturnType.Name} {method.Name}(");

            ParameterInfo[] parameters = method.GetParameters();

            for (int i = 0; i < parameters.Length;i++)
            {
                var param = parameters[i];

                string modificator = "";

                if (param.IsIn) modificator = "in";
                else if (param.IsOut) modificator = "out";


                Console.WriteLine($"{param.ParameterType.Name} {modificator} {param.Name}");

                if (param.HasDefaultValue)
                {
                    Console.WriteLine($"={param.HasDefaultValue}");
                }
                if (i < parameters.Length - 1)
                {
                    Console.WriteLine(",");
                }

            }
            Console.WriteLine(")");
        }
    }
}

class Printer
{
    string DefaultMessage { get; set; } = "Hello";

    public void PrintMessage(string message, int times = 1)
    {
        while (times-- > 0)
        {
            Console.WriteLine(message);
        }
    }
    public string CreateMessage(out string message) => message = "Hello World";
}