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
    public partial class Form1 : Form
    {
        int t, s;
        public Form1()
        {
            InitializeComponent();
            progressBar1evet.Visible = false;
            progressBar2hayir.Visible = false;
        }
        Random rnd = new Random();
        private void random1()
        {
          
            t = rnd.Next(100);
            label1.Text = t.ToString();
            this.Refresh();
            s = rnd.Next(100);
            label2.Text = s.ToString();
            s = 100 - t;
            label2.Text = s.ToString();
        }
        private void random2()
        {
        }
        private void Btncikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEŞEKKÜR EDERİM", "GÜLE GÜLE");
            Application.Exit();
        }

        private void Btnyenile_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Btnmap_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Btnseceneklikarar_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Btnkarar_Click(object sender, EventArgs e)
        {
            /*progressBar1evet.Step = 10;
            progressBar1evet.PerformStep();*/
            int toplam;
            toplam = t+s;
            if (toplam<=100)
            {
                int i;
                progressBar1evet.Minimum = 0;
                progressBar1evet.Maximum = 100;
                progressBar1evet.Visible = true;
                for (i = 0; i <= 100; i++)
                {
                    progressBar1evet.Value = i;
                    int percent = (int)(((double)(progressBar1evet.Value - progressBar1evet.Minimum) /
                        (double)(progressBar1evet.Maximum - progressBar1evet.Minimum)) * 100);
                    using (Graphics gr = progressBar1evet.CreateGraphics())
                    {
                        gr.DrawString(percent.ToString() + "%",
                            SystemFonts.MessageBoxFont, Brushes.Red,
                            new PointF(progressBar1evet.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
                            SystemFonts.MessageBoxFont).Width / 2.0F),
                            progressBar1evet.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                            SystemFonts.MessageBoxFont).Height / 2.0F)));
                    }
                }
                progressBar1evet.Visible = false;
                random1();
                progressBar2hayir.Minimum = 0;
                progressBar2hayir.Maximum = 100;
                progressBar2hayir.Visible = true;
                for (i = 0; i <= 100; i++)
                {
                    progressBar2hayir.Value = i;
                    int percent = (int)(((double)(progressBar2hayir.Value - progressBar2hayir.Minimum) /
                        (double)(progressBar2hayir.Maximum - progressBar2hayir.Minimum)) * 100);
                    using (Graphics gr = progressBar2hayir.CreateGraphics())
                    {
                        gr.DrawString(percent.ToString() + "%",
                            SystemFonts.MessageBoxFont,
                            Brushes.Red,
                            new PointF(progressBar2hayir.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
                            SystemFonts.MessageBoxFont).Width / 2.0F),
                            progressBar2hayir.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                            SystemFonts.MessageBoxFont).Height / 2.0F)));
                    }
                }
                progressBar2hayir.Visible = false;
                random2();
            }
            else
            {
                MessageBox.Show("Özür dileriz:100'den büyük sayı atandı, yeniden dene.");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }
    }
}


