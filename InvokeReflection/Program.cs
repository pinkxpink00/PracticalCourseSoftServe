using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var myPrinter = new Printer("Hello");

        var print = typeof(Printer).GetMethod("Print");

        print?.Invoke(myPrinter,parameters: null);
    }
}

class Printer
{
	public string Text { get; }
    public Printer(string text)
    {
        this.Text = text;
    }
    public void Print() => Console.WriteLine(Text);
}