using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
	class Point
	{
		public int x, y;
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int length = int.Parse(Console.ReadLine());
			int width = int.Parse(Console.ReadLine());

			List<Point> L = new List<Point>();
			for (int i = 0; i < width; i++)
				L.Add(new Point(0, i));
			for (int i = 0; i < length; i++)
				L.Add(new Point(i, width - 1));
			for (int i = width-1; i >= 0; i--)
				L.Add(new Point(length-1, i));
			for (int i = length - 1; i >= 0 ; i--)
				L.Add(new Point(i, 0));

			int cur = 0;
			Console.ForegroundColor = ConsoleColor.Yellow;
			while (true)
			{
				
				Console.SetCursorPosition(L[cur].y, L[cur].x);
				Console.Clear();
				cur = (cur + 1) % L.Count;
				Console.SetCursorPosition(L[cur].y, L[cur].x);
				Console.Write('@');
				Thread.Sleep(50);
			}
		}
	}
}
