namespace Fatura_Kayıt_Sistemi
{
    partial class Kullanici_Yonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_Yonetim));
            this.DGV_main = new System.Windows.Forms.DataGridView();
            this.lbl_kullanici_list = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_Username = new System.Windows.Forms.TextBox();
            this.Tbox_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.Btn_Yeni_ky = new System.Windows.Forms.Button();
            this.OBS_Duzenleme = new System.Windows.Forms.CheckBox();
            this.OBS_Goruntuleme = new System.Windows.Forms.CheckBox();
            this.FKS_Add_Fatura = new System.Windows.Forms.CheckBox();
            this.FKS_Odeme = new System.Windows.Forms.CheckBox();
            this.FKS_Goruntuleme = new System.Windows.Forms.CheckBox();
            this.FKS_Duzenleme = new System.Windows.Forms.CheckBox();
            this.Yetkiler = new System.Windows.Forms.TabControl();
            this.OBS = new System.Windows.Forms.TabPage();
            this.FKS = new System.Windows.Forms.TabPage();
            this.Cbox_Numarator = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.Cbox_Unvan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbox_Yetki = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).BeginInit();
            this.Yetkiler.SuspendLayout();
            this.OBS.SuspendLayout();
            this.FKS.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_main
            // 
            this.DGV_main.AllowUserToAddRows = false;
            this.DGV_main.AllowUserToDeleteRows = false;
            this.DGV_main.AllowUserToResizeColumns = false;
            this.DGV_main.AllowUserToResizeRows = false;
            this.DGV_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_main.Location = new System.Drawing.Point(12, 28);
            this.DGV_main.MultiSelect = false;
            this.DGV_main.Name = "DGV_main";
            this.DGV_main.ReadOnly = true;
            this.DGV_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_main.Size = new System.Drawing.Size(244, 509);
            this.DGV_main.TabIndex = 0;
            this.DGV_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_main_CellDoubleClick);
            // 
            // lbl_kullanici_list
            // 
            this.lbl_kullanici_list.AutoSize = true;
            this.lbl_kullanici_list.Location = new System.Drawing.Point(12, 9);
            this.lbl_kullanici_list.Name = "lbl_kullanici_list";
            this.lbl_kullanici_list.Size = new System.Drawing.Size(78, 13);
            this.lbl_kullanici_list.TabIndex = 1;
            this.lbl_kullanici_list.Text = "Kullanıcı Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Tbox_Username
            // 
            this.Tbox_Username.Enabled = false;
            this.Tbox_Username.Location = new System.Drawing.Point(370, 21);
            this.Tbox_Username.Name = "Tbox_Username";
            this.Tbox_Username.Size = new System.Drawing.Size(153, 20);
            this.Tbox_Username.TabIndex = 3;
            // 
            // Tbox_Pass
            // 
            this.Tbox_Pass.Enabled = false;
            this.Tbox_Pass.Location = new System.Drawing.Point(370, 47);
            this.Tbox_Pass.Name = "Tbox_Pass";
            this.Tbox_Pass.PasswordChar = '*';
            this.Tbox_Pass.Size = new System.Drawing.Size(153, 20);
            this.Tbox_Pass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcının Yetkileri";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(271, 145);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(145, 42);
            this.btn_delete.TabIndex = 83;
            this.btn_delete.Text = "Kaydı Sil";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(271, 195);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(302, 43);
            this.btn_update.TabIndex = 84;
            this.btn_update.Text = "Güncelleme";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Btn_Yeni_ky
            // 
            this.Btn_Yeni_ky.Location = new System.Drawing.Point(424, 145);
            this.Btn_Yeni_ky.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Yeni_ky.Name = "Btn_Yeni_ky";
            this.Btn_Yeni_ky.Size = new System.Drawing.Size(149, 42);
            this.Btn_Yeni_ky.TabIndex = 85;
            this.Btn_Yeni_ky.Text = "Yeni Kayıt";
            this.Btn_Yeni_ky.Click += new System.EventHandler(this.Btn_Yeni_ky_Click);
            // 
            // OBS_Duzenleme
            // 
            this.OBS_Duzenleme.AutoSize = true;
            this.OBS_Duzenleme.Location = new System.Drawing.Point(13, 6);
            this.OBS_Duzenleme.Name = "OBS_Duzenleme";
            this.OBS_Duzenleme.Size = new System.Drawing.Size(113, 17);
            this.OBS_Duzenleme.TabIndex = 87;
            this.OBS_Duzenleme.Text = "Düzenleme [#001]";
            this.OBS_Duzenleme.UseVisualStyleBackColor = true;
            this.OBS_Duzenleme.CheckedChanged += new System.EventHandler(this.OBS_Duzenleme_CheckedChanged);
            // 
            // OBS_Goruntuleme
            // 
            this.OBS_Goruntuleme.AutoSize = true;
            this.OBS_Goruntuleme.Location = new System.Drawing.Point(13, 29);
            this.OBS_Goruntuleme.Name = "OBS_Goruntuleme";
            this.OBS_Goruntuleme.Size = new System.Drawing.Size(120, 17);
            this.OBS_Goruntuleme.TabIndex = 88;
            this.OBS_Goruntuleme.Text = "Görüntüleme [#002]";
            this.OBS_Goruntuleme.UseVisualStyleBackColor = true;
            this.OBS_Goruntuleme.CheckedChanged += new System.EventHandler(this.OBS_Goruntuleme_CheckedChanged);
            // 
            // FKS_Add_Fatura
            // 
            this.FKS_Add_Fatura.AutoSize = true;
            this.FKS_Add_Fatura.Location = new System.Drawing.Point(13, 52);
            this.FKS_Add_Fatura.Name = "FKS_Add_Fatura";
            this.FKS_Add_Fatura.Size = new System.Drawing.Size(128, 17);
            this.FKS_Add_Fatura.TabIndex = 89;
            this.FKS_Add_Fatura.Text = "Fatura Ekleme [#023]";
            this.FKS_Add_Fatura.UseVisualStyleBackColor = true;
            this.FKS_Add_Fatura.CheckedChanged += new System.EventHandler(this.FKS_Add_Fatura_CheckedChanged);
            // 
            // FKS_Odeme
            // 
            this.FKS_Odeme.AutoSize = true;
            this.FKS_Odeme.Location = new System.Drawing.Point(13, 75);
            this.FKS_Odeme.Name = "FKS_Odeme";
            this.FKS_Odeme.Size = new System.Drawing.Size(94, 17);
            this.FKS_Odeme.TabIndex = 90;
            this.FKS_Odeme.Text = "Ödeme [#024]";
            this.FKS_Odeme.UseVisualStyleBackColor = true;
            this.FKS_Odeme.CheckedChanged += new System.EventHandler(this.FKS_Odeme_CheckedChanged);
            // 
            // FKS_Goruntuleme
            // 
            this.FKS_Goruntuleme.AutoSize = true;
            this.FKS_Goruntuleme.Location = new System.Drawing.Point(13, 29);
            this.FKS_Goruntuleme.Name = "FKS_Goruntuleme";
            this.FKS_Goruntuleme.Size = new System.Drawing.Size(120, 17);
            this.FKS_Goruntuleme.TabIndex = 92;
            this.FKS_Goruntuleme.Text = "Görüntüleme [#022]";
            this.FKS_Goruntuleme.UseVisualStyleBackColor = true;
            this.FKS_Goruntuleme.CheckedChanged += new System.EventHandler(this.FKS_Goruntuleme_CheckedChanged);
            // 
            // FKS_Duzenleme
            // 
            this.FKS_Duzenleme.AutoSize = true;
            this.FKS_Duzenleme.Location = new System.Drawing.Point(13, 6);
            this.FKS_Duzenleme.Name = "FKS_Duzenleme";
            this.FKS_Duzenleme.Size = new System.Drawing.Size(114, 17);
            this.FKS_Duzenleme.TabIndex = 91;
            this.FKS_Duzenleme.Text = "Düzenleme {#021]";
            this.FKS_Duzenleme.UseVisualStyleBackColor = true;
            this.FKS_Duzenleme.CheckedChanged += new System.EventHandler(this.FKS_Duzenleme_CheckedChanged);
            // 
            // Yetkiler
            // 
            this.Yetkiler.Controls.Add(this.OBS);
            this.Yetkiler.Controls.Add(this.FKS);
            this.Yetkiler.Enabled = false;
            this.Yetkiler.Location = new System.Drawing.Point(271, 268);
            this.Yetkiler.Name = "Yetkiler";
            this.Yetkiler.SelectedIndex = 0;
            this.Yetkiler.Size = new System.Drawing.Size(230, 269);
            this.Yetkiler.TabIndex = 93;
            // 
            // OBS
            // 
            this.OBS.Controls.Add(this.OBS_Duzenleme);
            this.OBS.Controls.Add(this.OBS_Goruntuleme);
            this.OBS.Location = new System.Drawing.Point(4, 22);
            this.OBS.Name = "OBS";
            this.OBS.Padding = new System.Windows.Forms.Padding(3);
            this.OBS.Size = new System.Drawing.Size(222, 243);
            this.OBS.TabIndex = 0;
            this.OBS.Text = "Okul Bilgi Sistemi";
            this.OBS.ToolTipText = "Okul Bilgi Sistemi";
            this.OBS.UseVisualStyleBackColor = true;
            // 
            // FKS
            // 
            this.FKS.Controls.Add(this.Cbox_Numarator);
            this.FKS.Controls.Add(this.FKS_Duzenleme);
            this.FKS.Controls.Add(this.FKS_Goruntuleme);
            this.FKS.Controls.Add(this.FKS_Add_Fatura);
            this.FKS.Controls.Add(this.FKS_Odeme);
            this.FKS.Location = new System.Drawing.Point(4, 22);
            this.FKS.Name = "FKS";
            this.FKS.Padding = new System.Windows.Forms.Padding(3);
            this.FKS.Size = new System.Drawing.Size(222, 243);
            this.FKS.TabIndex = 1;
            this.FKS.Text = "Fatura Kayıt Sistemi";
            this.FKS.UseVisualStyleBackColor = true;
            // 
            // Cbox_Numarator
            // 
            this.Cbox_Numarator.AutoSize = true;
            this.Cbox_Numarator.Location = new System.Drawing.Point(13, 98);
            this.Cbox_Numarator.Name = "Cbox_Numarator";
            this.Cbox_Numarator.Size = new System.Drawing.Size(148, 17);
            this.Cbox_Numarator.TabIndex = 93;
            this.Cbox_Numarator.Text = "Numaratörler Sıfırla [#030]";
            this.Cbox_Numarator.UseVisualStyleBackColor = true;
            this.Cbox_Numarator.CheckedChanged += new System.EventHandler(this.Cbox_Numarator_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_Message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.TabIndex = 98;
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
            // Cbox_Unvan
            // 
            this.Cbox_Unvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Unvan.Enabled = false;
            this.Cbox_Unvan.FormattingEnabled = true;
            this.Cbox_Unvan.Items.AddRange(new object[] {
            "Memur",
            "VHKI",
            "Şube Müdürü",
            "Teknisyen"});
            this.Cbox_Unvan.Location = new System.Drawing.Point(370, 73);
            this.Cbox_Unvan.Name = "Cbox_Unvan";
            this.Cbox_Unvan.Size = new System.Drawing.Size(153, 21);
            this.Cbox_Unvan.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(319, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 100;
            this.label5.Text = "Ünvan:";
            // 
            // Cbox_Yetki
            // 
            this.Cbox_Yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Yetki.Enabled = false;
            this.Cbox_Yetki.FormattingEnabled = true;
            this.Cbox_Yetki.Items.AddRange(new object[] {
            "Kullanıcı",
            "Admin"});
            this.Cbox_Yetki.Location = new System.Drawing.Point(370, 100);
            this.Cbox_Yetki.Name = "Cbox_Yetki";
            this.Cbox_Yetki.Size = new System.Drawing.Size(153, 21);
            this.Cbox_Yetki.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(332, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Yetki";
            // 
            // Kullanici_Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 572);
            this.Controls.Add(this.Cbox_Yetki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbox_Unvan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Yetkiler);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.Btn_Yeni_ky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbox_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_kullanici_list);
            this.Controls.Add(this.DGV_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanici_Yonetim";
            this.Text = "Kullanıcı Yönetim Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kullanici_Yonetim_FormClosing);
            this.Load += new System.EventHandler(this.Kullanici_Yonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).EndInit();
            this.Yetkiler.ResumeLayout(false);
            this.OBS.ResumeLayout(false);
            this.OBS.PerformLayout();
            this.FKS.ResumeLayout(false);
            this.FKS.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_main;
        private System.Windows.Forms.Label lbl_kullanici_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_Username;
        private System.Windows.Forms.TextBox Tbox_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button Btn_Yeni_ky;
        private System.Windows.Forms.CheckBox OBS_Duzenleme;
        private System.Windows.Forms.CheckBox OBS_Goruntuleme;
        private System.Windows.Forms.CheckBox FKS_Add_Fatura;
        private System.Windows.Forms.CheckBox FKS_Odeme;
        private System.Windows.Forms.CheckBox FKS_Goruntuleme;
        private System.Windows.Forms.CheckBox FKS_Duzenleme;
        private System.Windows.Forms.TabControl Yetkiler;
        private System.Windows.Forms.TabPage OBS;
        private System.Windows.Forms.TabPage FKS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Message;
        private System.Windows.Forms.ComboBox Cbox_Unvan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cbox_Yetki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Cbox_Numarator;
    }
}