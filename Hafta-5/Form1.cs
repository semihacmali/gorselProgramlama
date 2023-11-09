using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_MouseClick(object sender, MouseEventArgs e)
		{
			String text1 = textBox1.Text;
			String text2 = textBox2.Text;

			label1.Text = text1 + " " + text2;

			kelimeBirlestirme();

		}

		public void kelimeBirlestirme()
		{
			label2.Text = "Buttona Basıldı!!!";
		}

		public int Toplama(int sayi1, int sayi2)
		{
			return sayi1 + sayi2;
		}

		public int Cikarma(int sayi1, int sayi2)
		{
			return sayi1 - sayi2;
		}

		public int Bolme(int sayi1, int sayi2)
		{
			return sayi1 / sayi2;
		}

		public int Carpma(int sayi1, int sayi2)
		{
			return sayi1 * sayi2;
		}

		private void button2_MouseClick(object sender, MouseEventArgs e)
		{
			int deger1 = Convert.ToInt32(textBox3.Text);
			int deger2 = Convert.ToInt32(textBox4.Text);

			int sonuc = Toplama(deger1, deger2);

			textBox5.Text = Convert.ToString(sonuc);

		}

		private void button3_MouseClick(object sender, MouseEventArgs e)
		{
			int deger1 = Convert.ToInt32(textBox3.Text);
			int deger2 = Convert.ToInt32(textBox4.Text);

			int sonuc = Cikarma(deger1, deger2);

			textBox5.Text = Convert.ToString(sonuc);
		}

		private void button4_MouseClick(object sender, MouseEventArgs e)
		{
			int deger1 = Convert.ToInt32(textBox3.Text);
			int deger2 = Convert.ToInt32(textBox4.Text);

			int sonuc = Carpma(deger1, deger2);

			textBox5.Text = Convert.ToString(sonuc);
		}

		private void button5_MouseClick(object sender, MouseEventArgs e)
		{
			int deger1 = Convert.ToInt32(textBox3.Text);
			int deger2 = Convert.ToInt32(textBox4.Text);

			int sonuc = Bolme(deger1, deger2);

			textBox5.Text = Convert.ToString(sonuc);
		}

		public int ustAlma(int taban, int ust)
		{
			int sonuc = 1;
			for(int i = 1; i <= ust; i++)
			{
				sonuc = sonuc * taban;
			}
			return sonuc;

		}


		private void button6_MouseClick(object sender, MouseEventArgs e)
		{
			int deger1 = Convert.ToInt32(textBox3.Text);
			int deger2 = Convert.ToInt32(textBox4.Text);

			int sonuc = recursiveUstAlma(deger1, deger2);

			textBox5.Text = Convert.ToString(sonuc);
		}

		public int recursiveUstAlma(int taban, int ust)
		{
			if(ust == 0)
			{
				return 1;
			}
			else if( ust == 1)
			{
				return taban;
			}
			else
			{
				return taban * recursiveUstAlma(taban, ust - 1);
			}

		}
	}
}
