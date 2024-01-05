using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Hafta11
{
	public partial class Form1 : Form
	{
		int indis = 0;
		string[] elemanlar = new string[5];
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] gunler = new string[7];
			gunler[0] = "Pazartesi";
			gunler[1] = "Salı";
			gunler[2] = "Çarşamba";
			gunler[3] = "Perşembe";
			gunler[4] = "Cuma";
			gunler[5] = "Cumartesi";
			gunler[6] = "Pazar";

			label1.Text = gunler[3];




		}

		private void button2_Click(object sender, EventArgs e)
		{
			int[] sayilar = {2,6,8,9,4,7,3,10,0,1,15};
			int toplam = 0;
			// tüm sayıların toplamı
			for(int i = 0; i < sayilar.Length; i++)
			{
				toplam = toplam + sayilar[i];
			}
			label2.Text = toplam.ToString();


			toplam = 0;
			// Son 5 elemanın toplamı
			for (int i = sayilar.Length - 5 ; i < sayilar.Length; i++)
			{
				toplam = toplam + sayilar[i];
			}
			label3.Text = toplam.ToString();

			toplam = 0;
			// çift sayı olan indislerin toplamı
			for (int i = 0; i < sayilar.Length; i+=2)
			{
				toplam = toplam + sayilar[i];
			}
			label4.Text = toplam.ToString();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string[] gunler = new string[7];
			gunler[0] = "Pazartesi";
			gunler[1] = "Salı";
			gunler[2] = "Çarşamba";
			gunler[3] = "Perşembe";
			gunler[4] = "Cuma";
			gunler[5] = "Cumartesi";
			gunler[6] = "Pazar";

			Random rastgele = new Random();
			int sayi = rastgele.Next(0, 7);
			label5.Text = gunler[sayi];
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (indis < 5)
			{
				string eklenecekEleman = textBox1.Text;
				elemanlar[indis] = eklenecekEleman;
				indis++;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
		
				foreach ( string eleman in elemanlar)
				{
				listBox1.Items.Add(eleman);
				}
		}
	}
}
