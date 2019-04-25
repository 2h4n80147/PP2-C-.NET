using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Person
	{
		int x, y;
		int dx;
		public GraphicsPath gp1;
		public GraphicsPath gp2;
		public GraphicsPath gp3;
		public GraphicsPath gp4;
		public GraphicsPath gp5;
		public GraphicsPath gp6;
		public Person(int x, int y, int dx)
		{
			this.x = x;
			this.y = y;
			gp1 = new GraphicsPath();
			gp2 = new GraphicsPath();
			gp3 = new GraphicsPath();
			gp4 = new GraphicsPath();

			gp5 = new GraphicsPath();
			gp6 = new GraphicsPath();
			this.dx = dx;
		}
		public void Move()
		{
			x += dx;
			if (x == 780) x = 0;
			gp1.Reset();
			gp2.Reset();
			gp3.Reset();

			gp4.Reset();
			gp5.Reset();
			gp6.Reset();
			
			gp1.AddEllipse(x, y, 20, 20);
			gp2.AddLine(x + 10, y + 21, x + 10, y + 41);
			gp3.AddLine(x, y + 30, x + 10, y + 21);
			gp4.AddLine(x + 10, y + 21, x + 20, y + 21);
			gp5.AddLine(x, y + 30 + 40, x + 10, y + 21 + 40);
			gp6.AddLine(x + 10, y + 21 + 40, x + 20, y + 21 + 40);
		}
	}
}