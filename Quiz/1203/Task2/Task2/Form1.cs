using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Person s2 = new Person (120, 200, +1);
		Person s1 = new Person(400, 300, -1);
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Width = 800;
			this.Height = 600;

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			this.BackColor = Color.Black;
			SolidBrush blue = new SolidBrush(Color.Blue);
			e.Graphics.FillRectangle(blue, 10, 10, 760, 520);

			SolidBrush white = new SolidBrush(Color.White);
			e.Graphics.FillEllipse(white, 100, 100, 40, 40);
			e.Graphics.FillEllipse(blue, 120, 100, 20, 20);

			SolidBrush green = new SolidBrush(Color.Green);

			e.Graphics.FillRectangle(green, 0, 400, 800, 600);
			
			int y = 200, x = 300;
			Point[] spaceship =
			{
				new Point(x,y),
				new Point(x+40,y+20),
				new Point(x+40,y+50),
				new Point(x,y+70),
				new Point(x-40,y+50),
				 new Point(x-40,y+20)
			};
			SolidBrush yellow = new SolidBrush(Color.Yellow);
			e.Graphics.FillPolygon(yellow, spaceship);
			SolidBrush red = new SolidBrush(Color.Red);
			Pen black = new Pen(Color.Green, 4);
			
			e.Graphics.FillPath(red, s1.gp1);
			e.Graphics.DrawPath(black, s1.gp2);
			e.Graphics.DrawPath(black, s1.gp3);
			e.Graphics.DrawPath(black, s1.gp4);
			e.Graphics.DrawPath(black, s1.gp5);
			e.Graphics.DrawPath(black, s1.gp6);


			e.Graphics.FillPath(red, s2.gp1);
			e.Graphics.DrawPath(black, s2.gp2);
			e.Graphics.DrawPath(black, s2.gp3);
			e.Graphics.DrawPath(black, s2.gp4);
			e.Graphics.DrawPath(black, s2.gp5);
			e.Graphics.DrawPath(black, s2.gp6);


			x = 360;
			y = 180;
			Point[] newstar =
			{
					new Point(x,y),
					new Point(x+5,y+25),
					new Point(x+20,y+30),
					new Point(x+5,y+35),
					new Point(x,y+60),

					new Point(x-5,y+35),
					new Point(x-20,y+30),
					new Point(x-5,y+25),

			};
			e.Graphics.FillClosedCurve(yellow, newstar);

			x = 100;
			y = 150;
			Point[] newstar2 =
			{
					new Point(x,y),
					new Point(x+5,y+25),
					new Point(x+20,y+30),
					new Point(x+5,y+35),
					new Point(x,y+60),

					new Point(x-5,y+35),
					new Point(x-20,y+30),
					new Point(x-5,y+25),

			};
			e.Graphics.FillClosedCurve(yellow, newstar2);
			x = 20;
			y = 30;
			Point[] newstar3 =
			{
					new Point(x,y),
					new Point(x+5,y+25),
					new Point(x+20,y+30),
					new Point(x+5,y+35),
					new Point(x,y+60),

					new Point(x-5,y+35),
					new Point(x-20,y+30),
					new Point(x-5,y+25),

			};
			e.Graphics.FillClosedCurve(yellow, newstar3);


		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			s1.Move();
			s2.Move();
			Refresh();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{

		}
	}
}
