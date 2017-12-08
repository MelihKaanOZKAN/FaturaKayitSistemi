namespace Fatura_Kayıt_Sistemi
{
    partial class Login_Fatura_Kayit_Sistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Fatura_Kayit_Sistemi));
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Tbox_Username = new System.Windows.Forms.TextBox();
            this.Tbox_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modülSayfasınaDönToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Logo
            // 
            this.PB_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Logo.Location = new System.Drawing.Point(383, 23);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(568, 265);
            this.PB_Logo.TabIndex = 19;
            this.PB_Logo.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 497);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 409);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.Location = new System.Drawing.Point(635, 389);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(178, 39);
            this.btn_Login.TabIndex = 16;
            this.btn_Login.Text = "Giriş";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Tbox_Username
            // 
            this.Tbox_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbox_Username.BackColor = System.Drawing.SystemColors.Info;
            this.Tbox_Username.Location = new System.Drawing.Point(591, 310);
            this.Tbox_Username.Name = "Tbox_Username";
            this.Tbox_Username.Size = new System.Drawing.Size(242, 20);
            this.Tbox_Username.TabIndex = 17;
            // 
            // Tbox_Pass
            // 
            this.Tbox_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbox_Pass.BackColor = System.Drawing.SystemColors.Info;
            this.Tbox_Pass.Location = new System.Drawing.Point(591, 345);
            this.Tbox_Pass.Name = "Tbox_Pass";
            this.Tbox_Pass.PasswordChar = '•';
            this.Tbox_Pass.Size = new System.Drawing.Size(242, 20);
            this.Tbox_Pass.TabIndex = 18;
            this.Tbox_Pass.UseSystemPasswordChar = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Username.Location = new System.Drawing.Point(509, 312);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(76, 15);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Kullanıcı Adı:";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Pass.Location = new System.Drawing.Point(550, 345);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(35, 15);
            this.lbl_Pass.TabIndex = 0;
            this.lbl_Pass.Text = "Şifre:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modülSayfasınaDönToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 26);
            // 
            // modülSayfasınaDönToolStripMenuItem
            // 
            this.modülSayfasınaDönToolStripMenuItem.Name = "modülSayfasınaDönToolStripMenuItem";
            this.modülSayfasınaDönToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.modülSayfasınaDönToolStripMenuItem.Text = "Modül Sayfasına Dön";
            this.modülSayfasınaDönToolStripMenuItem.Click += new System.EventHandler(this.modülSayfasınaDönToolStripMenuItem_Click);
            // 
            // Login_Fatura_Kayit_Sistemi
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 497);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.Tbox_Pass);
            this.Controls.Add(this.Tbox_Username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Fatura_Kayit_Sistemi";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox Tbox_Username;
        private System.Windows.Forms.TextBox Tbox_Pass;
        private System.Windows.Forms.Label   lbl_Username;
        private System.Windows.Forms.Label   lbl_Pass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modülSayfasınaDönToolStripMenuItem;
    }
}