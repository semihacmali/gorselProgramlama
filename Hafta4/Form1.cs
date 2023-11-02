using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.Items.Add("İstanbul");
			comboBox1.Items.Add("Bursa");
			comboBox1.Items.Add("Ordu");
			comboBox1.Items.Add("Zonguldak");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = label1.Text + "*";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text = label1.Text + "\n";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			for(int i = 1; i <= 5; i++)
			{
				for(int j = 1; j <= i; j++)
				{
					label1.Text = label1.Text + "*";
				}
				label1.Text = label1.Text + "\n";
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Samsun");
			comboBox1.Items.Add("Sivas");
			comboBox1.Items.Add("Muğla");
			comboBox1.Items.Add("Mardin");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			String sehir = comboBox1.SelectedItem.ToString();
			label2.Text = sehir + " şehrini seçtiniz...";
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			String sehir = comboBox1.SelectedItem.ToString();
			label2.Text = sehir + " şehrini seçtiniz...";
		}
	}
}
