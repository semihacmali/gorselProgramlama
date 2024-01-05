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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 anaEkran = new Form1();
			anaEkran.Show();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Form1 anaEkran = new Form1();
			textBox1.Text = anaEkran.textBox1.Text;

		}
	}
}
