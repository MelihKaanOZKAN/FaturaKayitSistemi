namespace Fatura_Kayıt_Sistemi
{
    partial class Fatura_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura_Ekle));
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_O_Adı = new System.Windows.Forms.Label();
            this.Tbox_Okul_Adı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbox_KDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbox_Tutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBox_Harcama = new System.Windows.Forms.TextBox();
            this.lbl_harcama = new System.Windows.Forms.Label();
            this.Gbox_Fatura = new System.Windows.Forms.GroupBox();
            this.dtPicLastPay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBillImagePath = new System.Windows.Forms.Label();
            this.btnBillImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbox_Fatura_Durum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DTpic = new System.Windows.Forms.DateTimePicker();
            this.Btn_Fatura_Ekle = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tbox_Abone_No = new System.Windows.Forms.TextBox();
            this.txtSubType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gbox_Fatura.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(2, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abone No:";
            // 
            // Lbl_O_Adı
            // 
            this.Lbl_O_Adı.AutoSize = true;
            this.Lbl_O_Adı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_O_Adı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_O_Adı.Location = new System.Drawing.Point(30, 20);
            this.Lbl_O_Adı.Name = "Lbl_O_Adı";
            this.Lbl_O_Adı.Size = new System.Drawing.Size(55, 15);
            this.Lbl_O_Adı.TabIndex = 59;
            this.Lbl_O_Adı.Text = "Okul Adı:";
            // 
            // Tbox_Okul_Adı
            // 
            this.Tbox_Okul_Adı.Enabled = false;
            this.Tbox_Okul_Adı.Location = new System.Drawing.Point(89, 20);
            this.Tbox_Okul_Adı.Name = "Tbox_Okul_Adı";
            this.Tbox_Okul_Adı.Size = new System.Drawing.Size(246, 20);
            this.Tbox_Okul_Adı.TabIndex = 58;
            this.Tbox_Okul_Adı.TextChanged += new System.EventHandler(this.Tbox_Okul_Adı_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Fatura Tarihi:";
            // 
            // Tbox_KDV
            // 
            this.Tbox_KDV.Location = new System.Drawing.Point(133, 99);
            this.Tbox_KDV.Name = "Tbox_KDV";
            this.Tbox_KDV.Size = new System.Drawing.Size(101, 20);
            this.Tbox_KDV.TabIndex = 4;
            this.Tbox_KDV.Validating += new System.ComponentModel.CancelEventHandler(this.Tbox_KDV_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "KDV:";
            // 
            // Tbox_Tutar
            // 
            this.Tbox_Tutar.Location = new System.Drawing.Point(133, 71);
            this.Tbox_Tutar.Name = "Tbox_Tutar";
            this.Tbox_Tutar.Size = new System.Drawing.Size(101, 20);
            this.Tbox_Tutar.TabIndex = 3;
            this.Tbox_Tutar.Validating += new System.ComponentModel.CancelEventHandler(this.Tbox_Tutar_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Tutar:";
            // 
            // TBox_Harcama
            // 
            this.TBox_Harcama.Location = new System.Drawing.Point(133, 127);
            this.TBox_Harcama.Name = "TBox_Harcama";
            this.TBox_Harcama.Size = new System.Drawing.Size(101, 20);
            this.TBox_Harcama.TabIndex = 5;
            this.TBox_Harcama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBox_Harcama_KeyPress);
            this.TBox_Harcama.Validating += new System.ComponentModel.CancelEventHandler(this.TBox_Harcama_Validating);
            // 
            // lbl_harcama
            // 
            this.lbl_harcama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_harcama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_harcama.Location = new System.Drawing.Point(6, 127);
            this.lbl_harcama.Name = "lbl_harcama";
            this.lbl_harcama.Size = new System.Drawing.Size(78, 24);
            this.lbl_harcama.TabIndex = 66;
            this.lbl_harcama.Text = "Tüketim:";
            // 
            // Gbox_Fatura
            // 
            this.Gbox_Fatura.Controls.Add(this.dtPicLastPay);
            this.Gbox_Fatura.Controls.Add(this.label7);
            this.Gbox_Fatura.Controls.Add(this.lblBillImagePath);
            this.Gbox_Fatura.Controls.Add(this.btnBillImage);
            this.Gbox_Fatura.Controls.Add(this.label6);
            this.Gbox_Fatura.Controls.Add(this.Cbox_Fatura_Durum);
            this.Gbox_Fatura.Controls.Add(this.label9);
            this.Gbox_Fatura.Controls.Add(this.DTpic);
            this.Gbox_Fatura.Controls.Add(this.TBox_Harcama);
            this.Gbox_Fatura.Controls.Add(this.lbl_harcama);
            this.Gbox_Fatura.Controls.Add(this.Tbox_Tutar);
            this.Gbox_Fatura.Controls.Add(this.label5);
            this.Gbox_Fatura.Controls.Add(this.Tbox_KDV);
            this.Gbox_Fatura.Controls.Add(this.label4);
            this.Gbox_Fatura.Controls.Add(this.label3);
            this.Gbox_Fatura.Enabled = false;
            this.Gbox_Fatura.Location = new System.Drawing.Point(25, 156);
            this.Gbox_Fatura.Name = "Gbox_Fatura";
            this.Gbox_Fatura.Size = new System.Drawing.Size(362, 220);
            this.Gbox_Fatura.TabIndex = 70;
            this.Gbox_Fatura.TabStop = false;
            this.Gbox_Fatura.Text = "Fatura Bilgileri";
            // 
            // dtPicLastPay
            // 
            this.dtPicLastPay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicLastPay.Location = new System.Drawing.Point(133, 45);
            this.dtPicLastPay.Name = "dtPicLastPay";
            this.dtPicLastPay.Size = new System.Drawing.Size(101, 20);
            this.dtPicLastPay.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(7, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 78;
            this.label7.Text = "Son Ödeme Tarihi";
            // 
            // lblBillImagePath
            // 
            this.lblBillImagePath.AutoSize = true;
            this.lblBillImagePath.Location = new System.Drawing.Point(91, 154);
            this.lblBillImagePath.Name = "lblBillImagePath";
            this.lblBillImagePath.Size = new System.Drawing.Size(0, 13);
            this.lblBillImagePath.TabIndex = 76;
            // 
            // btnBillImage
            // 
            this.btnBillImage.Location = new System.Drawing.Point(133, 181);
            this.btnBillImage.Name = "btnBillImage";
            this.btnBillImage.Size = new System.Drawing.Size(75, 23);
            this.btnBillImage.TabIndex = 75;
            this.btnBillImage.Text = "Seç";
            this.btnBillImage.UseVisualStyleBackColor = true;
            this.btnBillImage.Click += new System.EventHandler(this.btnBillImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 74;
            this.label6.Text = "Fatura Görüntüsü:";
            // 
            // Cbox_Fatura_Durum
            // 
            this.Cbox_Fatura_Durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Fatura_Durum.FormattingEnabled = true;
            this.Cbox_Fatura_Durum.Items.AddRange(new object[] {
            "Ödenmedi",
            "Ödendi"});
            this.Cbox_Fatura_Durum.Location = new System.Drawing.Point(133, 155);
            this.Cbox_Fatura_Durum.Name = "Cbox_Fatura_Durum";
            this.Cbox_Fatura_Durum.Size = new System.Drawing.Size(101, 21);
            this.Cbox_Fatura_Durum.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(7, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 72;
            this.label9.Text = "Fatura Durumu:";
            // 
            // DTpic
            // 
            this.DTpic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTpic.Location = new System.Drawing.Point(133, 19);
            this.DTpic.Name = "DTpic";
            this.DTpic.Size = new System.Drawing.Size(101, 20);
            this.DTpic.TabIndex = 2;
            // 
            // Btn_Fatura_Ekle
            // 
            this.Btn_Fatura_Ekle.Enabled = false;
            this.Btn_Fatura_Ekle.Location = new System.Drawing.Point(13, 382);
            this.Btn_Fatura_Ekle.Name = "Btn_Fatura_Ekle";
            this.Btn_Fatura_Ekle.Size = new System.Drawing.Size(374, 115);
            this.Btn_Fatura_Ekle.TabIndex = 6;
            this.Btn_Fatura_Ekle.Text = "Faturayı Ekle";
            this.Btn_Fatura_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Fatura_Ekle.Click += new System.EventHandler(this.Btn_Fatura_Ekle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.TabIndex = 71;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // Tbox_Abone_No
            // 
            this.Tbox_Abone_No.Location = new System.Drawing.Point(72, 12);
            this.Tbox_Abone_No.Name = "Tbox_Abone_No";
            this.Tbox_Abone_No.Size = new System.Drawing.Size(103, 20);
            this.Tbox_Abone_No.TabIndex = 72;
            this.Tbox_Abone_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbox_Abone_No_KeyDown);
            // 
            // txtSubType
            // 
            this.txtSubType.Enabled = false;
            this.txtSubType.Location = new System.Drawing.Point(88, 48);
            this.txtSubType.Name = "txtSubType";
            this.txtSubType.Size = new System.Drawing.Size(103, 20);
            this.txtSubType.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Fatura Türü:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSubType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lbl_O_Adı);
            this.groupBox1.Controls.Add(this.Tbox_Okul_Adı);
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 84);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okul ve Fatura Bilgileri";
            // 
            // Fatura_Ekle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(411, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tbox_Abone_No);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Btn_Fatura_Ekle);
            this.Controls.Add(this.Gbox_Fatura);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fatura_Ekle";
            this.Text = "Fatura Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fatura_Ekle_FormClosing);
            this.Load += new System.EventHandler(this.Fatura_Ekle_Load);
            this.Gbox_Fatura.ResumeLayout(false);
            this.Gbox_Fatura.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       private System.Windows.Forms.Label  label2;
       private System.Windows.Forms.Label  Lbl_O_Adı;
        private System.Windows.Forms.TextBox Tbox_Okul_Adı;
       private System.Windows.Forms.Label  label3;
        private System.Windows.Forms.TextBox Tbox_KDV;
       private System.Windows.Forms.Label  label4;
        private System.Windows.Forms.TextBox Tbox_Tutar;
       private System.Windows.Forms.Label  label5;
        private System.Windows.Forms.TextBox TBox_Harcama;
       private System.Windows.Forms.Label  lbl_harcama;
        private System.Windows.Forms.GroupBox Gbox_Fatura;
        private System.Windows.Forms.Button Btn_Fatura_Ekle;
        private System.Windows.Forms.DateTimePicker DTpic;
        private System.Windows.Forms.ComboBox Cbox_Fatura_Durum;
       private System.Windows.Forms.Label  label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.TextBox Tbox_Abone_No;
        private System.Windows.Forms.TextBox txtSubType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBillImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBillImagePath;
        private System.Windows.Forms.DateTimePicker dtPicLastPay;
        private System.Windows.Forms.Label label7;
    }
}