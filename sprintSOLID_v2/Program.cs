﻿using System.ComponentModel;
interface INotification
{
	void SendNotification();
}
interface INotificationToDB
{
	void AddNotificationToDB();
}

public class Customer
{
	public static void Register(string email, string password)
	{
		MailService ms = new MailService
		{
			Email = email,
			EmailTitle = "Email title",
			EmailBody = "Email body"
		};

		if (ms.ValidEmail())
		{
			ms.SendEmail(email, "User registration", "Body of message...");
		}
		var smsService = new SmsService();
		smsService.Number = "111 111 111";
		smsService.SmsText = "User successfully registered...";
		smsService.SendNotification();
		//smsService.AddNotificationToDB();
	}
}
public abstract class NotificationService
{
	public abstract void SendNotification();
	public abstract void AddNotificationToDB();

}

public class MailService : NotificationService,INotification,INotificationToDB
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
	public override void AddNotificationToDB()
	{
		
	}
}

public class SmsService : NotificationService,INotification
{
	public string Number { get; set; }
	public string SmsText { get; set; }

	public override void SendNotification()
	{
		Console.WriteLine("Number:{0}, Message:{1}", Number, SmsText);
	}
	public override void AddNotificationToDB()
	{
		throw new Exception("Not allowed");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Customer cust = new Customer();
		cust.Register("SomeEmail@mail.ua", "1231");
	}
}