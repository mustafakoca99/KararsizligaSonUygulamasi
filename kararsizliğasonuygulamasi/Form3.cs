using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kararsizligasonuygulamasi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Btnyapilacakolan_Click(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count;
            Random randomsec = new Random();
            int sayi = randomsec.Next(1, adet);
            listBox1.SelectedIndex = sayi;

            if (radioButton1.Checked==true)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString());
            }
            else if (radioButton2.Checked==true)
            {
            }
            else
            {
                MessageBox.Show("RadioButon seçiniz");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 denemeyenile = new Form3();
            denemeyenile.Show();
            this.Hide();
        }

        private void Btnrandomgeri_Click(object sender, EventArgs e)
        {
            Form1 deneme = new Form1();
            deneme.Show();
            this.Hide();
        }

        private void Btnrandomcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
