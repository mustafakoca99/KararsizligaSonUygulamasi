namespace kararsizligasonuygulamasi
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnyapilacakolan = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnrandomgeri = new System.Windows.Forms.Button();
            this.btnrandomyenile = new System.Windows.Forms.Button();
            this.btnrandomcikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "**kitap oku",
            "**gazete oku",
            "**dergi oku",
            "**ayet oku",
            "**müzik dinle",
            "**şarkı dinle",
            "**yazı yaz(ne olursa olsun)",
            "**kendine soru sor",
            "**soru cevapla",
            "**mesleğinle ilgili yeni bir şeyler öğren",
            "**geleceğe dair bir şeyler yap",
            "**film izle",
            "**resim çiz",
            "**sevdiğine sevdiğini söyle(sürekli)",
            "**anneni babanı ara, yanındaysa güzel bir şeyler söyle",
            "**oyun oyna",
            "**kendine güzel şeyler söyle"});
            this.listBox1.Location = new System.Drawing.Point(176, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 0;
            // 
            // btnyapilacakolan
            // 
            this.btnyapilacakolan.Location = new System.Drawing.Point(13, 13);
            this.btnyapilacakolan.Name = "btnyapilacakolan";
            this.btnyapilacakolan.Size = new System.Drawing.Size(144, 44);
            this.btnyapilacakolan.TabIndex = 1;
            this.btnyapilacakolan.Text = "YAPILACAK OLANI SEÇ";
            this.btnyapilacakolan.UseVisualStyleBackColor = true;
            this.btnyapilacakolan.Click += new System.EventHandler(this.Btnyapilacakolan_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 84);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MessageBox olsun";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "MessageBox olmasın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnrandomgeri
            // 
            this.btnrandomgeri.Location = new System.Drawing.Point(12, 198);
            this.btnrandomgeri.Name = "btnrandomgeri";
            this.btnrandomgeri.Size = new System.Drawing.Size(66, 23);
            this.btnrandomgeri.TabIndex = 4;
            this.btnrandomgeri.Text = "GERİ";
            this.btnrandomgeri.UseVisualStyleBackColor = true;
            this.btnrandomgeri.Click += new System.EventHandler(this.Btnrandomgeri_Click);
            // 
            // btnrandomyenile
            // 
            this.btnrandomyenile.Location = new System.Drawing.Point(95, 198);
            this.btnrandomyenile.Name = "btnrandomyenile";
            this.btnrandomyenile.Size = new System.Drawing.Size(62, 23);
            this.btnrandomyenile.TabIndex = 5;
            this.btnrandomyenile.Text = "YENİLE";
            this.btnrandomyenile.UseVisualStyleBackColor = true;
            this.btnrandomyenile.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnrandomcikis
            // 
            this.btnrandomcikis.Location = new System.Drawing.Point(12, 227);
            this.btnrandomcikis.Name = "btnrandomcikis";
            this.btnrandomcikis.Size = new System.Drawing.Size(145, 23);
            this.btnrandomcikis.TabIndex = 6;
            this.btnrandomcikis.Text = "ÇIKIŞ";
            this.btnrandomcikis.UseVisualStyleBackColor = true;
            this.btnrandomcikis.Click += new System.EventHandler(this.Btnrandomcikis_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 261);
            this.Controls.Add(this.btnrandomcikis);
            this.Controls.Add(this.btnrandomyenile);
            this.Controls.Add(this.btnrandomgeri);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnyapilacakolan);
            this.Controls.Add(this.listBox1);
            this.Name = "Form3";
            this.Text = "SEÇENEKLİ KARAR";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnyapilacakolan;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnrandomgeri;
        private System.Windows.Forms.Button btnrandomyenile;
        private System.Windows.Forms.Button btnrandomcikis;
    }
}