using System.Net.Mail;
interface ISender
{
	void SendEmail(string text);
}

interface IFileLogger
{
	public void Check();

	public void Debug();

	public void Info();
	
	
}

public class FileLogger
{
	public void Check()
	{

	}
	public void Debug()
	{

	}
	public void Info()
	{

	}
}

public class MainSender : ISender
{
	public void SendEmail(string mailMessage)
	{
		Console.WriteLine("Sending Email: {0}", mailMessage);
	}
}

public class Invoice
{
	public string From { get; set; }
	public string To { get; set; }
	public long Amount { get; set; }
	public DateTime InvoiceDate { get; set; }

	public void Add()
	{
		MainSender mS = new MainSender();
		Console.WriteLine("Adding amount...");
		string mailMessage = "Your invoice is ready.";
		mS.SendEmail(mailMessage);

	}

	public void Delete()
	{
		Console.WriteLine("Deleting amount...");

	}
}


