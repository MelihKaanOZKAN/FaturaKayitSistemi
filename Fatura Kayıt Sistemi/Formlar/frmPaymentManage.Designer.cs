namespace Fatura_Kayıt_Sistemi.Formlar
{
    partial class frmPaymentManage
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
            System.Windows.Forms.Label paymentIdLabel;
            System.Windows.Forms.Label subTypeIdLabel;
            System.Windows.Forms.Label paymentDateLabel;
            System.Windows.Forms.Label paymentConfirmDateLabel;
            System.Windows.Forms.Label paymentAmountLabel;
            System.Windows.Forms.Label paymentTaxLabel;
            System.Windows.Forms.Label paymentConsumptionLabel;
            System.Windows.Forms.Label paymentConfirmPersonLabel;
            System.Windows.Forms.Label orderOfPaymentNumberLabel;
            System.Windows.Forms.Label orderOfPaymentConfirmDateLabel;
            System.Windows.Forms.Label paymentStatusLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.dataSet4Payment = new Fatura_Kayıt_Sistemi.Data.DataSet4Payment();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Fatura_Kayıt_Sistemi.Data.DataSet4PaymentTableAdapters.PaymentsTableAdapter();
            this.tableAdapterManager = new Fatura_Kayıt_Sistemi.Data.DataSet4PaymentTableAdapters.TableAdapterManager();
            this.paymentIdTextBox = new System.Windows.Forms.TextBox();
            this.subTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentConfirmDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentAmountTextBox = new System.Windows.Forms.TextBox();
            this.paymentTaxTextBox = new System.Windows.Forms.TextBox();
            this.paymentConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.paymentConfirmPersonComboBox = new System.Windows.Forms.ComboBox();
            this.orderOfPaymentNumberTextBox = new System.Windows.Forms.TextBox();
            this.orderOfPaymentConfirmDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gBoxPaymentInfo = new System.Windows.Forms.GroupBox();
            this.txtSchoolType = new System.Windows.Forms.TextBox();
            this.paymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.gBoxConfirmPerson = new System.Windows.Forms.GroupBox();
            this.gBoxOrder = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.txtDeny = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowBills = new System.Windows.Forms.Button();
            this.gBoxConfirm = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHarcamatalimatı = new System.Windows.Forms.Button();
            this.comboBoxCreatorPerson = new System.Windows.Forms.ComboBox();
            paymentIdLabel = new System.Windows.Forms.Label();
            subTypeIdLabel = new System.Windows.Forms.Label();
            paymentDateLabel = new System.Windows.Forms.Label();
            paymentConfirmDateLabel = new System.Windows.Forms.Label();
            paymentAmountLabel = new System.Windows.Forms.Label();
            paymentTaxLabel = new System.Windows.Forms.Label();
            paymentConsumptionLabel = new System.Windows.Forms.Label();
            paymentConfirmPersonLabel = new System.Windows.Forms.Label();
            orderOfPaymentNumberLabel = new System.Windows.Forms.Label();
            orderOfPaymentConfirmDateLabel = new System.Windows.Forms.Label();
            paymentStatusLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4Payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.gBoxPaymentInfo.SuspendLayout();
            this.gBoxConfirmPerson.SuspendLayout();
            this.gBoxOrder.SuspendLayout();
            this.gBoxConfirm.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentIdLabel
            // 
            paymentIdLabel.AutoSize = true;
            paymentIdLabel.Location = new System.Drawing.Point(27, 22);
            paymentIdLabel.Name = "paymentIdLabel";
            paymentIdLabel.Size = new System.Drawing.Size(61, 13);
            paymentIdLabel.TabIndex = 0;
            paymentIdLabel.Text = "Ödeme Nu:";
            // 
            // subTypeIdLabel
            // 
            subTypeIdLabel.AutoSize = true;
            subTypeIdLabel.Location = new System.Drawing.Point(23, 48);
            subTypeIdLabel.Name = "subTypeIdLabel";
            subTypeIdLabel.Size = new System.Drawing.Size(65, 13);
            subTypeIdLabel.TabIndex = 2;
            subTypeIdLabel.Text = "Fatura Türü:";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.Location = new System.Drawing.Point(14, 101);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(73, 13);
            paymentDateLabel.TabIndex = 4;
            paymentDateLabel.Text = "Ödeme Tarihi:";
            // 
            // paymentConfirmDateLabel
            // 
            paymentConfirmDateLabel.AutoSize = true;
            paymentConfirmDateLabel.Location = new System.Drawing.Point(16, 19);
            paymentConfirmDateLabel.Name = "paymentConfirmDateLabel";
            paymentConfirmDateLabel.Size = new System.Drawing.Size(64, 13);
            paymentConfirmDateLabel.TabIndex = 6;
            paymentConfirmDateLabel.Text = "Onay Tarihi:";
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.Location = new System.Drawing.Point(52, 124);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new System.Drawing.Size(35, 13);
            paymentAmountLabel.TabIndex = 8;
            paymentAmountLabel.Text = "Tutar:";
            // 
            // paymentTaxLabel
            // 
            paymentTaxLabel.AutoSize = true;
            paymentTaxLabel.Location = new System.Drawing.Point(52, 150);
            paymentTaxLabel.Name = "paymentTaxLabel";
            paymentTaxLabel.Size = new System.Drawing.Size(34, 13);
            paymentTaxLabel.TabIndex = 10;
            paymentTaxLabel.Text = "Vergi:";
            // 
            // paymentConsumptionLabel
            // 
            paymentConsumptionLabel.AutoSize = true;
            paymentConsumptionLabel.Location = new System.Drawing.Point(38, 176);
            paymentConsumptionLabel.Name = "paymentConsumptionLabel";
            paymentConsumptionLabel.Size = new System.Drawing.Size(48, 13);
            paymentConsumptionLabel.TabIndex = 12;
            paymentConsumptionLabel.Text = "Tüketim:";
            // 
            // paymentConfirmPersonLabel
            // 
            paymentConfirmPersonLabel.AutoSize = true;
            paymentConfirmPersonLabel.Location = new System.Drawing.Point(6, 74);
            paymentConfirmPersonLabel.Name = "paymentConfirmPersonLabel";
            paymentConfirmPersonLabel.Size = new System.Drawing.Size(79, 13);
            paymentConfirmPersonLabel.TabIndex = 14;
            paymentConfirmPersonLabel.Text = "Onaylayan Kişi:";
            // 
            // orderOfPaymentNumberLabel
            // 
            orderOfPaymentNumberLabel.AutoSize = true;
            orderOfPaymentNumberLabel.Location = new System.Drawing.Point(13, 42);
            orderOfPaymentNumberLabel.Name = "orderOfPaymentNumberLabel";
            orderOfPaymentNumberLabel.Size = new System.Drawing.Size(114, 13);
            orderOfPaymentNumberLabel.TabIndex = 16;
            orderOfPaymentNumberLabel.Text = "Ödeme Emri Numarası:";
            // 
            // orderOfPaymentConfirmDateLabel
            // 
            orderOfPaymentConfirmDateLabel.AutoSize = true;
            orderOfPaymentConfirmDateLabel.Location = new System.Drawing.Point(10, 71);
            orderOfPaymentConfirmDateLabel.Name = "orderOfPaymentConfirmDateLabel";
            orderOfPaymentConfirmDateLabel.Size = new System.Drawing.Size(116, 13);
            orderOfPaymentConfirmDateLabel.TabIndex = 18;
            orderOfPaymentConfirmDateLabel.Text = "Muhasebeleşme Tarihi:";
            // 
            // paymentStatusLabel
            // 
            paymentStatusLabel.AutoSize = true;
            paymentStatusLabel.Location = new System.Drawing.Point(3, 202);
            paymentStatusLabel.Name = "paymentStatusLabel";
            paymentStatusLabel.Size = new System.Drawing.Size(84, 13);
            paymentStatusLabel.TabIndex = 20;
            paymentStatusLabel.Text = "Ödeme Durumu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 13);
            label2.TabIndex = 106;
            label2.Text = "Kurum Türü:";
            // 
            // dataSet4Payment
            // 
            this.dataSet4Payment.DataSetName = "DataSet4Payment";
            this.dataSet4Payment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.dataSet4Payment;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillsTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Fatura_Kayıt_Sistemi.Data.DataSet4PaymentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentIdTextBox
            // 
            this.paymentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "PaymentId", true));
            this.paymentIdTextBox.Enabled = false;
            this.paymentIdTextBox.Location = new System.Drawing.Point(89, 19);
            this.paymentIdTextBox.Name = "paymentIdTextBox";
            this.paymentIdTextBox.Size = new System.Drawing.Size(171, 20);
            this.paymentIdTextBox.TabIndex = 1;
            // 
            // subTypeIdTextBox
            // 
            this.subTypeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "SubTypeId", true));
            this.subTypeIdTextBox.Enabled = false;
            this.subTypeIdTextBox.Location = new System.Drawing.Point(89, 45);
            this.subTypeIdTextBox.Name = "subTypeIdTextBox";
            this.subTypeIdTextBox.Size = new System.Drawing.Size(171, 20);
            this.subTypeIdTextBox.TabIndex = 3;
            // 
            // paymentDateDateTimePicker
            // 
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentsBindingSource, "PaymentDate", true));
            this.paymentDateDateTimePicker.Enabled = false;
            this.paymentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(88, 95);
            this.paymentDateDateTimePicker.Name = "paymentDateDateTimePicker";
            this.paymentDateDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.paymentDateDateTimePicker.TabIndex = 5;
            // 
            // paymentConfirmDateDateTimePicker
            // 
            this.paymentConfirmDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentsBindingSource, "PaymentConfirmDate", true));
            this.paymentConfirmDateDateTimePicker.Enabled = false;
            this.paymentConfirmDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentConfirmDateDateTimePicker.Location = new System.Drawing.Point(86, 16);
            this.paymentConfirmDateDateTimePicker.Name = "paymentConfirmDateDateTimePicker";
            this.paymentConfirmDateDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.paymentConfirmDateDateTimePicker.TabIndex = 7;
            // 
            // paymentAmountTextBox
            // 
            this.paymentAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "PaymentAmount", true));
            this.paymentAmountTextBox.Enabled = false;
            this.paymentAmountTextBox.Location = new System.Drawing.Point(88, 121);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(171, 20);
            this.paymentAmountTextBox.TabIndex = 9;
            // 
            // paymentTaxTextBox
            // 
            this.paymentTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "PaymentTax", true));
            this.paymentTaxTextBox.Enabled = false;
            this.paymentTaxTextBox.Location = new System.Drawing.Point(89, 147);
            this.paymentTaxTextBox.Name = "paymentTaxTextBox";
            this.paymentTaxTextBox.Size = new System.Drawing.Size(171, 20);
            this.paymentTaxTextBox.TabIndex = 11;
            // 
            // paymentConsumptionTextBox
            // 
            this.paymentConsumptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "PaymentConsumption", true));
            this.paymentConsumptionTextBox.Enabled = false;
            this.paymentConsumptionTextBox.Location = new System.Drawing.Point(88, 173);
            this.paymentConsumptionTextBox.Name = "paymentConsumptionTextBox";
            this.paymentConsumptionTextBox.Size = new System.Drawing.Size(171, 20);
            this.paymentConsumptionTextBox.TabIndex = 13;
            // 
            // paymentConfirmPersonComboBox
            // 
            this.paymentConfirmPersonComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "PaymentConfirmPerson", true));
            this.paymentConfirmPersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentConfirmPersonComboBox.FormattingEnabled = true;
            this.paymentConfirmPersonComboBox.Location = new System.Drawing.Point(86, 73);
            this.paymentConfirmPersonComboBox.Name = "paymentConfirmPersonComboBox";
            this.paymentConfirmPersonComboBox.Size = new System.Drawing.Size(201, 21);
            this.paymentConfirmPersonComboBox.TabIndex = 15;
            this.paymentConfirmPersonComboBox.SelectedValueChanged += new System.EventHandler(this.paymentConfirmPersonComboBox_SelectedValueChanged);
            // 
            // orderOfPaymentNumberTextBox
            // 
            this.orderOfPaymentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "OrderOfPaymentNumber", true));
            this.orderOfPaymentNumberTextBox.Location = new System.Drawing.Point(132, 39);
            this.orderOfPaymentNumberTextBox.Name = "orderOfPaymentNumberTextBox";
            this.orderOfPaymentNumberTextBox.Size = new System.Drawing.Size(221, 20);
            this.orderOfPaymentNumberTextBox.TabIndex = 17;
            // 
            // orderOfPaymentConfirmDateDateTimePicker
            // 
            this.orderOfPaymentConfirmDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentsBindingSource, "OrderOfPaymentConfirmDate", true));
            this.orderOfPaymentConfirmDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderOfPaymentConfirmDateDateTimePicker.Location = new System.Drawing.Point(132, 65);
            this.orderOfPaymentConfirmDateDateTimePicker.Name = "orderOfPaymentConfirmDateDateTimePicker";
            this.orderOfPaymentConfirmDateDateTimePicker.Size = new System.Drawing.Size(221, 20);
            this.orderOfPaymentConfirmDateDateTimePicker.TabIndex = 19;
            // 
            // gBoxPaymentInfo
            // 
            this.gBoxPaymentInfo.Controls.Add(label2);
            this.gBoxPaymentInfo.Controls.Add(this.txtSchoolType);
            this.gBoxPaymentInfo.Controls.Add(this.paymentStatusComboBox);
            this.gBoxPaymentInfo.Controls.Add(paymentStatusLabel);
            this.gBoxPaymentInfo.Controls.Add(paymentConsumptionLabel);
            this.gBoxPaymentInfo.Controls.Add(this.paymentConsumptionTextBox);
            this.gBoxPaymentInfo.Controls.Add(paymentTaxLabel);
            this.gBoxPaymentInfo.Controls.Add(this.paymentTaxTextBox);
            this.gBoxPaymentInfo.Controls.Add(paymentAmountLabel);
            this.gBoxPaymentInfo.Controls.Add(this.paymentAmountTextBox);
            this.gBoxPaymentInfo.Controls.Add(paymentDateLabel);
            this.gBoxPaymentInfo.Controls.Add(this.paymentDateDateTimePicker);
            this.gBoxPaymentInfo.Controls.Add(subTypeIdLabel);
            this.gBoxPaymentInfo.Controls.Add(this.subTypeIdTextBox);
            this.gBoxPaymentInfo.Controls.Add(paymentIdLabel);
            this.gBoxPaymentInfo.Controls.Add(this.paymentIdTextBox);
            this.gBoxPaymentInfo.Location = new System.Drawing.Point(3, 12);
            this.gBoxPaymentInfo.Name = "gBoxPaymentInfo";
            this.gBoxPaymentInfo.Size = new System.Drawing.Size(280, 226);
            this.gBoxPaymentInfo.TabIndex = 22;
            this.gBoxPaymentInfo.TabStop = false;
            this.gBoxPaymentInfo.Text = "Ödeme Bilgileri:";
            // 
            // txtSchoolType
            // 
            this.txtSchoolType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "SubTypeId", true));
            this.txtSchoolType.Enabled = false;
            this.txtSchoolType.Location = new System.Drawing.Point(89, 71);
            this.txtSchoolType.Name = "txtSchoolType";
            this.txtSchoolType.Size = new System.Drawing.Size(171, 20);
            this.txtSchoolType.TabIndex = 107;
            // 
            // paymentStatusComboBox
            // 
            this.paymentStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentStatusComboBox.Enabled = false;
            this.paymentStatusComboBox.FormattingEnabled = true;
            this.paymentStatusComboBox.Items.AddRange(new object[] {
            "0 - Düzeltme Bekliyor",
            "1- Onay Bekliyor",
            "2 - Onaylandı",
            "3- Ödeme Emri Gönderildi",
            "4 - Muhasebeleşti"});
            this.paymentStatusComboBox.Location = new System.Drawing.Point(87, 199);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(186, 21);
            this.paymentStatusComboBox.TabIndex = 105;
            // 
            // gBoxConfirmPerson
            // 
            this.gBoxConfirmPerson.Controls.Add(label3);
            this.gBoxConfirmPerson.Controls.Add(paymentConfirmPersonLabel);
            this.gBoxConfirmPerson.Controls.Add(this.paymentConfirmPersonComboBox);
            this.gBoxConfirmPerson.Controls.Add(paymentConfirmDateLabel);
            this.gBoxConfirmPerson.Controls.Add(this.comboBoxCreatorPerson);
            this.gBoxConfirmPerson.Controls.Add(this.paymentConfirmDateDateTimePicker);
            this.gBoxConfirmPerson.Location = new System.Drawing.Point(289, 12);
            this.gBoxConfirmPerson.Name = "gBoxConfirmPerson";
            this.gBoxConfirmPerson.Size = new System.Drawing.Size(353, 114);
            this.gBoxConfirmPerson.TabIndex = 23;
            this.gBoxConfirmPerson.TabStop = false;
            this.gBoxConfirmPerson.Text = "Onaylayan Bilgisi";
            // 
            // gBoxOrder
            // 
            this.gBoxOrder.Controls.Add(orderOfPaymentConfirmDateLabel);
            this.gBoxOrder.Controls.Add(this.orderOfPaymentConfirmDateDateTimePicker);
            this.gBoxOrder.Controls.Add(orderOfPaymentNumberLabel);
            this.gBoxOrder.Controls.Add(this.orderOfPaymentNumberTextBox);
            this.gBoxOrder.Location = new System.Drawing.Point(289, 137);
            this.gBoxOrder.Name = "gBoxOrder";
            this.gBoxOrder.Size = new System.Drawing.Size(372, 101);
            this.gBoxOrder.TabIndex = 24;
            this.gBoxOrder.TabStop = false;
            this.gBoxOrder.Text = "Ödeme Emri Bilgisi";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(369, 24);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 39);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Enabled = false;
            this.btnDeny.Location = new System.Drawing.Point(369, 69);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(93, 43);
            this.btnDeny.TabIndex = 26;
            this.btnDeny.Text = "Reddet";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // txtDeny
            // 
            this.txtDeny.Location = new System.Drawing.Point(30, 34);
            this.txtDeny.Name = "txtDeny";
            this.txtDeny.Size = new System.Drawing.Size(312, 92);
            this.txtDeny.TabIndex = 27;
            this.txtDeny.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Not:";
            // 
            // btnShowBills
            // 
            this.btnShowBills.Location = new System.Drawing.Point(502, 311);
            this.btnShowBills.Name = "btnShowBills";
            this.btnShowBills.Size = new System.Drawing.Size(88, 47);
            this.btnShowBills.TabIndex = 29;
            this.btnShowBills.Text = "Ödenen Faturaları Görüntüle";
            this.btnShowBills.UseVisualStyleBackColor = true;
            this.btnShowBills.Click += new System.EventHandler(this.btnShowBills_Click);
            // 
            // gBoxConfirm
            // 
            this.gBoxConfirm.Controls.Add(this.label1);
            this.gBoxConfirm.Controls.Add(this.txtDeny);
            this.gBoxConfirm.Controls.Add(this.btnDeny);
            this.gBoxConfirm.Controls.Add(this.btnConfirm);
            this.gBoxConfirm.Location = new System.Drawing.Point(12, 295);
            this.gBoxConfirm.Name = "gBoxConfirm";
            this.gBoxConfirm.Size = new System.Drawing.Size(484, 136);
            this.gBoxConfirm.TabIndex = 30;
            this.gBoxConfirm.TabStop = false;
            this.gBoxConfirm.Text = "Onay İşlemleri:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(636, 17);
            this.toolStripStatusLabel1.Text = "Ödeme Durumu:  0 - Düzeltme Bekliyor | 1 - Onay Bekliyor | - 2 Onaylandı | 3 - Öd" +
    "eme Emri Gönderildi | 4 - Muhasebeşti";
            // 
            // btnHarcamatalimatı
            // 
            this.btnHarcamatalimatı.Enabled = false;
            this.btnHarcamatalimatı.Location = new System.Drawing.Point(502, 376);
            this.btnHarcamatalimatı.Name = "btnHarcamatalimatı";
            this.btnHarcamatalimatı.Size = new System.Drawing.Size(88, 47);
            this.btnHarcamatalimatı.TabIndex = 32;
            this.btnHarcamatalimatı.Text = "Harcama Talimatı Oluştur";
            this.btnHarcamatalimatı.UseVisualStyleBackColor = true;
            this.btnHarcamatalimatı.Click += new System.EventHandler(this.btnHarcamatalimatı_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 13);
            label3.TabIndex = 16;
            label3.Text = "Başlatan Kişi:";
            // 
            // comboBoxCreatorPerson
            // 
            this.comboBoxCreatorPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "PaymentConfirmPerson", true));
            this.comboBoxCreatorPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCreatorPerson.FormattingEnabled = true;
            this.comboBoxCreatorPerson.Location = new System.Drawing.Point(86, 42);
            this.comboBoxCreatorPerson.Name = "comboBoxCreatorPerson";
            this.comboBoxCreatorPerson.Size = new System.Drawing.Size(201, 21);
            this.comboBoxCreatorPerson.TabIndex = 17;
            // 
            // frmPaymentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 456);
            this.Controls.Add(this.btnHarcamatalimatı);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gBoxConfirm);
            this.Controls.Add(this.btnShowBills);
            this.Controls.Add(this.gBoxOrder);
            this.Controls.Add(this.gBoxConfirmPerson);
            this.Controls.Add(this.gBoxPaymentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentManage";
            this.Text = "Ödeme Bilgi ve Yönetim ekranı";
            this.Load += new System.EventHandler(this.frmPaymentManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4Payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.gBoxPaymentInfo.ResumeLayout(false);
            this.gBoxPaymentInfo.PerformLayout();
            this.gBoxConfirmPerson.ResumeLayout(false);
            this.gBoxConfirmPerson.PerformLayout();
            this.gBoxOrder.ResumeLayout(false);
            this.gBoxOrder.PerformLayout();
            this.gBoxConfirm.ResumeLayout(false);
            this.gBoxConfirm.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet4Payment dataSet4Payment;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private Data.DataSet4PaymentTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private Data.DataSet4PaymentTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox paymentIdTextBox;
        private System.Windows.Forms.TextBox subTypeIdTextBox;
        private System.Windows.Forms.DateTimePicker paymentDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker paymentConfirmDateDateTimePicker;
        private System.Windows.Forms.TextBox paymentAmountTextBox;
        private System.Windows.Forms.TextBox paymentTaxTextBox;
        private System.Windows.Forms.TextBox paymentConsumptionTextBox;
        private System.Windows.Forms.ComboBox paymentConfirmPersonComboBox;
        private System.Windows.Forms.TextBox orderOfPaymentNumberTextBox;
        private System.Windows.Forms.DateTimePicker orderOfPaymentConfirmDateDateTimePicker;
        private System.Windows.Forms.GroupBox gBoxPaymentInfo;
        private System.Windows.Forms.GroupBox gBoxConfirmPerson;
        private System.Windows.Forms.GroupBox gBoxOrder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.RichTextBox txtDeny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowBills;
        private System.Windows.Forms.GroupBox gBoxConfirm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnHarcamatalimatı;
        private System.Windows.Forms.ComboBox paymentStatusComboBox;
        private System.Windows.Forms.TextBox txtSchoolType;
        private System.Windows.Forms.ComboBox comboBoxCreatorPerson;
    }
}