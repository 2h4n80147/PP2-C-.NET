﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int timer = 0;
		private void label1_Click(object sender, EventArgs e)
		{
			timer++;
			if (timer % 2 == 1)
				BackColor = Color.DarkBlue;
			else
				BackColor = Color.NavajoWhite;

		}
	}
}