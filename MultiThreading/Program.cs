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
		Thread thread1 = new Thread(Print);
		Thread thread2 = new Thread(new ThreadStart(Print));
		Thread thread3 = new Thread(() => Console.WriteLine("Hello Thread"));
		Thread thread = new Thread(Print);

		thread.Start();
		for (int i = 0; i < 5; i++)
		{
            Console.WriteLine("Main thread:{0}",i);
			Thread.Sleep(300);
        }

		void Print()
		{
			for (int i = 0; i < 5; i++)
			{
                Console.WriteLine("Second thread:{0}",i);
				Thread.Sleep(500);
            }
		}

		
	}
}