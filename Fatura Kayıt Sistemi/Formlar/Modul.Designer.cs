namespace Fatura_Kayıt_Sistemi
{
    partial class Modul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul));
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.faturaKayit = new System.Windows.Forms.Button();
            this.btn_check_update = new System.Windows.Forms.Button();
            this.btnKayıtAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Logo
            // 
            this.PB_Logo.Location = new System.Drawing.Point(12, 12);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(274, 264);
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            // 
            // faturaKayit
            // 
            this.faturaKayit.Location = new System.Drawing.Point(302, 12);
            this.faturaKayit.Name = "faturaKayit";
            this.faturaKayit.Size = new System.Drawing.Size(123, 63);
            this.faturaKayit.TabIndex = 1;
            this.faturaKayit.Text = "Fatura Kayıt Sistemi";
            this.faturaKayit.UseVisualStyleBackColor = true;
            this.faturaKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_check_update
            // 
            this.btn_check_update.Location = new System.Drawing.Point(568, 229);
            this.btn_check_update.Name = "btn_check_update";
            this.btn_check_update.Size = new System.Drawing.Size(111, 47);
            this.btn_check_update.TabIndex = 3;
            this.btn_check_update.Text = "Güncellemeleri Denetle";
            this.btn_check_update.UseVisualStyleBackColor = true;
            this.btn_check_update.Click += new System.EventHandler(this.btn_check_update_Click);
            // 
            // btnKayıtAdmin
            // 
            this.btnKayıtAdmin.Location = new System.Drawing.Point(431, 12);
            this.btnKayıtAdmin.Name = "btnKayıtAdmin";
            this.btnKayıtAdmin.Size = new System.Drawing.Size(123, 63);
            this.btnKayıtAdmin.TabIndex = 4;
            this.btnKayıtAdmin.Text = "Fatura Kayıt Sistemi Admin Paneli";
            this.btnKayıtAdmin.UseVisualStyleBackColor = true;
            this.btnKayıtAdmin.Click += new System.EventHandler(this.btnKayıtAdmin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Modul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKayıtAdmin);
            this.Controls.Add(this.btn_check_update);
            this.Controls.Add(this.faturaKayit);
            this.Controls.Add(this.PB_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Modul";
            this.Text = "Modul";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modul_FormClosing);
            this.Load += new System.EventHandler(this.Modul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Button faturaKayit;
        private System.Windows.Forms.Button btn_check_update;
        private System.Windows.Forms.Button btnKayıtAdmin;
        private System.Windows.Forms.Button button1;
    }
}