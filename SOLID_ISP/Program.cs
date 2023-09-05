interface IMessage
{
	void Send();
	string ToAddress { get; set; }
	string FromAddress { get; set; }
}
interface IVoiceMessage : IMessage
{
	byte[] Voice { get; set; }
}
interface ITextMessage : IMessage
{
	string Text { get; set; }
}

interface IEmailMessage : ITextMessage
{
	string Subject { get; set; }
}

class VoiceMessage : IVoiceMessage
{
	public string ToAddress { get; set; } = "";
	public string FromAddress { get; set; } = "";

	public byte[] Voice { get; set; } = Array.Empty<byte>();
	public void Send() => Console.WriteLine("Передача голосовой почты");
}
class EmailMessage : IEmailMessage
{
	public string Text { get; set; } = "";
	public string Subject { get; set; } = "";
	public string FromAddress { get; set; } = "";
	public string ToAddress { get; set; } = "";

	public void Send() => Console.WriteLine($"Отправляем по Email сообщение: {Text}");
}

class SmsMessage : ITextMessage
{
	public string Text { get; set; } = "";
	public string FromAddress { get; set; } = "";
	public string ToAddress { get; set; } = "";
	public void Send() => Console.WriteLine($"Отправляем по Sms сообщение: {Text}");
}





// Плохой пример

public interface IWorker
{
	void Work();
	void Eat();
}

public class Robot : IWorker
{
	public void Work()
	{
		// Работа робота
	}

	public void Eat()
	{
		// Робот не ест, но он должен реализовать этот метод из-за интерфейса
	}
}

// Хороший пример

public interface IWorker
{
	void Work();
}

public interface IEater
{
	void Eat();
}

public class Robot : IWorker
{
	public void Work()
	{
		// Работа робота
	}
}