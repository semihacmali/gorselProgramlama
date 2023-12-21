using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String kelime = textBox1.Text;
			if(checkBox1.Checked == true)
			{
				listBox1.Items.Add(kelime);
			}
			else
			{
				//listBox1.Items.Remove(kelime);
				/*
				if(listBox1.Items.Count > 0) // icerisinde eleman varsa sil
				{
					listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
				}
				*/
				if(listBox1.SelectedItem != null)
				{
					listBox1.Items.Remove(listBox1.SelectedItem.ToString());
				}
				

			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			label1.Text = checkBox1.Checked.ToString();
			if(checkBox1.Checked == true)
			{
				button1.Text = "Eleman Ekle";
			}
			else
			{
				button1.Text = "Eleman Cıkar";
			}
		}


	}
}
