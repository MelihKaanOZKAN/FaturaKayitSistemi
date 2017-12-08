namespace Fatura_Kayıt_Sistemi
{
    partial class Fatura_Dokum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura_Dokum));
            this.Cbox_Fatura_Türü = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_Okul_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_F_D_Al = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbox_Top_Harcama = new System.Windows.Forms.TextBox();
            this.Tbox_Top_Tutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbox_Top_KDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_o_türü = new System.Windows.Forms.Label();
            this.Cbox_Okul_Türü = new System.Windows.Forms.ComboBox();
            this.CheckBox_Only_Notpay = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Only_Odenen = new System.Windows.Forms.CheckBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnSorgulama = new System.Windows.Forms.Button();
            this.DGV_main = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboxBillDateMounth = new System.Windows.Forms.ComboBox();
            this.comboxBillDateYear = new System.Windows.Forms.ComboBox();
            this.chBoxAllYear = new System.Windows.Forms.CheckBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.gBoxPayment = new System.Windows.Forms.GroupBox();
            this.dataSet4Payment1 = new Fatura_Kayıt_Sistemi.Data.DataSet4Payment();
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
            this.chkBoxCorrectData = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gBoxPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4Payment1)).BeginInit();
            this.gBoxFilter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbox_Fatura_Türü
            // 
            this.Cbox_Fatura_Türü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Fatura_Türü.FormattingEnabled = true;
            resources.ApplyResources(this.Cbox_Fatura_Türü, "Cbox_Fatura_Türü");
            this.Cbox_Fatura_Türü.Name = "Cbox_Fatura_Türü";
            this.Cbox_Fatura_Türü.SelectedValueChanged += new System.EventHandler(this.Cbox_Fatura_Türü_SelectedValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // Tbox_Okul_No
            // 
            resources.ApplyResources(this.Tbox_Okul_No, "Tbox_Okul_No");
            this.Tbox_Okul_No.Name = "Tbox_Okul_No";
            this.Tbox_Okul_No.TextChanged += new System.EventHandler(this.Tbox_Okul_No_TextChanged);
            this.Tbox_Okul_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbox_Okul_No_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            // 
            // Btn_F_D_Al
            // 
            resources.ApplyResources(this.Btn_F_D_Al, "Btn_F_D_Al");
            this.Btn_F_D_Al.Name = "Btn_F_D_Al";
            this.Btn_F_D_Al.Click += new System.EventHandler(this.Btn_F_D_Al_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Name = "label5";
            // 
            // Tbox_Top_Harcama
            // 
            resources.ApplyResources(this.Tbox_Top_Harcama, "Tbox_Top_Harcama");
            this.Tbox_Top_Harcama.Name = "Tbox_Top_Harcama";
            // 
            // Tbox_Top_Tutar
            // 
            resources.ApplyResources(this.Tbox_Top_Tutar, "Tbox_Top_Tutar");
            this.Tbox_Top_Tutar.Name = "Tbox_Top_Tutar";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Name = "label6";
            // 
            // Tbox_Top_KDV
            // 
            resources.ApplyResources(this.Tbox_Top_KDV, "Tbox_Top_KDV");
            this.Tbox_Top_KDV.Name = "Tbox_Top_KDV";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Name = "label7";
            // 
            // Lbl_o_türü
            // 
            resources.ApplyResources(this.Lbl_o_türü, "Lbl_o_türü");
            this.Lbl_o_türü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_o_türü.Name = "Lbl_o_türü";
            // 
            // Cbox_Okul_Türü
            // 
            this.Cbox_Okul_Türü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Okul_Türü.FormattingEnabled = true;
            resources.ApplyResources(this.Cbox_Okul_Türü, "Cbox_Okul_Türü");
            this.Cbox_Okul_Türü.Name = "Cbox_Okul_Türü";
            this.Cbox_Okul_Türü.SelectedValueChanged += new System.EventHandler(this.Cbox_Okul_Türü_SelectedValueChanged);
            // 
            // CheckBox_Only_Notpay
            // 
            resources.ApplyResources(this.CheckBox_Only_Notpay, "CheckBox_Only_Notpay");
            this.CheckBox_Only_Notpay.Name = "CheckBox_Only_Notpay";
            this.CheckBox_Only_Notpay.UseVisualStyleBackColor = true;
            this.CheckBox_Only_Notpay.CheckedChanged += new System.EventHandler(this.CheckBox_Only_Notpay_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.Btn_F_D_Al);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBox_Only_Odenen
            // 
            resources.ApplyResources(this.checkBox_Only_Odenen, "checkBox_Only_Odenen");
            this.checkBox_Only_Odenen.Name = "checkBox_Only_Odenen";
            this.checkBox_Only_Odenen.UseVisualStyleBackColor = true;
            this.checkBox_Only_Odenen.CheckedChanged += new System.EventHandler(this.checkBox_Only_Odenen_CheckedChanged);
            // 
            // btnSorgula
            // 
            resources.ApplyResources(this.btnSorgula, "btnSorgula");
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnSorgulama
            // 
            resources.ApplyResources(this.btnSorgulama, "btnSorgulama");
            this.btnSorgulama.Name = "btnSorgulama";
            this.btnSorgulama.UseVisualStyleBackColor = true;
            this.btnSorgulama.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // DGV_main
            // 
            this.DGV_main.AllowUserToAddRows = false;
            this.DGV_main.AllowUserToDeleteRows = false;
            this.DGV_main.AllowUserToResizeRows = false;
            resources.ApplyResources(this.DGV_main, "DGV_main");
            this.DGV_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_main.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_main.Name = "DGV_main";
            this.DGV_main.ReadOnly = true;
            this.DGV_main.RowTemplate.Height = 24;
            this.DGV_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_main_CellClick);
            this.DGV_main.SelectionChanged += new System.EventHandler(this.DGV_main_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // düzenleToolStripMenuItem
            // 
            resources.ApplyResources(this.düzenleToolStripMenuItem, "düzenleToolStripMenuItem");
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // comboxBillDateMounth
            // 
            this.comboxBillDateMounth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBillDateMounth.FormattingEnabled = true;
            this.comboxBillDateMounth.Items.AddRange(new object[] {
            resources.GetString("comboxBillDateMounth.Items"),
            resources.GetString("comboxBillDateMounth.Items1"),
            resources.GetString("comboxBillDateMounth.Items2"),
            resources.GetString("comboxBillDateMounth.Items3"),
            resources.GetString("comboxBillDateMounth.Items4"),
            resources.GetString("comboxBillDateMounth.Items5"),
            resources.GetString("comboxBillDateMounth.Items6"),
            resources.GetString("comboxBillDateMounth.Items7"),
            resources.GetString("comboxBillDateMounth.Items8"),
            resources.GetString("comboxBillDateMounth.Items9"),
            resources.GetString("comboxBillDateMounth.Items10"),
            resources.GetString("comboxBillDateMounth.Items11")});
            resources.ApplyResources(this.comboxBillDateMounth, "comboxBillDateMounth");
            this.comboxBillDateMounth.Name = "comboxBillDateMounth";
            // 
            // comboxBillDateYear
            // 
            this.comboxBillDateYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBillDateYear.FormattingEnabled = true;
            this.comboxBillDateYear.Items.AddRange(new object[] {
            resources.GetString("comboxBillDateYear.Items"),
            resources.GetString("comboxBillDateYear.Items1"),
            resources.GetString("comboxBillDateYear.Items2"),
            resources.GetString("comboxBillDateYear.Items3"),
            resources.GetString("comboxBillDateYear.Items4"),
            resources.GetString("comboxBillDateYear.Items5"),
            resources.GetString("comboxBillDateYear.Items6"),
            resources.GetString("comboxBillDateYear.Items7"),
            resources.GetString("comboxBillDateYear.Items8")});
            resources.ApplyResources(this.comboxBillDateYear, "comboxBillDateYear");
            this.comboxBillDateYear.Name = "comboxBillDateYear";
            // 
            // chBoxAllYear
            // 
            resources.ApplyResources(this.chBoxAllYear, "chBoxAllYear");
            this.chBoxAllYear.Name = "chBoxAllYear";
            this.chBoxAllYear.UseVisualStyleBackColor = true;
            this.chBoxAllYear.CheckedChanged += new System.EventHandler(this.chBoxAllYear_CheckedChanged);
            // 
            // btnPayment
            // 
            resources.ApplyResources(this.btnPayment, "btnPayment");
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // gBoxPayment
            // 
            resources.ApplyResources(this.gBoxPayment, "gBoxPayment");
            this.gBoxPayment.Controls.Add(this.btnPayment);
            this.gBoxPayment.Name = "gBoxPayment";
            this.gBoxPayment.TabStop = false;
            // 
            // dataSet4Payment1
            // 
            this.dataSet4Payment1.DataSetName = "DataSet4Payment";
            this.dataSet4Payment1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Controls.Add(this.chkBoxCorrectData);
            this.gBoxFilter.Controls.Add(this.chBoxAllYear);
            this.gBoxFilter.Controls.Add(this.comboxBillDateYear);
            this.gBoxFilter.Controls.Add(this.comboxBillDateMounth);
            this.gBoxFilter.Controls.Add(this.btnSorgulama);
            this.gBoxFilter.Controls.Add(this.checkBox_Only_Odenen);
            this.gBoxFilter.Controls.Add(this.CheckBox_Only_Notpay);
            this.gBoxFilter.Controls.Add(this.Lbl_o_türü);
            this.gBoxFilter.Controls.Add(this.Cbox_Okul_Türü);
            this.gBoxFilter.Controls.Add(this.label3);
            this.gBoxFilter.Controls.Add(this.label2);
            this.gBoxFilter.Controls.Add(this.Tbox_Okul_No);
            this.gBoxFilter.Controls.Add(this.Cbox_Fatura_Türü);
            this.gBoxFilter.Controls.Add(this.label1);
            resources.ApplyResources(this.gBoxFilter, "gBoxFilter");
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.TabStop = false;
            // 
            // chkBoxCorrectData
            // 
            resources.ApplyResources(this.chkBoxCorrectData, "chkBoxCorrectData");
            this.chkBoxCorrectData.Name = "chkBoxCorrectData";
            this.chkBoxCorrectData.UseVisualStyleBackColor = true;
            this.chkBoxCorrectData.CheckedChanged += new System.EventHandler(this.chkBoxCorrectData_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tbox_Top_KDV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Tbox_Top_Tutar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Tbox_Top_Harcama);
            this.groupBox2.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // checkBoxSelectAll
            // 
            resources.ApplyResources(this.checkBoxSelectAll, "checkBoxSelectAll");
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // Fatura_Dokum
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxFilter);
            this.Controls.Add(this.gBoxPayment);
            this.Controls.Add(this.DGV_main);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fatura_Dokum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fatura_Dokum_FormClosing);
            this.Load += new System.EventHandler(this.Fatura_Dokum_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gBoxPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4Payment1)).EndInit();
            this.gBoxFilter.ResumeLayout(false);
            this.gBoxFilter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       private System.Windows.Forms.Label  label1;
       private System.Windows.Forms.Label  label2;
       private System.Windows.Forms.Label  label3;
        private System.Windows.Forms.Button Btn_F_D_Al;
       private System.Windows.Forms.Label  label5;
        private System.Windows.Forms.TextBox Tbox_Top_Harcama;
        private System.Windows.Forms.TextBox Tbox_Top_Tutar;
       private System.Windows.Forms.Label  label6;
        private System.Windows.Forms.TextBox Tbox_Top_KDV;
       private System.Windows.Forms.Label  label7;
       private System.Windows.Forms.Label  Lbl_o_türü;
        private System.Windows.Forms.CheckBox CheckBox_Only_Notpay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Only_Odenen;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.ComboBox Cbox_Fatura_Türü;
        private System.Windows.Forms.ComboBox Cbox_Okul_Türü;
        private System.Windows.Forms.Button btnSorgulama;
        private System.Windows.Forms.DataGridView DGV_main;
        private System.Windows.Forms.ComboBox comboxBillDateMounth;
        private System.Windows.Forms.ComboBox comboxBillDateYear;
        private System.Windows.Forms.CheckBox chBoxAllYear;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.GroupBox gBoxPayment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private Data.DataSet4Payment dataSet4Payment1;
        private System.Windows.Forms.GroupBox gBoxFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        internal System.Windows.Forms.TextBox Tbox_Okul_No;
        private System.Windows.Forms.CheckBox chkBoxCorrectData;
    }
}