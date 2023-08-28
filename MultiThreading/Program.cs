//ExecutionContext: позволяет получить контекст, в котором выполняется поток

//IsAlive: указывает, работает ли поток в текущий момент

//IsBackground: указывает, является ли поток фоновым

//Name: содержит имя потока

//ManagedThreadId: возвращает числовой идентификатор текущего потока

//Priority: хранит приоритет потока - значение перечисления ThreadPriority:

//Lowest

//BelowNormal

//Normal

//AboveNormal

//HighestExecutionContext: позволяет получить контекст, в котором выполняется поток

//IsAlive: указывает, работает ли поток в текущий момент

//IsBackground: указывает, является ли поток фоновым

//Name: содержит имя потока

//ManagedThreadId: возвращает числовой идентификатор текущего потока

//Priority: хранит приоритет потока - значение перечисления ThreadPriority:

//Lowest

//BelowNormal

//Normal

//AboveNormal

//Highest

//ThreadState возвращает состояние потока - одно из значений перечисления ThreadState:

//Aborted: поток остановлен, но пока еще окончательно не завершен

//AbortRequested: для потока вызван метод Abort, но остановка потока еще не произошла

//Background: поток выполняется в фоновом режиме

//Running: поток запущен и работает (не приостановлен)

//Stopped: поток завершен

//StopRequested: поток получил запрос на остановку

//Suspended: поток приостановлен

//SuspendRequested: поток получил запрос на приостановку

//Unstarted: поток еще не был запущен

//WaitSleepJoin: поток заблокирован в результате действия методов Sleep или Join

using System.Threading;
using System.Threading.Channels;
class Program
{

	static void Main(string[] args)
	{
		int num = 4;

		Thread th1 = new Thread(Print);
		th1.Start(num);

		string word = "hello";
		Thread th2 = new Thread(Print);
		th2.Start(word);
	
	}

	static void Print(object? obj)
	{
		if (obj is int n)
		{
			Thread.Sleep(1000);
            Console.WriteLine($"n*n={n*n}");
        }

		if (obj is string s)
		{
            Console.WriteLine(s);
        }
	}
}