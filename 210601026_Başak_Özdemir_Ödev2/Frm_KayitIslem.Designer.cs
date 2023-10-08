namespace _210601026_Başak_Özdemir_Ödev2
{
    partial class Frm_KayitIslem
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
            this.dgv_Guncelle = new System.Windows.Forms.DataGridView();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_kod = new System.Windows.Forms.TextBox();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guncelle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Guncelle
            // 
            this.dgv_Guncelle.AllowUserToAddRows = false;
            this.dgv_Guncelle.AllowUserToDeleteRows = false;
            this.dgv_Guncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Guncelle.Location = new System.Drawing.Point(12, 53);
            this.dgv_Guncelle.Name = "dgv_Guncelle";
            this.dgv_Guncelle.ReadOnly = true;
            this.dgv_Guncelle.RowHeadersVisible = false;
            this.dgv_Guncelle.RowTemplate.Height = 25;
            this.dgv_Guncelle.Size = new System.Drawing.Size(720, 281);
            this.dgv_Guncelle.TabIndex = 0;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Guncelle.Location = new System.Drawing.Point(153, 64);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(125, 28);
            this.btn_Guncelle.TabIndex = 16;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEkle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(549, 388);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 62);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "DERS EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_sil.Location = new System.Drawing.Point(300, 63);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(125, 28);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Güncellenecek/Silinecek Dersin Kodu";
            // 
            // txt_kod
            // 
            this.txt_kod.Location = new System.Drawing.Point(300, 29);
            this.txt_kod.Name = "txt_kod";
            this.txt_kod.Size = new System.Drawing.Size(125, 26);
            this.txt_kod.TabIndex = 20;
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Geri.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.Location = new System.Drawing.Point(12, 12);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(57, 30);
            this.btn_Geri.TabIndex = 21;
            this.btn_Geri.Text = "<";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_kod);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 126);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Güncelle/Sil";
            // 
            // Frm_KayitIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(754, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgv_Guncelle);
            this.MaximizeBox = false;
            this.Name = "Frm_KayitIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Frm_KayitIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guncelle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView dgv_Guncelle;
        private Button btn_Guncelle;
        private Button btnEkle;
        private Button btn_sil;
        private Label label8;
        public TextBox txt_kod;
        private Button btn_Geri;
        private GroupBox groupBox1;
    }
}