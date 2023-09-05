public class Customer
{
	public static void Register(string email, string password)
	{
		MailService ms = new MailService();
			if (ms.ValidEmail())
			{
			  ms.SendEmail(email, "Email title", "Email body");
			}
	}
}
public abstract class NotificationService
{
	public abstract void SendNotification();
}

public class MailService : NotificationService
{
	public string Email { get; set; }
	public string EmailTitle { get; set; }
	public string EmailBody { get; set; }
	public void SendEmail(string mail, string emailTitle, string emailBody)
	{
		if (ValidEmail())
		{
			Console.WriteLine($"Mail:{mail}, Title:{emailTitle}, Body:{emailBody}");
		}
	}
	public bool ValidEmail()
	{
		return Email.Contains("@");
	}

	public override void SendNotification()
	{
			Console.WriteLine($"Mail:{Email}, Title:{EmailTitle}, Body:{EmailBody}");
	}
}

public class SmsService : NotificationService
{
	public string Number { get; set; }
	public string SmsText { get; set; }

	public override void SendNotification()
	{
        Console.WriteLine("Number:{0}, Message:{1}", Number, SmsText);
    }
}

class Program
{
	static void Main(string[] args)
	{
		Customer.Register("myemail@ukr.ua", "12345");
	}
}