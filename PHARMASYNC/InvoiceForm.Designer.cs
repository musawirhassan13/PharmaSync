namespace PHARMASYNC
{
    partial class InvoiceForm
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
            panelInvoice = new Panel();
            panelFooter = new Panel();
            btnPrintInvoice = new Button();
            lblDiscount = new Label();
            lblGrandTotalValue = new Label();
            lblTotalValue = new Label();
            lblDiscountTitle = new Label();
            lblGrandTotalTitle = new Label();
            lblTotalTitle = new Label();
            dataGridViewInvoice = new DataGridView();
            panelInvoiceInfo = new Panel();
            lblSellerName = new Label();
            lblCustomerName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblCustomerID = new Label();
            lblSellerID = new Label();
            lblAddressTitle = new Label();
            lblCustomerNameTitle = new Label();
            lblPhoneTitle = new Label();
            lblCustomerIDTitle = new Label();
            lblSellerNameTitle = new Label();
            lblSellerIDTitle = new Label();
            panelHeader = new Panel();
            lblDate = new Label();
            lblDateTitle = new Label();
            lblInvoiceNo = new Label();
            lblInvoiceNoTitle = new Label();
            lblShopName = new Label();
            pictureBoxLogo = new PictureBox();
            panelInvoice.SuspendLayout();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            panelInvoiceInfo.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelInvoice
            // 
            panelInvoice.Controls.Add(panelFooter);
            panelInvoice.Controls.Add(dataGridViewInvoice);
            panelInvoice.Controls.Add(panelInvoiceInfo);
            panelInvoice.Controls.Add(panelHeader);
            panelInvoice.Dock = DockStyle.Fill;
            panelInvoice.Location = new Point(0, 0);
            panelInvoice.Name = "panelInvoice";
            panelInvoice.Padding = new Padding(10);
            panelInvoice.Size = new Size(509, 532);
            panelInvoice.TabIndex = 0;
            // 
            // panelFooter
            // 
            panelFooter.BorderStyle = BorderStyle.FixedSingle;
            panelFooter.Controls.Add(btnPrintInvoice);
            panelFooter.Controls.Add(lblDiscount);
            panelFooter.Controls.Add(lblGrandTotalValue);
            panelFooter.Controls.Add(lblTotalValue);
            panelFooter.Controls.Add(lblDiscountTitle);
            panelFooter.Controls.Add(lblGrandTotalTitle);
            panelFooter.Controls.Add(lblTotalTitle);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(10, 422);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(489, 100);
            panelFooter.TabIndex = 3;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.Teal;
            btnPrintInvoice.FlatStyle = FlatStyle.Popup;
            btnPrintInvoice.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(212, 65);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(75, 25);
            btnPrintInvoice.TabIndex = 2;
            btnPrintInvoice.Text = "Print";
            btnPrintInvoice.TextAlign = ContentAlignment.TopCenter;
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(403, 8);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(50, 20);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "label1";
            // 
            // lblGrandTotalValue
            // 
            lblGrandTotalValue.AutoSize = true;
            lblGrandTotalValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotalValue.Location = new Point(268, 36);
            lblGrandTotalValue.Name = "lblGrandTotalValue";
            lblGrandTotalValue.Size = new Size(51, 20);
            lblGrandTotalValue.TabIndex = 1;
            lblGrandTotalValue.Text = "label1";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(109, 8);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(50, 20);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "label1";
            // 
            // lblDiscountTitle
            // 
            lblDiscountTitle.AutoSize = true;
            lblDiscountTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscountTitle.Location = new Point(301, 8);
            lblDiscountTitle.Name = "lblDiscountTitle";
            lblDiscountTitle.Size = new Size(96, 20);
            lblDiscountTitle.TabIndex = 0;
            lblDiscountTitle.Text = "Discount (%):";
            // 
            // lblGrandTotalTitle
            // 
            lblGrandTotalTitle.AutoSize = true;
            lblGrandTotalTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotalTitle.Location = new Point(167, 36);
            lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            lblGrandTotalTitle.Size = new Size(95, 20);
            lblGrandTotalTitle.TabIndex = 0;
            lblGrandTotalTitle.Text = "Grand Total:";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTitle.Location = new Point(21, 9);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(45, 20);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total:";
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoice.BackgroundColor = Color.White;
            dataGridViewInvoice.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Dock = DockStyle.Top;
            dataGridViewInvoice.Location = new Point(10, 196);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.Size = new Size(489, 218);
            dataGridViewInvoice.TabIndex = 2;
            // 
            // panelInvoiceInfo
            // 
            panelInvoiceInfo.Controls.Add(lblSellerName);
            panelInvoiceInfo.Controls.Add(lblCustomerName);
            panelInvoiceInfo.Controls.Add(lblAddress);
            panelInvoiceInfo.Controls.Add(lblPhone);
            panelInvoiceInfo.Controls.Add(lblCustomerID);
            panelInvoiceInfo.Controls.Add(lblSellerID);
            panelInvoiceInfo.Controls.Add(lblAddressTitle);
            panelInvoiceInfo.Controls.Add(lblCustomerNameTitle);
            panelInvoiceInfo.Controls.Add(lblPhoneTitle);
            panelInvoiceInfo.Controls.Add(lblCustomerIDTitle);
            panelInvoiceInfo.Controls.Add(lblSellerNameTitle);
            panelInvoiceInfo.Controls.Add(lblSellerIDTitle);
            panelInvoiceInfo.Dock = DockStyle.Top;
            panelInvoiceInfo.Location = new Point(10, 110);
            panelInvoiceInfo.Name = "panelInvoiceInfo";
            panelInvoiceInfo.Size = new Size(489, 86);
            panelInvoiceInfo.TabIndex = 1;
            // 
            // lblSellerName
            // 
            lblSellerName.AutoSize = true;
            lblSellerName.Location = new Point(398, 12);
            lblSellerName.Name = "lblSellerName";
            lblSellerName.Size = new Size(38, 15);
            lblSellerName.TabIndex = 1;
            lblSellerName.Text = "label1";
            lblSellerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(398, 32);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(38, 15);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "label1";
            lblCustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(398, 54);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(38, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "label1";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(98, 54);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(38, 15);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "label1";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(98, 32);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(38, 15);
            lblCustomerID.TabIndex = 1;
            lblCustomerID.Text = "label1";
            // 
            // lblSellerID
            // 
            lblSellerID.AutoSize = true;
            lblSellerID.Location = new Point(98, 12);
            lblSellerID.Name = "lblSellerID";
            lblSellerID.Size = new Size(38, 15);
            lblSellerID.TabIndex = 1;
            lblSellerID.Text = "label1";
            // 
            // lblAddressTitle
            // 
            lblAddressTitle.AutoSize = true;
            lblAddressTitle.Location = new Point(269, 54);
            lblAddressTitle.Name = "lblAddressTitle";
            lblAddressTitle.Size = new Size(45, 15);
            lblAddressTitle.TabIndex = 0;
            lblAddressTitle.Text = "Adress:";
            // 
            // lblCustomerNameTitle
            // 
            lblCustomerNameTitle.AutoSize = true;
            lblCustomerNameTitle.Location = new Point(266, 32);
            lblCustomerNameTitle.Name = "lblCustomerNameTitle";
            lblCustomerNameTitle.Size = new Size(97, 15);
            lblCustomerNameTitle.TabIndex = 0;
            lblCustomerNameTitle.Text = "Customer Name:";
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.Location = new Point(16, 54);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(63, 15);
            lblPhoneTitle.TabIndex = 0;
            lblPhoneTitle.Text = "Phone No:";
            // 
            // lblCustomerIDTitle
            // 
            lblCustomerIDTitle.AutoSize = true;
            lblCustomerIDTitle.Location = new Point(16, 32);
            lblCustomerIDTitle.Name = "lblCustomerIDTitle";
            lblCustomerIDTitle.Size = new Size(76, 15);
            lblCustomerIDTitle.TabIndex = 0;
            lblCustomerIDTitle.Text = "Customer ID:";
            // 
            // lblSellerNameTitle
            // 
            lblSellerNameTitle.AutoSize = true;
            lblSellerNameTitle.Location = new Point(269, 12);
            lblSellerNameTitle.Name = "lblSellerNameTitle";
            lblSellerNameTitle.Size = new Size(60, 15);
            lblSellerNameTitle.TabIndex = 0;
            lblSellerNameTitle.Text = "Salesman:";
            // 
            // lblSellerIDTitle
            // 
            lblSellerIDTitle.AutoSize = true;
            lblSellerIDTitle.Location = new Point(16, 12);
            lblSellerIDTitle.Name = "lblSellerIDTitle";
            lblSellerIDTitle.Size = new Size(74, 15);
            lblSellerIDTitle.TabIndex = 0;
            lblSellerIDTitle.Text = "Salesman ID:";
            // 
            // panelHeader
            // 
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(lblDate);
            panelHeader.Controls.Add(lblDateTitle);
            panelHeader.Controls.Add(lblInvoiceNo);
            panelHeader.Controls.Add(lblInvoiceNoTitle);
            panelHeader.Controls.Add(lblShopName);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(10, 10);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(489, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(362, 69);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "label1";
            // 
            // lblDateTitle
            // 
            lblDateTitle.AutoSize = true;
            lblDateTitle.Location = new Point(322, 69);
            lblDateTitle.Name = "lblDateTitle";
            lblDateTitle.Size = new Size(34, 15);
            lblDateTitle.TabIndex = 3;
            lblDateTitle.Text = "Date:";
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Location = new Point(193, 70);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(38, 15);
            lblInvoiceNo.TabIndex = 2;
            lblInvoiceNo.Text = "label1";
            // 
            // lblInvoiceNoTitle
            // 
            lblInvoiceNoTitle.AutoSize = true;
            lblInvoiceNoTitle.Location = new Point(124, 69);
            lblInvoiceNoTitle.Name = "lblInvoiceNoTitle";
            lblInvoiceNoTitle.Size = new Size(67, 15);
            lblInvoiceNoTitle.TabIndex = 0;
            lblInvoiceNoTitle.Text = "Invoice No:";
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopName.Location = new Point(124, 17);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(329, 30);
            lblShopName.TabIndex = 1;
            lblShopName.Text = "PHARMASYNC MEDICAL STORE";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Medical_Logo;
            pictureBoxLogo.Location = new Point(-34, -39);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(203, 171);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 532);
            Controls.Add(panelInvoice);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            Load += InvoiceForm_Load;
            panelInvoice.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            panelInvoiceInfo.ResumeLayout(false);
            panelInvoiceInfo.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInvoice;
        private Panel panelHeader;
        private Panel panelInvoiceInfo;
        private Label lblShopName;
        private PictureBox pictureBoxLogo;
        private Label lblSellerName;
        private Label lblSellerID;
        private Label lblSellerNameTitle;
        private Label lblSellerIDTitle;
        private Label lblDate;
        private Label lblDateTitle;
        private Label lblInvoiceNo;
        private Label lblInvoiceNoTitle;
        private Label lblCustomerName;
        private Label lblCustomerID;
        private Label lblCustomerNameTitle;
        private Label lblCustomerIDTitle;
        private DataGridView dataGridViewInvoice;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblAddressTitle;
        private Label lblPhoneTitle;
        private Panel panelFooter;
        private Label lblDiscount;
        private Label lblTotalValue;
        private Label lblDiscountTitle;
        private Label lblTotalTitle;
        private Button btnPrintInvoice;
        private Label lblGrandTotalValue;
        private Label lblGrandTotalTitle;
    }
}