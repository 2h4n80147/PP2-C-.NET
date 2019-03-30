using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch s = new StopWatch();
			s.Start();
			while (true)
			{
				TimeSpan ts = s.Elapsed;
				string elapsedTime = String.Format("{0:00}:{1:00}",
					ts.Hours, ts.Minutes);
				
				Console.SetCursorPosition(0, 0);
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write(elapsedTime);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(": " + ts.Seconds);
				Thread.Sleep(1000);
			}
		}
	}
}
