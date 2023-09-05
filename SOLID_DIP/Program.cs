//class Book
//{
//	public string Text { get; set; }
//	public ConsolePrinter Printer { get; set; }

//	public void Print()
//	{
//		Printer.Print(Text);
//	}
//}

//class ConsolePrinter
//{
//	public void Print(string text)
//	{
//		Console.WriteLine(text);
//	}
//}


interface IPrinter
{
	void Print(string text);
}
class Book
{
	public string Text { get; set; }
	public IPrinter Printer { get; set; }
	public Book(IPrinter printer)
	{
		this.Printer = printer;
	}
	public void Print()
	{
		Printer.Print(Text);
	}
}

class ConsolePrinter : IPrinter
{
	public void Print(string text)
	{
        Console.WriteLine("Print into console...");
    }
}

class HtmlPrinter : IPrinter
{
	public void Print(string text)
	{
        Console.WriteLine("Print into HTML");
    }
}

class Program
{
	static void Main(string[] args)
	{
		Book book = new Book(new ConsolePrinter());
		book.Print();
		book.Printer = new HtmlPrinter();
		book.Print();
	}
}