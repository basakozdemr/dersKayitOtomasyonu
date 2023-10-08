namespace _210601026_Başak_Özdemir_Ödev2
{
    partial class Frm_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_frmTranskript = new System.Windows.Forms.Button();
            this.btn_KayitIslem = new System.Windows.Forms.Button();
            this.bildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_frmTranskript
            // 
            this.btn_frmTranskript.BackColor = System.Drawing.Color.LightCyan;
            this.btn_frmTranskript.Location = new System.Drawing.Point(109, 105);
            this.btn_frmTranskript.Margin = new System.Windows.Forms.Padding(4);
            this.btn_frmTranskript.Name = "btn_frmTranskript";
            this.btn_frmTranskript.Size = new System.Drawing.Size(265, 77);
            this.btn_frmTranskript.TabIndex = 0;
            this.btn_frmTranskript.Text = "TRANSKRİPT";
            this.btn_frmTranskript.UseVisualStyleBackColor = false;
            this.btn_frmTranskript.Click += new System.EventHandler(this.btn_frmTranskript_Click);
            // 
            // btn_KayitIslem
            // 
            this.btn_KayitIslem.BackColor = System.Drawing.Color.LightCyan;
            this.btn_KayitIslem.Location = new System.Drawing.Point(109, 248);
            this.btn_KayitIslem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KayitIslem.Name = "btn_KayitIslem";
            this.btn_KayitIslem.Size = new System.Drawing.Size(265, 76);
            this.btn_KayitIslem.TabIndex = 1;
            this.btn_KayitIslem.Text = "KAYIT İŞLEMLERİ";
            this.btn_KayitIslem.UseVisualStyleBackColor = false;
            this.btn_KayitIslem.Click += new System.EventHandler(this.btn_kayitIslem_Click);
            // 
            // bildirim
            // 
            this.bildirim.Text = "notifyIcon1";
            this.bildirim.Visible = true;
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(492, 466);
            this.Controls.Add(this.btn_KayitIslem);
            this.Controls.Add(this.btn_frmTranskript);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÜ";
            this.ResumeLayout(false);

        }

        #endregion

        public Button btn_frmTranskript;
        public Button btn_KayitIslem;
        private NotifyIcon bildirim;
    }
}