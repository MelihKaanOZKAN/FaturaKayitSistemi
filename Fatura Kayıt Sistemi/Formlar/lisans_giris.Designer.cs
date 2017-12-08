namespace Fatura_Kayıt_Sistemi
{
    partial class lisans_giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_lisans_1 = new System.Windows.Forms.TextBox();
            this.Tbox_lisans_2 = new System.Windows.Forms.TextBox();
            this.Tbox_lisans_3 = new System.Windows.Forms.TextBox();
            this.Tbox_lisans_4 = new System.Windows.Forms.TextBox();
            this.Tbox_lisans_5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbox_Email = new System.Windows.Forms.TextBox();
            this.BTN_Dogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Lisansını Girin:";
            // 
            // Tbox_lisans_1
            // 
            this.Tbox_lisans_1.Location = new System.Drawing.Point(28, 36);
            this.Tbox_lisans_1.MaxLength = 5;
            this.Tbox_lisans_1.Name = "Tbox_lisans_1";
            this.Tbox_lisans_1.Size = new System.Drawing.Size(46, 20);
            this.Tbox_lisans_1.TabIndex = 1;
            this.Tbox_lisans_1.TextChanged += new System.EventHandler(this.Tbox_Lisans_1_TextChanged);
            // 
            // Tbox_lisans_2
            // 
            this.Tbox_lisans_2.Location = new System.Drawing.Point(82, 36);
            this.Tbox_lisans_2.MaxLength = 5;
            this.Tbox_lisans_2.Name = "Tbox_lisans_2";
            this.Tbox_lisans_2.Size = new System.Drawing.Size(46, 20);
            this.Tbox_lisans_2.TabIndex = 2;
            this.Tbox_lisans_2.TextChanged += new System.EventHandler(this.Tbox_lisans_2_TextChanged);
            // 
            // Tbox_lisans_3
            // 
            this.Tbox_lisans_3.Location = new System.Drawing.Point(134, 36);
            this.Tbox_lisans_3.MaxLength = 5;
            this.Tbox_lisans_3.Name = "Tbox_lisans_3";
            this.Tbox_lisans_3.Size = new System.Drawing.Size(46, 20);
            this.Tbox_lisans_3.TabIndex = 3;
            this.Tbox_lisans_3.TextChanged += new System.EventHandler(this.Tbox_lisans_3_TextChanged);
            // 
            // Tbox_lisans_4
            // 
            this.Tbox_lisans_4.Location = new System.Drawing.Point(186, 36);
            this.Tbox_lisans_4.MaxLength = 5;
            this.Tbox_lisans_4.Name = "Tbox_lisans_4";
            this.Tbox_lisans_4.Size = new System.Drawing.Size(46, 20);
            this.Tbox_lisans_4.TabIndex = 4;
            this.Tbox_lisans_4.TextChanged += new System.EventHandler(this.Tbox_lisans_4_TextChanged);
            // 
            // Tbox_lisans_5
            // 
            this.Tbox_lisans_5.Location = new System.Drawing.Point(238, 36);
            this.Tbox_lisans_5.MaxLength = 5;
            this.Tbox_lisans_5.Name = "Tbox_lisans_5";
            this.Tbox_lisans_5.Size = new System.Drawing.Size(46, 20);
            this.Tbox_lisans_5.TabIndex = 5;
            this.Tbox_lisans_5.TextChanged += new System.EventHandler(this.Tbox_lisans_5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kayıtlı Email Adresini Girin:";
            // 
            // Tbox_Email
            // 
            this.Tbox_Email.Location = new System.Drawing.Point(28, 87);
            this.Tbox_Email.Name = "Tbox_Email";
            this.Tbox_Email.Size = new System.Drawing.Size(256, 20);
            this.Tbox_Email.TabIndex = 7;
            // 
            // BTN_Dogrula
            // 
            this.BTN_Dogrula.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.BTN_Dogrula.Location = new System.Drawing.Point(305, 109);
            this.BTN_Dogrula.Name = "BTN_Dogrula";
            this.BTN_Dogrula.Size = new System.Drawing.Size(94, 42);
            this.BTN_Dogrula.TabIndex = 8;
            this.BTN_Dogrula.Text = "Doğrula";
            this.BTN_Dogrula.UseVisualStyleBackColor = true;
            this.BTN_Dogrula.Click += new System.EventHandler(this.BTN_Dogrula_Click);
            // 
            // lisans_giris
            // 
            this.AcceptButton = this.BTN_Dogrula;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 163);
            this.Controls.Add(this.BTN_Dogrula);
            this.Controls.Add(this.Tbox_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbox_lisans_5);
            this.Controls.Add(this.Tbox_lisans_4);
            this.Controls.Add(this.Tbox_lisans_3);
            this.Controls.Add(this.Tbox_lisans_2);
            this.Controls.Add(this.Tbox_lisans_1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lisans_giris";
            this.ShowIcon = false;
            this.Text = "Program Aktivasyonu";
            this.Load += new System.EventHandler(this.lisans_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_lisans_1;
        private System.Windows.Forms.TextBox Tbox_lisans_2;
        private System.Windows.Forms.TextBox Tbox_lisans_3;
        private System.Windows.Forms.TextBox Tbox_lisans_4;
        private System.Windows.Forms.TextBox Tbox_lisans_5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbox_Email;
        private System.Windows.Forms.Button BTN_Dogrula;
    }
}