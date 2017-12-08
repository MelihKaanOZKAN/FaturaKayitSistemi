namespace Fatura_Kayıt_Sistemi
{
    partial class MainForm_Fatura_Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_Fatura_Kayıt));
            this.Tbox_Okul_Adı = new System.Windows.Forms.TextBox();
            this.Lbl_O_Adı = new System.Windows.Forms.Label();
            this.Lbl_Okul_No = new System.Windows.Forms.Label();
            this.Tbox_Okul_No = new System.Windows.Forms.TextBox();
            this.Cbox_Okul_Türü = new System.Windows.Forms.ComboBox();
            this.Lbl_o_türü = new System.Windows.Forms.Label();
            this.Tbox_Ara_O_Adı = new System.Windows.Forms.TextBox();
            this.lbl_ara_isim = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.işlemiİptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Yeni_ky = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Gbox_Bilgi_Kullanıcı = new System.Windows.Forms.GroupBox();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harcamaTalimatıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harcamaKurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaydaBekleyenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_main = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainForm_Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVSubs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.Gbox_Bilgi_Kullanıcı.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.MainForm_Context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbox_Okul_Adı
            // 
            this.Tbox_Okul_Adı.Enabled = false;
            this.Tbox_Okul_Adı.Location = new System.Drawing.Point(89, 21);
            this.Tbox_Okul_Adı.Name = "Tbox_Okul_Adı";
            this.Tbox_Okul_Adı.Size = new System.Drawing.Size(212, 20);
            this.Tbox_Okul_Adı.TabIndex = 56;
            // 
            // Lbl_O_Adı
            // 
            this.Lbl_O_Adı.AutoSize = true;
            this.Lbl_O_Adı.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_O_Adı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_O_Adı.Location = new System.Drawing.Point(20, 24);
            this.Lbl_O_Adı.Name = "Lbl_O_Adı";
            this.Lbl_O_Adı.Size = new System.Drawing.Size(58, 13);
            this.Lbl_O_Adı.TabIndex = 57;
            this.Lbl_O_Adı.Text = "Kurum Adı:";
            // 
            // Lbl_Okul_No
            // 
            this.Lbl_Okul_No.AutoSize = true;
            this.Lbl_Okul_No.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Okul_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Okul_No.Location = new System.Drawing.Point(20, 54);
            this.Lbl_Okul_No.Name = "Lbl_Okul_No";
            this.Lbl_Okul_No.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Okul_No.TabIndex = 59;
            this.Lbl_Okul_No.Text = "Kurum Kodu:";
            // 
            // Tbox_Okul_No
            // 
            this.Tbox_Okul_No.Enabled = false;
            this.Tbox_Okul_No.Location = new System.Drawing.Point(89, 51);
            this.Tbox_Okul_No.Name = "Tbox_Okul_No";
            this.Tbox_Okul_No.Size = new System.Drawing.Size(212, 20);
            this.Tbox_Okul_No.TabIndex = 58;
            // 
            // Cbox_Okul_Türü
            // 
            this.Cbox_Okul_Türü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Okul_Türü.Enabled = false;
            this.Cbox_Okul_Türü.FormattingEnabled = true;
            this.Cbox_Okul_Türü.ItemHeight = 13;
            this.Cbox_Okul_Türü.Location = new System.Drawing.Point(89, 77);
            this.Cbox_Okul_Türü.Name = "Cbox_Okul_Türü";
            this.Cbox_Okul_Türü.Size = new System.Drawing.Size(212, 21);
            this.Cbox_Okul_Türü.TabIndex = 60;
            // 
            // Lbl_o_türü
            // 
            this.Lbl_o_türü.AutoSize = true;
            this.Lbl_o_türü.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_o_türü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_o_türü.Location = new System.Drawing.Point(20, 80);
            this.Lbl_o_türü.Name = "Lbl_o_türü";
            this.Lbl_o_türü.Size = new System.Drawing.Size(65, 13);
            this.Lbl_o_türü.TabIndex = 61;
            this.Lbl_o_türü.Text = "Kurum Türü:";
            // 
            // Tbox_Ara_O_Adı
            // 
            this.Tbox_Ara_O_Adı.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbox_Ara_O_Adı.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tbox_Ara_O_Adı.Location = new System.Drawing.Point(64, 26);
            this.Tbox_Ara_O_Adı.Margin = new System.Windows.Forms.Padding(4);
            this.Tbox_Ara_O_Adı.Name = "Tbox_Ara_O_Adı";
            this.Tbox_Ara_O_Adı.Size = new System.Drawing.Size(183, 20);
            this.Tbox_Ara_O_Adı.TabIndex = 74;
            this.Tbox_Ara_O_Adı.TextChanged += new System.EventHandler(this.Tbox_Ara_O_Adı_TextChanged);
            // 
            // lbl_ara_isim
            // 
            this.lbl_ara_isim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ara_isim.AutoSize = true;
            this.lbl_ara_isim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ara_isim.Location = new System.Drawing.Point(10, 29);
            this.lbl_ara_isim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ara_isim.Name = "lbl_ara_isim";
            this.lbl_ara_isim.Size = new System.Drawing.Size(50, 13);
            this.lbl_ara_isim.TabIndex = 75;
            this.lbl_ara_isim.Text = "Okul Adı:";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(541, 513);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(145, 42);
            this.btn_delete.TabIndex = 80;
            this.btn_delete.Text = "Kaydı Sil";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(541, 563);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(302, 43);
            this.btn_update.TabIndex = 81;
            this.btn_update.Text = "Güncelleme";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemiİptalEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // işlemiİptalEtToolStripMenuItem
            // 
            this.işlemiİptalEtToolStripMenuItem.Name = "işlemiİptalEtToolStripMenuItem";
            this.işlemiİptalEtToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.işlemiİptalEtToolStripMenuItem.Text = "İşlemi İptal Et";
            this.işlemiİptalEtToolStripMenuItem.Click += new System.EventHandler(this.işlemiİptalEtToolStripMenuItem_Click);
            // 
            // Btn_Yeni_ky
            // 
            this.Btn_Yeni_ky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Yeni_ky.ContextMenuStrip = this.contextMenuStrip1;
            this.Btn_Yeni_ky.Enabled = false;
            this.Btn_Yeni_ky.Location = new System.Drawing.Point(694, 513);
            this.Btn_Yeni_ky.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Yeni_ky.Name = "Btn_Yeni_ky";
            this.Btn_Yeni_ky.Size = new System.Drawing.Size(149, 42);
            this.Btn_Yeni_ky.TabIndex = 82;
            this.Btn_Yeni_ky.Text = "Yeni Kayıt";
            this.Btn_Yeni_ky.Click += new System.EventHandler(this.Btn_Yeni_ky_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_welcome.Location = new System.Drawing.Point(13, 16);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(35, 13);
            this.lbl_welcome.TabIndex = 84;
            this.lbl_welcome.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Giriş Tarihi:";
            // 
            // Gbox_Bilgi_Kullanıcı
            // 
            this.Gbox_Bilgi_Kullanıcı.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbox_Bilgi_Kullanıcı.Controls.Add(this.lblLoginTime);
            this.Gbox_Bilgi_Kullanıcı.Controls.Add(this.label8);
            this.Gbox_Bilgi_Kullanıcı.Controls.Add(this.lbl_welcome);
            this.Gbox_Bilgi_Kullanıcı.Location = new System.Drawing.Point(542, 42);
            this.Gbox_Bilgi_Kullanıcı.Name = "Gbox_Bilgi_Kullanıcı";
            this.Gbox_Bilgi_Kullanıcı.Size = new System.Drawing.Size(313, 67);
            this.Gbox_Bilgi_Kullanıcı.TabIndex = 87;
            this.Gbox_Bilgi_Kullanıcı.TabStop = false;
            this.Gbox_Bilgi_Kullanıcı.Text = "Kullanıcı Bilgileri";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = true;
            this.lblLoginTime.Location = new System.Drawing.Point(77, 39);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(35, 13);
            this.lblLoginTime.TabIndex = 86;
            this.lblLoginTime.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaToolStripMenuItem,
            this.harcamaTalimatıToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.yönetimPaneliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 96;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaEkleToolStripMenuItem,
            this.faturaSorgulamaToolStripMenuItem});
            this.faturaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // faturaEkleToolStripMenuItem
            // 
            this.faturaEkleToolStripMenuItem.Enabled = false;
            this.faturaEkleToolStripMenuItem.Name = "faturaEkleToolStripMenuItem";
            this.faturaEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.faturaEkleToolStripMenuItem.Text = "Fatura Ekle";
            this.faturaEkleToolStripMenuItem.Click += new System.EventHandler(this.faturaEkleToolStripMenuItem_Click);
            // 
            // faturaSorgulamaToolStripMenuItem
            // 
            this.faturaSorgulamaToolStripMenuItem.Enabled = false;
            this.faturaSorgulamaToolStripMenuItem.Name = "faturaSorgulamaToolStripMenuItem";
            this.faturaSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.faturaSorgulamaToolStripMenuItem.Text = "Fatura Sorgulama";
            this.faturaSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.faturaDökümüAlToolStripMenuItem_Click);
            // 
            // harcamaTalimatıToolStripMenuItem
            // 
            this.harcamaTalimatıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oluşturToolStripMenuItem,
            this.harcamaKurumuToolStripMenuItem});
            this.harcamaTalimatıToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harcamaTalimatıToolStripMenuItem.Name = "harcamaTalimatıToolStripMenuItem";
            this.harcamaTalimatıToolStripMenuItem.Size = new System.Drawing.Size(130, 21);
            this.harcamaTalimatıToolStripMenuItem.Text = "Harcama Talimatı";
            this.harcamaTalimatıToolStripMenuItem.Visible = false;
            // 
            // oluşturToolStripMenuItem
            // 
            this.oluşturToolStripMenuItem.Name = "oluşturToolStripMenuItem";
            this.oluşturToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.oluşturToolStripMenuItem.Text = "Oluştur";
            this.oluşturToolStripMenuItem.Click += new System.EventHandler(this.oluşturToolStripMenuItem_Click);
            // 
            // harcamaKurumuToolStripMenuItem
            // 
            this.harcamaKurumuToolStripMenuItem.Name = "harcamaKurumuToolStripMenuItem";
            this.harcamaKurumuToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.harcamaKurumuToolStripMenuItem.Text = "Harcama Kurumları";
            this.harcamaKurumuToolStripMenuItem.Click += new System.EventHandler(this.harcamaKurumuToolStripMenuItem_Click);
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeSorgulamaToolStripMenuItem,
            this.onaydaBekleyenlerToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            this.ödemelerToolStripMenuItem.Visible = false;
            // 
            // ödemeSorgulamaToolStripMenuItem
            // 
            this.ödemeSorgulamaToolStripMenuItem.Name = "ödemeSorgulamaToolStripMenuItem";
            this.ödemeSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ödemeSorgulamaToolStripMenuItem.Text = "Ödeme Sorgulama";
            this.ödemeSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.ödemeSorgulamaToolStripMenuItem_Click);
            // 
            // onaydaBekleyenlerToolStripMenuItem
            // 
            this.onaydaBekleyenlerToolStripMenuItem.Name = "onaydaBekleyenlerToolStripMenuItem";
            this.onaydaBekleyenlerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.onaydaBekleyenlerToolStripMenuItem.Text = "Onayda Bekleyenler";
            this.onaydaBekleyenlerToolStripMenuItem.Click += new System.EventHandler(this.onaydaBekleyenlerToolStripMenuItem_Click);
            // 
            // yönetimPaneliToolStripMenuItem
            // 
            this.yönetimPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem});
            this.yönetimPaneliToolStripMenuItem.Name = "yönetimPaneliToolStripMenuItem";
            this.yönetimPaneliToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.yönetimPaneliToolStripMenuItem.Text = "Yönetim Paneli";
            this.yönetimPaneliToolStripMenuItem.Visible = false;
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.girişToolStripMenuItem.Text = "Giriş";
            this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
            // 
            // DGV_main
            // 
            this.DGV_main.AllowUserToAddRows = false;
            this.DGV_main.AllowUserToDeleteRows = false;
            this.DGV_main.AllowUserToResizeRows = false;
            this.DGV_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_main.Enabled = false;
            this.DGV_main.Location = new System.Drawing.Point(6, 53);
            this.DGV_main.MultiSelect = false;
            this.DGV_main.Name = "DGV_main";
            this.DGV_main.ReadOnly = true;
            this.DGV_main.RowTemplate.Height = 24;
            this.DGV_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_main.Size = new System.Drawing.Size(528, 523);
            this.DGV_main.TabIndex = 95;
            this.DGV_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_main_CellDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_Message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 97;
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
            // MainForm_Context
            // 
            this.MainForm_Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.MainForm_Context.Name = "MainForm_Context";
            this.MainForm_Context.Size = new System.Drawing.Size(106, 26);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // DGVSubs
            // 
            this.DGVSubs.AllowUserToAddRows = false;
            this.DGVSubs.AllowUserToDeleteRows = false;
            this.DGVSubs.AllowUserToResizeColumns = false;
            this.DGVSubs.AllowUserToResizeRows = false;
            this.DGVSubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSubs.ContextMenuStrip = this.contextMenuStrip2;
            this.DGVSubs.Location = new System.Drawing.Point(7, 19);
            this.DGVSubs.MultiSelect = false;
            this.DGVSubs.Name = "DGVSubs";
            this.DGVSubs.ReadOnly = true;
            this.DGVSubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSubs.Size = new System.Drawing.Size(306, 236);
            this.DGVSubs.TabIndex = 98;
            this.DGVSubs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSubs_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Lbl_o_türü);
            this.groupBox1.Controls.Add(this.Cbox_Okul_Türü);
            this.groupBox1.Controls.Add(this.Lbl_Okul_No);
            this.groupBox1.Controls.Add(this.Tbox_Okul_No);
            this.groupBox1.Controls.Add(this.Lbl_O_Adı);
            this.groupBox1.Controls.Add(this.Tbox_Okul_Adı);
            this.groupBox1.Location = new System.Drawing.Point(542, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 116);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurum Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.DGVSubs);
            this.groupBox2.Location = new System.Drawing.Point(542, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 269);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abonelikler:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtEkleToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(150, 26);
            // 
            // yeniKayıtEkleToolStripMenuItem
            // 
            this.yeniKayıtEkleToolStripMenuItem.Enabled = false;
            this.yeniKayıtEkleToolStripMenuItem.Name = "yeniKayıtEkleToolStripMenuItem";
            this.yeniKayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yeniKayıtEkleToolStripMenuItem.Text = "Yeni Kayıt Ekle";
            this.yeniKayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtEkleToolStripMenuItem_Click);
            // 
            // MainForm_Fatura_Kayıt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 637);
            this.ContextMenuStrip = this.MainForm_Context;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DGV_main);
            this.Controls.Add(this.Tbox_Ara_O_Adı);
            this.Controls.Add(this.lbl_ara_isim);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Gbox_Bilgi_Kullanıcı);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.Btn_Yeni_ky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm_Fatura_Kayıt";
            this.Text = "Ana Ekran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Gbox_Bilgi_Kullanıcı.ResumeLayout(false);
            this.Gbox_Bilgi_Kullanıcı.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_main)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainForm_Context.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tbox_Okul_Adı;
         private System.Windows.Forms.Label   Lbl_O_Adı;
         private System.Windows.Forms.Label   Lbl_Okul_No;
        private System.Windows.Forms.TextBox Tbox_Okul_No;
         private System.Windows.Forms.Label   Lbl_o_türü;
        private System.Windows.Forms.TextBox Tbox_Ara_O_Adı;
         private System.Windows.Forms.Label   lbl_ara_isim;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button Btn_Yeni_ky;
        public  System.Windows.Forms.Label   lbl_welcome;
         private System.Windows.Forms.Label   label8;
        private System.Windows.Forms.GroupBox Gbox_Bilgi_Kullanıcı;
        private System.Windows.Forms.ComboBox Cbox_Okul_Türü;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaSorgulamaToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV_main;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Message;
        private System.Windows.Forms.ToolStripMenuItem harcamaTalimatıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harcamaKurumuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemiİptalEtToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MainForm_Context;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVSubs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaydaBekleyenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtEkleToolStripMenuItem;
    }
}

