using System;

namespace kararsizligasonuygulamasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1evet = new System.Windows.Forms.ProgressBar();
            this.progressBar2hayir = new System.Windows.Forms.ProgressBar();
            this.lblevet = new System.Windows.Forms.Label();
            this.lblhayir = new System.Windows.Forms.Label();
            this.btnkarar = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.basliklabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnseceneklikarar = new System.Windows.Forms.Button();
            this.btnmap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1evet
            // 
            this.progressBar1evet.Location = new System.Drawing.Point(124, 73);
            this.progressBar1evet.Name = "progressBar1evet";
            this.progressBar1evet.Size = new System.Drawing.Size(109, 23);
            this.progressBar1evet.TabIndex = 0;
            // 
            // progressBar2hayir
            // 
            this.progressBar2hayir.Location = new System.Drawing.Point(124, 106);
            this.progressBar2hayir.Name = "progressBar2hayir";
            this.progressBar2hayir.Size = new System.Drawing.Size(109, 23);
            this.progressBar2hayir.TabIndex = 1;
            // 
            // lblevet
            // 
            this.lblevet.AutoSize = true;
            this.lblevet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblevet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblevet.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevet.Location = new System.Drawing.Point(32, 77);
            this.lblevet.Name = "lblevet";
            this.lblevet.Size = new System.Drawing.Size(43, 23);
            this.lblevet.TabIndex = 2;
            this.lblevet.Text = "EVET:";
            // 
            // lblhayir
            // 
            this.lblhayir.AutoSize = true;
            this.lblhayir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblhayir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblhayir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhayir.Location = new System.Drawing.Point(32, 110);
            this.lblhayir.Name = "lblhayir";
            this.lblhayir.Size = new System.Drawing.Size(52, 23);
            this.lblhayir.TabIndex = 3;
            this.lblhayir.Text = "HAYIR:";
            // 
            // btnkarar
            // 
            this.btnkarar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnkarar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkarar.Location = new System.Drawing.Point(32, 144);
            this.btnkarar.Name = "btnkarar";
            this.btnkarar.Size = new System.Drawing.Size(201, 34);
            this.btnkarar.TabIndex = 4;
            this.btnkarar.Text = "KARAR VER";
            this.btnkarar.UseVisualStyleBackColor = false;
            this.btnkarar.Click += new System.EventHandler(this.Btnkarar_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnyenile.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyenile.Location = new System.Drawing.Point(7, 234);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(122, 34);
            this.btnyenile.TabIndex = 5;
            this.btnyenile.Text = "YENİLE";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.Btnyenile_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btncikis.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.Location = new System.Drawing.Point(136, 234);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(121, 34);
            this.btncikis.TabIndex = 6;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.Btncikis_Click);
            // 
            // basliklabel
            // 
            this.basliklabel.AutoSize = true;
            this.basliklabel.BackColor = System.Drawing.Color.Snow;
            this.basliklabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.basliklabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basliklabel.Location = new System.Drawing.Point(32, 19);
            this.basliklabel.Name = "basliklabel";
            this.basliklabel.Size = new System.Drawing.Size(199, 39);
            this.basliklabel.TabIndex = 7;
            this.basliklabel.Text = "MUSTAFA KOCA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(233, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            // 
            // btnseceneklikarar
            // 
            this.btnseceneklikarar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnseceneklikarar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseceneklikarar.Location = new System.Drawing.Point(135, 184);
            this.btnseceneklikarar.Name = "btnseceneklikarar";
            this.btnseceneklikarar.Size = new System.Drawing.Size(98, 44);
            this.btnseceneklikarar.TabIndex = 13;
            this.btnseceneklikarar.Text = "SEÇENEKLİ KARAR";
            this.btnseceneklikarar.UseVisualStyleBackColor = false;
            this.btnseceneklikarar.Click += new System.EventHandler(this.Btnseceneklikarar_Click_1);
            // 
            // btnmap
            // 
            this.btnmap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnmap.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmap.Location = new System.Drawing.Point(32, 184);
            this.btnmap.Name = "btnmap";
            this.btnmap.Size = new System.Drawing.Size(97, 44);
            this.btnmap.TabIndex = 12;
            this.btnmap.Text = "EN YAKIN NERESİ?";
            this.btnmap.UseVisualStyleBackColor = false;
            this.btnmap.Click += new System.EventHandler(this.Btnmap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(264, 285);
            this.Controls.Add(this.btnseceneklikarar);
            this.Controls.Add(this.btnmap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basliklabel);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.btnkarar);
            this.Controls.Add(this.lblhayir);
            this.Controls.Add(this.lblevet);
            this.Controls.Add(this.progressBar2hayir);
            this.Controls.Add(this.progressBar1evet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KARAR YARDIMCISI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btnseceneklikarar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1evet;
        private System.Windows.Forms.ProgressBar progressBar2hayir;
        private System.Windows.Forms.Label lblevet;
        private System.Windows.Forms.Label lblhayir;
        private System.Windows.Forms.Button btnkarar;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label basliklabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnseceneklikarar;
        private System.Windows.Forms.Button btnmap;
    }
}

