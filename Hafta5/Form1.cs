using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_MouseClick(object sender, MouseEventArgs e)
		{
			
			if (comboBox1.SelectedItem.ToString() == "Çıkartma")
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)).ToString();
			}
			else if (comboBox1.SelectedItem.ToString() == "Bölme")
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text)).ToString();
			}

			else if (comboBox1.SelectedItem.ToString() == "Çarpma")
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)).ToString();
			}

			else 
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
			}


		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem.ToString() == "Çıkartma")
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)).ToString();
			}
			else if (comboBox1.SelectedItem.ToString() == "Bölme")
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text)).ToString();
			}

			else if (comboBox1.SelectedItem.ToString() == "Çarpma")
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)).ToString();
			}

			else
			{
				textBox3.Text = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
			}
		}
	}
}
