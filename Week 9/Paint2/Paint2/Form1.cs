using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics2019
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int D = 0;
		Star s1 = new Star(120, 200);
		Star s2 = new Star(400, 300);
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Width = 800;
			this.Height = 600;
			timer3.Start();
		}

		static public SolidBrush blue = new SolidBrush(Color.Blue);

		static List<Circle> c = new List<Circle>();
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			this.BackColor = Color.White;
			textBox1.Text = c.Count.ToString();
			for (int i = 0; i < c.Count; i++)
				e.Graphics.FillPath(blue, c[i].gp1);
			return;


			SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
			Pen pen = new Pen(Color.Tomato, 3);

			//e.Graphics.FillEllipse(solidBrush, new Rectangle(40 - D, 40 - D, 50 + 2*D, 50 + 2*D));
			//return;
			//e.Graphics.DrawEllipse(pen, 10, 10, 10, 100);
			//return;

			
			this.BackColor = Color.Black;
			e.Graphics.FillRectangle(blue, 10, 10, 760, 520);
			SolidBrush white = new SolidBrush(Color.White);
			e.Graphics.FillEllipse(white, 100, 100, 40, 40);
			

			int y = 200, x = 300;
			Point[] spaceship =
			{
				new Point(x,y),
				new Point(x + 80, y + 40),
				new Point(x + 80, y),
				new Point(x, y + 40)
				/*
				new Point(x+40,y+20),
				new Point(x+40,y+50),
				new Point(x,y+70),
				new Point(x-40,y+50),
				 new Point(x-40,y+20)
				*/
			};
			SolidBrush yellow = new SolidBrush(Color.Yellow);
			e.Graphics.FillPolygon(yellow, spaceship);
			SolidBrush red = new SolidBrush(Color.Red);

			SolidBrush green = new SolidBrush(Color.Green);

			e.Graphics.FillPath(green, s1.gp1);
			e.Graphics.FillPath(yellow, s1.gp2);
			e.Graphics.FillPath(red, s2.gp1);
			e.Graphics.FillPath(yellow, s2.gp2);


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
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//s1.Move();
			//s2.Move();=
			for (int i = 0; i < c.Count; i++)
				c[i].Move();
			Refresh();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{

		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			D++;
		}
		Random rnd = new Random();
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			return;
			if (e.Button == MouseButtons.Left)
			{
				timer++;
				//MessageBox.Show(timer.ToString());
			}
		}

		static int timer = 0;
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			return;
			textBox1.Text = timer.ToString();
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{

			c.Add(new Circle(MousePosition.X, MousePosition.Y));
		}
	}
}