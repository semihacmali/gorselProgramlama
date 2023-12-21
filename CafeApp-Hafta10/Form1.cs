using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp_Hafta10
{
	public partial class Form1 : Form
	{
		int toplamPara = 1000;
		int tutar = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label2.Text = toplamPara.ToString() + " TL";
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			tutar += 115;
			label5.Text = tutar.ToString() + " TL";
			listBox1.Items.Add("Peynir");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			tutar += 75;
			label5.Text = tutar.ToString() + " TL";
			listBox1.Items.Add("Cupcake");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			tutar += 225;
			label5.Text = tutar.ToString() + " TL";
			listBox1.Items.Add("Hamburger");
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			tutar += 100;
			label5.Text = tutar.ToString() + " TL";
			listBox1.Items.Add("Hot Dog");
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			tutar += 60;
			label5.Text = tutar.ToString() + " TL";
			listBox1.Items.Add("Puncake");
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			tutar += 300;
			label5.Text = tutar.ToString() + " TL";
			listBox1.Items.Add("Pizza");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(toplamPara >= tutar)
			{
				MessageBox.Show("Ödemeniz Alınmıştır!","Bilgilendirme", 
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Yetersiz Bakiye!", "Bilgilendirme",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			String silinecekDeger = listBox1.Items[listBox1.Items.Count - 1].ToString();
			switch (silinecekDeger)
			{
				case "Pizza":
					tutar -= 300;
					label5.Text = tutar.ToString() + " TL";
					break;
				case "Puncake":
					tutar -= 60;
					label5.Text = tutar.ToString() + " TL";
					break;
				case "Hot Dog":
					tutar -= 100;
					label5.Text = tutar.ToString() + " TL";
					break;
				case "Hamburger":
					tutar -= 225;
					label5.Text = tutar.ToString() + " TL";
					break;
				case "Cupcake":
					tutar -= 75;
					label5.Text = tutar.ToString() + " TL";
					break;
				case "Peynir":
					tutar -= 115;
					label5.Text = tutar.ToString() + " TL";
					break;
			}
			listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
		}
	}
}
