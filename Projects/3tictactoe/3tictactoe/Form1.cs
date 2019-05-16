using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3tictactoe
{
    public partial class Form1 : Form
    {
        Button[,] fi = new Button[3, 3];
        bool swt = false;
        bool ngg = false;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            butt();
           
        }
        void butt()
        {
            Button ng = new Button();
            ng.Location = new Point(Width / 2 - 100, Height / 2 - 100);
            ng.Size = new Size(100, 100);
            ng.Text = "New Game";
            ng.Click += swtt;
            Controls.Add(ng);
        }
        void swtt(object sender, EventArgs e)
        {
            Button ngb = sender as Button;
            ngb.Visible = false; 
            ngg = true;
            create_field();
            
        }
        void create_field()
        {
            for(int i = 0;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 100);
                    btn.Location = new Point(10 + j * 102, 10 + i * 102);
                    btn.Text = " ";
                    fi[j, i] = btn;
                    btn.Click += kresnol_Click;
                    Controls.Add(btn);
                }
            }
            
        }
        void kresnol_Click(object sender, EventArgs e)
        {
            count++;
            Button bt = sender as Button;
            if(swt == false)
            {
                if (bt.Text == " ")
                {
                    bt.Text = "X";
                    bt.Font = new Font(FontFamily.GenericSerif, 40);
                    swt = true;
                }
            }
            else
            {
                if (bt.Text == " ")
                {
                    bt.Text = "0";
                    bt.Font = new Font(FontFamily.GenericSerif, 40);
                    swt = false;
                }
            }
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    if(fi[0,0].Text=="X"&&fi[0,1].Text=="X"&&fi[0,2].Text=="X")
                    {
                        MessageBox.Show("X wins");
                        fi[0,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[1, 0].Text == "X" && fi[1, 1].Text == "X" && fi[1, 2].Text == "X")
                    {
                        MessageBox.Show("X wins");
                        fi[1,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[2, 0].Text == "X" && fi[2, 1].Text == "X" && fi[2, 2].Text == "X")
                    {
                        MessageBox.Show("X wins");
                        fi[2,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }

                    else if (fi[0, 0].Text == "X" && fi[1, 0].Text == "X" && fi[2, 0].Text == "X")
                    {
                        MessageBox.Show("X wins");
                        fi[0,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[0, 1].Text == "X" && fi[1, 1].Text == "X" && fi[2, 1].Text == "X")
                    {
                        MessageBox.Show("X wins");
                        fi[0,1].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[0, 2].Text == "X" && fi[1, 2].Text == "X" && fi[2, 2].Text == "X")
                    {
                        MessageBox.Show("X wins");
                        fi[0,2].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[0, 0].Text == "X" && fi[1, 1].Text == "X" && fi[2, 2].Text == "X")
                    {
                        MessageBox.Show("X wins");
                        fi[0,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[2, 0].Text == "X" && fi[1, 1].Text == "X" && fi[0, 2].Text == "X")
                    {
                        MessageBox.Show("X wins");
                        fi[2,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }


                    else if (fi[0, 0].Text == "0" && fi[0, 1].Text == "0" && fi[0, 2].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[0,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[1, 0].Text == "0" && fi[1, 1].Text == "0" && fi[1, 2].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[1,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[2, 0].Text == "0" && fi[2, 1].Text == "0" && fi[2, 2].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[2,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }

                    else if (fi[0, 0].Text == "0" && fi[1, 0].Text == "0" && fi[2, 0].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[0,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[0, 1].Text == "0" && fi[1, 1].Text == "0" && fi[2, 1].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[0,1].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[0, 2].Text == "0" && fi[1, 2].Text == "0" && fi[2, 2].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[0,2].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[0, 0].Text == "0" && fi[1, 1].Text == "0" && fi[2, 2].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[0,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if (fi[2, 0].Text == "0" && fi[1, 1].Text == "0" && fi[0, 2].Text == "0")
                    {
                        MessageBox.Show("0 wins");
                        fi[2,0].Text = " ";
                        Controls.Clear();
                        butt();
                    }
                    else if(count==9)
                    {
                        
                        MessageBox.Show("Draw");
                        count--;
                        Controls.Clear();
                        butt();
                    }
                    
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
