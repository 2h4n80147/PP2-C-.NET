using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics2019
{
	class Star
	{
		int x, y;
		public GraphicsPath gp1;
		public GraphicsPath gp2;
		public Star(int x, int y)
		{
			this.x = x;
			this.y = y;
			gp1 = new GraphicsPath();
			gp2 = new GraphicsPath();

		}



		static int calls = 0;
		public void Move()
		{
			x += 10;
			if (x == 780) x = 0;
			calls++;

			if (true)
			{
				gp1.Reset(); gp2.Reset();
			}
			
			Point[] firstT =
		   {
				new Point (x,y),
				new Point (x+20,y+30),
				new Point(x-20,y+30)
			};
			gp1.AddPolygon(firstT);
			Point[] secondT =
		  {
				new Point (x-20,y+10),
				new Point (x+20,y+10),
				new Point(x,y+40)
			};
			gp2.AddPolygon(secondT);
		}
	}
}
