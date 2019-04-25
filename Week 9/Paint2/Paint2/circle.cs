using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics2019
{
	class Circle
	{
		int x, y;
		public GraphicsPath gp1;
		public GraphicsPath gp2;
		public Circle(int x, int y)
		{
			this.x = x;
			this.y = y;
			gp1 = new GraphicsPath();
			gp2 = new GraphicsPath();

		}
		static int calls = 0;
		public void Move()
		{
			y += 10;
			if (y == 300) y = 0;
			calls++;
			
			gp1.Reset();
			gp1.AddEllipse(x - 10, y - 10, 20, 20);
			
		}
	}
}
