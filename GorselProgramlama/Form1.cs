using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			label1.Visible = true;

		}

		private void label1_MouseClick(object sender, MouseEventArgs e)
		{
			label1.Text = "İnternet ve Ağ Teknolojileri";
		}
	}
}
