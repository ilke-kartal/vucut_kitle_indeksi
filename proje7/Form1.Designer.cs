namespace proje7
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKilonuz = new System.Windows.Forms.Label();
            this.lblBoyunuz = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.grpVucutkitleİndeksi = new System.Windows.Forms.GroupBox();
            this.grpVucutkitleİndeksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKilonuz
            // 
            this.lblKilonuz.AutoSize = true;
            this.lblKilonuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKilonuz.ForeColor = System.Drawing.Color.Black;
            this.lblKilonuz.Location = new System.Drawing.Point(60, 39);
            this.lblKilonuz.Name = "lblKilonuz";
            this.lblKilonuz.Size = new System.Drawing.Size(118, 23);
            this.lblKilonuz.TabIndex = 0;
            this.lblKilonuz.Text = "Kilonuz(kg)";
            // 
            // lblBoyunuz
            // 
            this.lblBoyunuz.AutoSize = true;
            this.lblBoyunuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoyunuz.Location = new System.Drawing.Point(60, 81);
            this.lblBoyunuz.Name = "lblBoyunuz";
            this.lblBoyunuz.Size = new System.Drawing.Size(124, 23);
            this.lblBoyunuz.TabIndex = 1;
            this.lblBoyunuz.Text = "Boyunuz(m)";
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(177, 33);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(100, 22);
            this.txtKilo.TabIndex = 2;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(177, 81);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 22);
            this.txtBoy.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(177, 131);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 30);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // grpVucutkitleİndeksi
            // 
            this.grpVucutkitleİndeksi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grpVucutkitleİndeksi.Controls.Add(this.txtKilo);
            this.grpVucutkitleİndeksi.Controls.Add(this.btnHesapla);
            this.grpVucutkitleİndeksi.Controls.Add(this.txtBoy);
            this.grpVucutkitleİndeksi.Controls.Add(this.lblBoyunuz);
            this.grpVucutkitleİndeksi.Controls.Add(this.lblKilonuz);
            this.grpVucutkitleİndeksi.Location = new System.Drawing.Point(169, 67);
            this.grpVucutkitleİndeksi.Name = "grpVucutkitleİndeksi";
            this.grpVucutkitleİndeksi.Size = new System.Drawing.Size(369, 208);
            this.grpVucutkitleİndeksi.TabIndex = 5;
            this.grpVucutkitleİndeksi.TabStop = false;
            this.grpVucutkitleİndeksi.Text = "Vücut Kitle İndeksi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.grpVucutkitleİndeksi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpVucutkitleİndeksi.ResumeLayout(false);
            this.grpVucutkitleİndeksi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKilonuz;
        private System.Windows.Forms.Label lblBoyunuz;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox grpVucutkitleİndeksi;
    }
}

