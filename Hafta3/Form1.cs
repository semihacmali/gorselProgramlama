using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			string str1 = "Semih AÇMALI";
			label1.Text = str1;
		}

		private void button1_MouseClick(object sender, MouseEventArgs e)
		{
			string str2 = textBox1.Text;
			label1.Text = str2;
		}

		private void button2_MouseClick(object sender, MouseEventArgs e)
		{
			string username = textBox1.Text;
			string password = textBox2.Text;

			if(username == "DMYO")
			{
				// label1.Text = "Kullanıcı Adı Doğru!!";
				if(password == "1234")
				{
					label1.Text = "Giriş Başarılı";
				}
				else
				{
					label1.Text = "Şifre Hatalı";
				}
			}
			else
			{
				label1.Text = "Kullanıcı Adı Hatalı!!!";
			}

		}
	}
}
