using System.Net.Security;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type myType = typeof(Printer);

        Console.WriteLine("Methods...");

        foreach(MethodInfo methodInfo in myType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            string modificator = "";

            if (methodInfo.IsStatic) modificator += "static";
            if (methodInfo.IsVirtual) modificator += "virtual";

            Console.WriteLine($"{modificator} {methodInfo.ReturnType.Name} {methodInfo.Name} ()");
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
    public string CreateMessage() => DefaultMessage;
}