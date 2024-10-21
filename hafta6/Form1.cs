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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_MouseClick(object sender, MouseEventArgs e)
		{
			String[] alsana = new String[checkedListBox1.CheckedItems.Count]; 
			for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
			{
				alsana[i] = checkedListBox1.CheckedItems[i].ToString();
				//MessageBox.Show(i + ". sekme seçildi.." + checkedListBox1.CheckedItems[i].ToString());
			}

			Form2 odemeEkrani = new Form2();
			odemeEkrani.versene = alsana;
			odemeEkrani.ShowDialog();

		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
