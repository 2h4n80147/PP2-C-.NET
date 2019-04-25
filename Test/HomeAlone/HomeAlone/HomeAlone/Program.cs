using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeAlone
{
	class Program
	{
		public static void print(int n)
		{
			string s = "*******";
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(s);
			}
		}

		public static void homePrint(int n)
		{
			string[] s =
			{
				"***#***",
				"**#*#**",
				"*#***#*",
				"#*****#",
				"#*****#",
				"#######",
			};
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(s[i]);
			}
		}
		public static void home()
		{
			int cnt = 0;
			while (true)
			{
				Console.Clear();



				homePrint(cnt);
				print(6 - cnt);
				cnt++;
				cnt %= 7;
				Thread.Sleep(1000);

			}
		}
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Thread thread = new Thread(home);
			thread.Start();

		}
	}
}