using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama2024
{
	public partial class Form1 : Form
	{
		int sayici = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_MouseClick(object sender, MouseEventArgs e)
		{
			label1.Text = "kurt max pro";
			label2.Visible = true;
			if (sayici % 2 == 0)
			{
				label2.BackColor = Color.Coral;
				label2.Text = "uşağum";
				sayici++;
			}
			else
			{
				label2.BackColor = Color.Red;
				label2.Text = "yavaş";
				sayici++;
			}
			label2.Location = new Point(100, 100);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.BackColor = Color.Violet;
			//label2.Visible = false;
			label1.Location = new Point(0, 0);
		}

		private void label2_MouseUp(object sender, MouseEventArgs e)
		{
			label1.Location = new Point(0, 0);
		}

		private void label2_MouseEnter(object sender, EventArgs e)
		{
			Random rnd = new Random();

			label2.Location = new Point(rnd.Next(0,500), rnd.Next(0,500));
		}
	}
}
