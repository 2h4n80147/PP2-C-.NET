using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
	class Program
	{
		class globals {
			static public TimeSpan timer;
		}

		static void Main(string[] args)
		{
			Thread x = new Thread(addList);
			x.Start();
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			//stopWatch.Stop();
			while (true) 
			{
				Thread.Sleep(100);
				TimeSpan ts = stopWatch.Elapsed;
				globals.timer = ts;
				
				// Format and display the TimeSpan value.
				string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
					ts.Hours, ts.Minutes, ts.Seconds,
					ts.Milliseconds / 10);

				string s = "RunTime ";
				Console.SetCursorPosition(20, 0);
				Console.WriteLine("RunTime " + elapsedTime);
			}
		}
		static void addList()
		{
			int cursor = 2;
			while (true)
			{
				Console.SetCursorPosition(20, 20);
				ConsoleKeyInfo k = Console.ReadKey();
				if (k.Key == ConsoleKey.Enter)
				{
					
					Console.SetCursorPosition(0, cursor++);
					TimeSpan ts = globals.timer;
					string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
					ts.Hours, ts.Minutes, ts.Seconds,
					ts.Milliseconds / 10);
					Console.WriteLine(elapsedTime);
					Thread.Sleep(10);
				}
				Thread.Sleep(10);
			}
		}
	}
}
