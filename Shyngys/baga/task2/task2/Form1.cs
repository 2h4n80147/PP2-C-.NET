using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int[] selected;
		Button[] B;
		Color[] C = new Color[10];
		Color[] Colors = { Color.White, Color.Green, Color.Gray, Color.Red, Color.Pink };

		private void Form1_Load(object sender, EventArgs e)
		{
			Graphics g = this.CreateGraphics();

			B = new Button[]{ button1, button2, button3, button4,
				button5, button6, button7, button8, button9, button10 };
			selected = new int[B.Length];
			
			for (int i = 0; i < B.Length; i++) {
				selected[i] = 0;
				if (i % 2 == 0)
					C[i] = Colors[i / 2];
				else
				{
					C[i] = C[i - 1];
				}
			}

			//Refresh();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Button b = sender as Button;
			int id = 0;
			for (int i = 0; i < B.Length; i++)
				if (B[i].Name == b.Name)
				{
					id = i;
					break;
				}
			selected[id] ^= 1;
			for (int i = 0; i < B.Length; i+= 2)
			{
				if (B[i].Enabled == true && selected[i] == 1 && selected[i + 1] ==1)
				{
					B[i].Enabled = B[i + 1].Enabled = false;
					selected[i] = selected[i + 1] = 0;
				}
			}
			B[id].Refresh();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Paint(object sender, PaintEventArgs e)
		{
			
			Button button = sender as Button;
			int j = 0;
			for (int i = 0; i < B.Length; i++)
				if (B[i].Name == button.Name)
					j = i;

			MessageBox.Show(j.ToString());
				System.Drawing.Rectangle newRectangle = button.ClientRectangle;
				
				newRectangle.Inflate(-10, -10);
				e.Graphics.FillEllipse(new SolidBrush(C[j]), newRectangle);
				if (selected[j] == 1)
				{
					e.Graphics.DrawEllipse(new Pen(C[j], 2), newRectangle);
				}
				GraphicsPath buttonPath = new GraphicsPath();
				buttonPath.AddEllipse(newRectangle);
				
				button.Region = new System.Drawing.Region(buttonPath);
		}
	}
}
