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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Btnharitaara_Click_1(object sender, EventArgs e)
        {
            String sokak = txtsokak.Text;
            string sehir = txtsehir.Text;
            string devlet = txtdevlet.Text;
            string gayret = txtgayret.Text;
            string ilce = txtilce.Text;
            string parkbahce = txtparkbahce.Text;
            string acilhizmetler = txtacilhizmetler.Text;
            try
            {
                StringBuilder quaryadress = new StringBuilder();
                quaryadress.Append("http://maps.google.com/maps?q=");
                if (sokak != string.Empty)
                {
                    quaryadress.Append(sokak + "," + "+");
                }
                if (sehir != string.Empty)
                {
                    quaryadress.Append(sehir + "," + "+");
                }
                if (devlet != string.Empty)
                {
                    quaryadress.Append(devlet + "," + "+");
                }
                if (gayret != string.Empty)
                {
                    quaryadress.Append(gayret + "," + "+");
                }
                if (ilce != string.Empty)
                {
                    quaryadress.Append(ilce + "," + "+");
                }
                if (parkbahce != string.Empty)
                {
                    quaryadress.Append(parkbahce + "," + "+");
                }
                if (acilhizmetler != string.Empty)
                {
                    quaryadress.Append(acilhizmetler + "," + "+");
                }
                webBrowser1.Navigate(quaryadress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "HATA");
            }
        }

        private void Btnenyakinyertemizle_Click(object sender, EventArgs e)
        {
            if (txtacilhizmetler.Text!=""||txtdevlet.Text!="" || txtgayret.Text!="" || txtilce.Text!="" || txtparkbahce.Text!="" || txtsehir.Text!="" || txtsokak.Text!="")
            {
                txtacilhizmetler.Clear();
                txtdevlet.Clear();
                txtgayret.Clear();
                txtilce.Clear();
                txtparkbahce.Clear();
                txtsehir.Clear();
                txtsokak.Clear();
            }
            else
            {
                MessageBox.Show("ALANLAR ZATEN BOŞ.", "HATA");
            }
        }

        private void Btnenyakinyergeri_Click_1(object sender, EventArgs e)
        {
            Form1 frm11 = new Form1();
            frm11.Show();
            this.Hide();
        }

        private void Btnenyakinyercikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
