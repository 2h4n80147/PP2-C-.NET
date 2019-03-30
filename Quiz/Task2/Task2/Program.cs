using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Pen
	{
		char sign;
		Thread t;
		public Pen(char s)
		{
			sign = s;
			t = new Thread(printer);
		}
		void printer()
		{
			while (true)
			{
				Console.Write(sign);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
