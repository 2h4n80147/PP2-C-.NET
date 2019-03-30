using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
	class Program
	{
		public class Point
		{
			public int X, Y;
			Point() { }
		}
		public class Snake
		{
			public ConsoleColor bodyColor;
			public List<Point> body;
			public Snake() { }
			public void show()
			{
				for (int i = 0; i < body.Count; i++)
					Console.WriteLine(body[i].X + " " + body[i].Y)
			}
		}
		static void Main(string[] args)
		{
			XmlSerializer X = new XmlSerializer(typeof(Snake));
			FileStream file = new FileStream(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Quiz\2022\task1\info.xml", FileMode.Open, FileAccess.Read);
			Snake a = X.Deserialize(file) as Snake;
			a.show();
		}
	}
}
