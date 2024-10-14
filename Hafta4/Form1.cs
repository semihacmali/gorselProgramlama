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
		string Kullanici_Adi = "Ruhi Çenet";
		string Sifre = "ruhi123";
		public Form1()
		{
			InitializeComponent();
			label1.Text = "Kullanıcı Adı";
			label2.Text = "Şifre";
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_MouseClick(object sender, MouseEventArgs e)
		{
			string GirilenKullaniciAdi = textBox2.Text;
			string GirilenSifre = textBox1.Text;
			if ((GirilenKullaniciAdi.ToUpper() == Kullanici_Adi.ToUpper()) && (GirilenSifre == Sifre))

			{
				label3.Text = "Giriş yapıldı";
				
			}
			else
			{
				label3.Text = "Kullanıcı Adı veya şifre Yanlıştır";
			
			}
		}
	}
}
