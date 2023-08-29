﻿using System.Threading;
class MyThreads
{
	public static readonly object Den = new object();
	public static readonly object Ada = new object();

	public static int n;
	public static int m;

	public static Thread Thread1 = new Thread(
		() =>
		{
			lock (Den)
			{
				for (int i = 0; i < 5; i++, n++)
				{
					Console.WriteLine("Thread1 n = " + n);
					
				}
			}
			lock (Ada)
			{
				for (int i = 0; i < 5; i++, m++)
					Console.WriteLine("Thread1 m = " + m);
				Console.WriteLine("Thread1 success!");
			}
		}
	);

	public static Thread Thread2 = new Thread(
		() =>
		{
			lock (Ada)
			{
				{
					for (int i = 0; i < 5; i++, m++)
						Console.WriteLine("Thread2 m = " + m);
				}
				
			}
			lock (Den)
			{
				for (int i = 0; i < 5; i++, n++)
					Console.WriteLine("Thread2 n = " + n);
				Console.WriteLine("Thread2 success!");
			}
		}
	);
}

class Program
{
	static void Main()
	{
		MyThreads.Thread1.Start();
		MyThreads.Thread2.Start();
	}
}