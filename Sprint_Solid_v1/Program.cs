public class Customer
{
	public void Register(string email, string password)
	{
		MailService ms = new MailService();
			if (ms.ValidEmail(email))
			{
			  ms.SendEmail(email, "Email title", "Email body");
			}
	}
}

public class MailService
{
	public  void SendEmail(string mail, string emailTitle, string emailBody)
	{
		if (ValidEmail(mail))
		{
			Console.WriteLine($"Mail:{mail}, Title:{emailTitle}, Body:{emailBody}");
		}
	}

	public  bool ValidEmail(string email)
	{
		return email.Contains("@");
	}
}

class Program
{
	static void Main(string[] args)
	{
		MailService ms = new MailService();
		ms.SendEmail("myemail@net.ua", "Say Hello!", "Hello, my dear ..");
	}
}