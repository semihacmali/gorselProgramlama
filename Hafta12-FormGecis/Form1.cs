using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta12_FormGecis
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 formGecis = new Form2();
			formGecis.ShowDialog();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "admin" && textBox2.Text == "123456")
			{
				Form2 formGecis = new Form2();

				formGecis.label1.Text = textBox1.Text;

				formGecis.ShowDialog();
			}
			else
			{
			MessageBox.Show("Kullanıcı adı veya şifre yanlış!!!","HATA");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Text = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			double vize = Convert.ToDouble(textBox3.Text);
			double final = Convert.ToDouble(textBox4.Text);
			double not = vize * 0.4 + final * 0.6;
			double gecmeNot = (50 - vize * 0.4) / 0.6;
			form2.label2.Text = "Notunuz : " + not.ToString();
			form2.label3.Text = "50 için almanız gereken Not : " + gecmeNot.ToString();
			form2.ShowDialog();
		}
	}
}
