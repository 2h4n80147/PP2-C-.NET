using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2__
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();


			progressBar1.Maximum = 100;
			progressBar1.Step = 1;
			progressBar1.Value = 0;
			timer1.Start();
		}
		private void progressBar1_Click(object sender, EventArgs e)
		{
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Refresh();
			progressBar1.PerformStep();
			
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			double angle = (double)progressBar1.Value / 100 * 360;
			SolidBrush green = new SolidBrush(Color.LawnGreen);
			e.Graphics.FillPie(green, new Rectangle(50, 50, 200, 200), 0, (float)angle);
		}
	}
}
