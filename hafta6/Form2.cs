using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta6
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		public String[] versene;
		private void Form2_Load(object sender, EventArgs e)
		{
			foreach(String urun in versene)
			{
				listBox1.Items.Add(urun);
			}
		}
	}
}
