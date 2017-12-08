namespace Fatura_Kayıt_Sistemi
{
    partial class Harcama_Kurumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Harcama_Kurumu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVPay = new System.Windows.Forms.DataGridView();
            this.GboxKurumİnfo = new System.Windows.Forms.GroupBox();
            this.TboxUnitPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TboxAciklama = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbox_kurum_tipi = new System.Windows.Forms.TextBox();
            this.lbl_kurum_tipi = new System.Windows.Forms.Label();
            this.Tbox_Kurum_No = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tbox_Kurum_Adı = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tbox_Iban = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tbox_Banka = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPay)).BeginInit();
            this.GboxKurumİnfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_Message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(920, 22);
            this.statusStrip1.TabIndex = 102;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel1.Text = "Mesajlar:";
            // 
            // lbl_Message
            // 
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(66, 17);
            this.lbl_Message.Text = " Mesaj Yok!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVPay);
            this.groupBox2.Controls.Add(this.GboxKurumİnfo);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Location = new System.Drawing.Point(12, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 590);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Kurumları";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DGVPay
            // 
            this.DGVPay.AllowUserToAddRows = false;
            this.DGVPay.AllowUserToDeleteRows = false;
            this.DGVPay.AllowUserToOrderColumns = true;
            this.DGVPay.AllowUserToResizeRows = false;
            this.DGVPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPay.Location = new System.Drawing.Point(12, 204);
            this.DGVPay.MultiSelect = false;
            this.DGVPay.Name = "DGVPay";
            this.DGVPay.ReadOnly = true;
            this.DGVPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPay.Size = new System.Drawing.Size(881, 380);
            this.DGVPay.TabIndex = 135;
            this.DGVPay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPay_CellDoubleClick);
            // 
            // GboxKurumİnfo
            // 
            this.GboxKurumİnfo.Controls.Add(this.TboxUnitPrice);
            this.GboxKurumİnfo.Controls.Add(this.label15);
            this.GboxKurumİnfo.Controls.Add(this.TboxAciklama);
            this.GboxKurumİnfo.Controls.Add(this.label8);
            this.GboxKurumİnfo.Controls.Add(this.Tbox_kurum_tipi);
            this.GboxKurumİnfo.Controls.Add(this.lbl_kurum_tipi);
            this.GboxKurumİnfo.Controls.Add(this.Tbox_Kurum_No);
            this.GboxKurumİnfo.Controls.Add(this.label9);
            this.GboxKurumİnfo.Controls.Add(this.Tbox_Kurum_Adı);
            this.GboxKurumİnfo.Controls.Add(this.label12);
            this.GboxKurumİnfo.Location = new System.Drawing.Point(12, 19);
            this.GboxKurumİnfo.Name = "GboxKurumİnfo";
            this.GboxKurumİnfo.Size = new System.Drawing.Size(441, 133);
            this.GboxKurumİnfo.TabIndex = 133;
            this.GboxKurumİnfo.TabStop = false;
            this.GboxKurumİnfo.Text = "Kurum Bilgileri";
            // 
            // TboxUnitPrice
            // 
            this.TboxUnitPrice.Enabled = false;
            this.TboxUnitPrice.Location = new System.Drawing.Point(322, 89);
            this.TboxUnitPrice.Name = "TboxUnitPrice";
            this.TboxUnitPrice.Size = new System.Drawing.Size(73, 20);
            this.TboxUnitPrice.TabIndex = 137;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 136;
            this.label15.Text = "Birim Fiyat;";
            // 
            // TboxAciklama
            // 
            this.TboxAciklama.Enabled = false;
            this.TboxAciklama.Location = new System.Drawing.Point(91, 73);
            this.TboxAciklama.Name = "TboxAciklama";
            this.TboxAciklama.Size = new System.Drawing.Size(222, 49);
            this.TboxAciklama.TabIndex = 132;
            this.TboxAciklama.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "Açıklama:";
            // 
            // Tbox_kurum_tipi
            // 
            this.Tbox_kurum_tipi.Enabled = false;
            this.Tbox_kurum_tipi.Location = new System.Drawing.Point(248, 19);
            this.Tbox_kurum_tipi.Name = "Tbox_kurum_tipi";
            this.Tbox_kurum_tipi.Size = new System.Drawing.Size(158, 20);
            this.Tbox_kurum_tipi.TabIndex = 130;
            // 
            // lbl_kurum_tipi
            // 
            this.lbl_kurum_tipi.AutoSize = true;
            this.lbl_kurum_tipi.Location = new System.Drawing.Point(177, 22);
            this.lbl_kurum_tipi.Name = "lbl_kurum_tipi";
            this.lbl_kurum_tipi.Size = new System.Drawing.Size(65, 13);
            this.lbl_kurum_tipi.TabIndex = 128;
            this.lbl_kurum_tipi.Text = "Kurum Türü:";
            // 
            // Tbox_Kurum_No
            // 
            this.Tbox_Kurum_No.Enabled = false;
            this.Tbox_Kurum_No.Location = new System.Drawing.Point(91, 19);
            this.Tbox_Kurum_No.Name = "Tbox_Kurum_No";
            this.Tbox_Kurum_No.Size = new System.Drawing.Size(73, 20);
            this.Tbox_Kurum_No.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 122;
            this.label9.Text = "Kurum No:";
            // 
            // Tbox_Kurum_Adı
            // 
            this.Tbox_Kurum_Adı.Enabled = false;
            this.Tbox_Kurum_Adı.Location = new System.Drawing.Point(91, 47);
            this.Tbox_Kurum_Adı.Name = "Tbox_Kurum_Adı";
            this.Tbox_Kurum_Adı.Size = new System.Drawing.Size(305, 20);
            this.Tbox_Kurum_Adı.TabIndex = 117;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "Kurum Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbox_Iban);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Tbox_Banka);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(463, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 133);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurum Banka Bilgileri";
            // 
            // Tbox_Iban
            // 
            this.Tbox_Iban.Enabled = false;
            this.Tbox_Iban.Location = new System.Drawing.Point(109, 75);
            this.Tbox_Iban.MaxLength = 27;
            this.Tbox_Iban.Name = "Tbox_Iban";
            this.Tbox_Iban.Size = new System.Drawing.Size(305, 20);
            this.Tbox_Iban.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 120;
            this.label10.Text = "IBAN:";
            // 
            // Tbox_Banka
            // 
            this.Tbox_Banka.Enabled = false;
            this.Tbox_Banka.Location = new System.Drawing.Point(109, 47);
            this.Tbox_Banka.Name = "Tbox_Banka";
            this.Tbox_Banka.Size = new System.Drawing.Size(305, 20);
            this.Tbox_Banka.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 118;
            this.label11.Text = "Banka Adı ve Şube";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Enabled = false;
            this.btnOlustur.Location = new System.Drawing.Point(12, 154);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(145, 42);
            this.btnOlustur.TabIndex = 124;
            this.btnOlustur.Text = "Harcama Talimatı Oluştur";
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // Harcama_Kurumu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(920, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Harcama_Kurumu";
            this.Text = "Harcama Kurumları Ekle";
            this.Load += new System.EventHandler(this.Harcama_Kurumu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPay)).EndInit();
            this.GboxKurumİnfo.ResumeLayout(false);
            this.GboxKurumİnfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Message;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGVPay;
        private System.Windows.Forms.GroupBox GboxKurumİnfo;
        private System.Windows.Forms.TextBox TboxUnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox TboxAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbox_kurum_tipi;
        private System.Windows.Forms.Label lbl_kurum_tipi;
        private System.Windows.Forms.TextBox Tbox_Kurum_No;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tbox_Kurum_Adı;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tbox_Iban;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tbox_Banka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOlustur;
    }
}