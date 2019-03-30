using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void showButton_Click(object sender, EventArgs e)
		{

		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			pictureBox.Image = null;
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void backgroundButton_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox.BackColor = colorDialog1.Color;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
				pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			else
				pictureBox.SizeMode = PictureBoxSizeMode.Normal;
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void showButton_Click_1(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox.Load(openFileDialog1.FileName);
			}
		}
	}
}
