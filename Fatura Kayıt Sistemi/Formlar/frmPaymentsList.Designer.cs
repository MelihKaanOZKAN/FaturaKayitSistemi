namespace Fatura_Kayıt_Sistemi.Formlar
{
    partial class frmPaymentsList
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
            this.components = new System.ComponentModel.Container();
            this.grpToplam = new System.Windows.Forms.GroupBox();
            this.Tbox_Top_KDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tbox_Top_Tutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbox_Top_Harcama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chBoxAllYear = new System.Windows.Forms.CheckBox();
            this.comboxBillDateYear = new System.Windows.Forms.ComboBox();
            this.comboxBillDateMounth = new System.Windows.Forms.ComboBox();
            this.btnSorgulama = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbox_Fatura_Türü = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_main = new System.Windows.Forms.DataGridView();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_F_D_Al = new System.Windows.Forms.Button();
            this.grpRapor = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.grpToplam.SuspendLayout();
            this.gBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpToplam
            // 
            this.grpToplam.Controls.Add(this.Tbox_Top_KDV);
            this.grpToplam.Controls.Add(this.label7);
            this.grpToplam.Controls.Add(this.Tbox_Top_Tutar);
            this.grpToplam.Controls.Add(this.label6);
            this.grpToplam.Controls.Add(this.Tbox_Top_Harcama);
            this.grpToplam.Controls.Add(this.label5);
            this.grpToplam.Location = new System.Drawing.Point(604, 3);
            this.grpToplam.Name = "grpToplam";
            this.grpToplam.Size = new System.Drawing.Size(300, 104);
            this.grpToplam.TabIndex = 110;
            this.grpToplam.TabStop = false;
            this.grpToplam.Text = "Toplamlar:";
            // 
            // Tbox_Top_KDV
            // 
            this.Tbox_Top_KDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbox_Top_KDV.Enabled = false;
            this.Tbox_Top_KDV.Location = new System.Drawing.Point(106, 73);
            this.Tbox_Top_KDV.Name = "Tbox_Top_KDV";
            this.Tbox_Top_KDV.Size = new System.Drawing.Size(177, 20);
            this.Tbox_Top_KDV.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(30, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Toplam KDV:";
            // 
            // Tbox_Top_Tutar
            // 
            this.Tbox_Top_Tutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbox_Top_Tutar.Enabled = false;
            this.Tbox_Top_Tutar.Location = new System.Drawing.Point(106, 45);
            this.Tbox_Top_Tutar.Name = "Tbox_Top_Tutar";
            this.Tbox_Top_Tutar.Size = new System.Drawing.Size(177, 20);
            this.Tbox_Top_Tutar.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(27, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Toplam Tutar:";
            // 
            // Tbox_Top_Harcama
            // 
            this.Tbox_Top_Harcama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbox_Top_Harcama.Enabled = false;
            this.Tbox_Top_Harcama.Location = new System.Drawing.Point(106, 17);
            this.Tbox_Top_Harcama.Name = "Tbox_Top_Harcama";
            this.Tbox_Top_Harcama.Size = new System.Drawing.Size(177, 20);
            this.Tbox_Top_Harcama.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Toplam Harcama:";
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Controls.Add(this.cBoxStatus);
            this.gBoxFilter.Controls.Add(this.label4);
            this.gBoxFilter.Controls.Add(this.txtPayNo);
            this.gBoxFilter.Controls.Add(this.label2);
            this.gBoxFilter.Controls.Add(this.chBoxAllYear);
            this.gBoxFilter.Controls.Add(this.comboxBillDateYear);
            this.gBoxFilter.Controls.Add(this.comboxBillDateMounth);
            this.gBoxFilter.Controls.Add(this.btnSorgulama);
            this.gBoxFilter.Controls.Add(this.label3);
            this.gBoxFilter.Controls.Add(this.Cbox_Fatura_Türü);
            this.gBoxFilter.Controls.Add(this.label1);
            this.gBoxFilter.Location = new System.Drawing.Point(8, 3);
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.Size = new System.Drawing.Size(590, 142);
            this.gBoxFilter.TabIndex = 109;
            this.gBoxFilter.TabStop = false;
            this.gBoxFilter.Text = "Filtre";
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "0 - Düzeltme Bekliyor",
            "1- Onay Bekliyor",
            "2 - Onaylandı",
            "3- Ödeme Emri Gönderildi",
            "4 - Muhasebeleşti"});
            this.cBoxStatus.Location = new System.Drawing.Point(96, 78);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(186, 21);
            this.cBoxStatus.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Ödeme Durumu:";
            // 
            // txtPayNo
            // 
            this.txtPayNo.Location = new System.Drawing.Point(96, 52);
            this.txtPayNo.Name = "txtPayNo";
            this.txtPayNo.Size = new System.Drawing.Size(148, 20);
            this.txtPayNo.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Ödeme Numarası:";
            // 
            // chBoxAllYear
            // 
            this.chBoxAllYear.AutoSize = true;
            this.chBoxAllYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chBoxAllYear.Location = new System.Drawing.Point(301, 110);
            this.chBoxAllYear.Name = "chBoxAllYear";
            this.chBoxAllYear.Size = new System.Drawing.Size(88, 17);
            this.chBoxAllYear.TabIndex = 99;
            this.chBoxAllYear.Text = "Tüm Yılı Getir";
            this.chBoxAllYear.UseVisualStyleBackColor = true;
            // 
            // comboxBillDateYear
            // 
            this.comboxBillDateYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBillDateYear.FormattingEnabled = true;
            this.comboxBillDateYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboxBillDateYear.Location = new System.Drawing.Point(197, 105);
            this.comboxBillDateYear.Name = "comboxBillDateYear";
            this.comboxBillDateYear.Size = new System.Drawing.Size(85, 21);
            this.comboxBillDateYear.TabIndex = 98;
            // 
            // comboxBillDateMounth
            // 
            this.comboxBillDateMounth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBillDateMounth.FormattingEnabled = true;
            this.comboxBillDateMounth.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.comboxBillDateMounth.Location = new System.Drawing.Point(95, 105);
            this.comboxBillDateMounth.Name = "comboxBillDateMounth";
            this.comboxBillDateMounth.Size = new System.Drawing.Size(85, 21);
            this.comboxBillDateMounth.TabIndex = 97;
            // 
            // btnSorgulama
            // 
            this.btnSorgulama.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSorgulama.Location = new System.Drawing.Point(434, 22);
            this.btnSorgulama.Name = "btnSorgulama";
            this.btnSorgulama.Size = new System.Drawing.Size(112, 64);
            this.btnSorgulama.TabIndex = 83;
            this.btnSorgulama.Text = "Sorgula";
            this.btnSorgulama.UseVisualStyleBackColor = true;
            this.btnSorgulama.Click += new System.EventHandler(this.btnSorgulama_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ödeme Tarihi:";
            // 
            // Cbox_Fatura_Türü
            // 
            this.Cbox_Fatura_Türü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Fatura_Türü.FormattingEnabled = true;
            this.Cbox_Fatura_Türü.ItemHeight = 13;
            this.Cbox_Fatura_Türü.Location = new System.Drawing.Point(96, 25);
            this.Cbox_Fatura_Türü.Name = "Cbox_Fatura_Türü";
            this.Cbox_Fatura_Türü.Size = new System.Drawing.Size(305, 21);
            this.Cbox_Fatura_Türü.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Ödeme Türü:";
            // 
            // DGV_main
            // 
            this.DGV_main.AllowUserToAddRows = false;
            this.DGV_main.AllowUserToDeleteRows = false;
            this.DGV_main.AllowUserToResizeRows = false;
            this.DGV_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_main.Location = new System.Drawing.Point(8, 160);
            this.DGV_main.Name = "DGV_main";
            this.DGV_main.ReadOnly = true;
            this.DGV_main.RowTemplate.Height = 24;
            this.DGV_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_main.Size = new System.Drawing.Size(1100, 529);
            this.DGV_main.TabIndex = 107;
            this.DGV_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_main_CellDoubleClick);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSorgula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSorgula.Location = new System.Drawing.Point(1081, 14);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(140, 0);
            this.btnSorgula.TabIndex = 106;
            this.btnSorgula.Text = "Sorgula";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Btn_F_D_Al);
            this.groupBox1.Location = new System.Drawing.Point(1227, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 85);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor Servisi";
            // 
            // Btn_F_D_Al
            // 
            this.Btn_F_D_Al.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_F_D_Al.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_F_D_Al.Location = new System.Drawing.Point(16, 24);
            this.Btn_F_D_Al.Name = "Btn_F_D_Al";
            this.Btn_F_D_Al.Size = new System.Drawing.Size(162, 45);
            this.Btn_F_D_Al.TabIndex = 65;
            this.Btn_F_D_Al.Text = "Rapor Servisine Git";
            // 
            // grpRapor
            // 
            this.grpRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRapor.Controls.Add(this.button1);
            this.grpRapor.Location = new System.Drawing.Point(913, 3);
            this.grpRapor.Name = "grpRapor";
            this.grpRapor.Size = new System.Drawing.Size(195, 85);
            this.grpRapor.TabIndex = 111;
            this.grpRapor.TabStop = false;
            this.grpRapor.Text = "Rapor Servisi";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(16, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 65;
            this.button1.Text = "Rapor Servisine Git";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // frmPaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 701);
            this.Controls.Add(this.grpRapor);
            this.Controls.Add(this.grpToplam);
            this.Controls.Add(this.gBoxFilter);
            this.Controls.Add(this.DGV_main);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPaymentsList";
            this.Text = "Ödeme Sorgulama";
            this.Load += new System.EventHandler(this.frmPaymentsList_Load);
            this.grpToplam.ResumeLayout(false);
            this.grpToplam.PerformLayout();
            this.gBoxFilter.ResumeLayout(false);
            this.gBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpRapor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpToplam;
        private System.Windows.Forms.TextBox Tbox_Top_KDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tbox_Top_Tutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tbox_Top_Harcama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gBoxFilter;
        private System.Windows.Forms.CheckBox chBoxAllYear;
        private System.Windows.Forms.ComboBox comboxBillDateYear;
        private System.Windows.Forms.ComboBox comboxBillDateMounth;
        private System.Windows.Forms.Button btnSorgulama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbox_Fatura_Türü;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_main;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_F_D_Al;
        private System.Windows.Forms.GroupBox grpRapor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPayNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerRefresh;
    }
}