using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
	class DudeThread{
		Thread threadField;
		public DudeThread(string name)
		{
			threadField = new Thread(Print);
			threadField.Name = name;
		}
		public void Print()
		{
			for (int i = 1; i <= 4 ; i++)
			{
				Console.WriteLine(Thread.CurrentThread.Name + " выводить " + i.ToString());
				//Thread.Sleep(0);
			}
		}
		public void StartThread()
		{
			threadField.Start();
		}
	};
	class Program
	{

		static void Main(string[] args)
		{
			DudeThread t1 = new DudeThread("Thread 1");
			DudeThread t2 = new DudeThread("Thread 2");
			DudeThread t3 = new DudeThread("Thread 3"); 

			t1.StartThread();
			t2.StartThread();
			t3.StartThread();

			//Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " ends here");

			Console.ReadKey();
		}
	}
}
