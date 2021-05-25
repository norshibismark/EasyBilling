namespace EasyBilling.UI
{
    partial class frmPurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPurchaseAndSalesTop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblPurchaseAndSalesTop = new System.Windows.Forms.Label();
            this.pnlDealerAndCustomer = new System.Windows.Forms.Panel();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDealerAndCustomerName = new System.Windows.Forms.TextBox();
            this.lblDealerAndCustomerName = new System.Windows.Forms.Label();
            this.lblDealerAndCustomerSearch = new System.Windows.Forms.Label();
            this.txtDealerAndCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblDealerAndCustomerDetails = new System.Windows.Forms.Label();
            this.pnlProductDetails = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtProductDetailsName = new System.Windows.Forms.TextBox();
            this.lblProductDetailsName = new System.Windows.Forms.Label();
            this.lblProductDetailsSearch = new System.Windows.Forms.Label();
            this.txtProductDetailsSearch = new System.Windows.Forms.TextBox();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.pnlAddedProducts = new System.Windows.Forms.Panel();
            this.grdAddedProducts = new System.Windows.Forms.DataGridView();
            this.lblAddedProducts = new System.Windows.Forms.Label();
            this.pnlCalculationDetails = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGstPercentage = new System.Windows.Forms.TextBox();
            this.lblGstPercentage = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblCalculationDetails = new System.Windows.Forms.Label();
            this.pnlPurchaseAndSalesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlDealerAndCustomer.SuspendLayout();
            this.pnlProductDetails.SuspendLayout();
            this.pnlAddedProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedProducts)).BeginInit();
            this.pnlCalculationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPurchaseAndSalesTop
            // 
            this.pnlPurchaseAndSalesTop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlPurchaseAndSalesTop.Controls.Add(this.pictureBoxClose);
            this.pnlPurchaseAndSalesTop.Controls.Add(this.lblPurchaseAndSalesTop);
            this.pnlPurchaseAndSalesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPurchaseAndSalesTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchaseAndSalesTop.Name = "pnlPurchaseAndSalesTop";
            this.pnlPurchaseAndSalesTop.Size = new System.Drawing.Size(997, 36);
            this.pnlPurchaseAndSalesTop.TabIndex = 62;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(961, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblPurchaseAndSalesTop
            // 
            this.lblPurchaseAndSalesTop.AutoSize = true;
            this.lblPurchaseAndSalesTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseAndSalesTop.ForeColor = System.Drawing.Color.White;
            this.lblPurchaseAndSalesTop.Location = new System.Drawing.Point(398, 9);
            this.lblPurchaseAndSalesTop.Name = "lblPurchaseAndSalesTop";
            this.lblPurchaseAndSalesTop.Size = new System.Drawing.Size(192, 18);
            this.lblPurchaseAndSalesTop.TabIndex = 1;
            this.lblPurchaseAndSalesTop.Text = "PURCHASE AND SALES";
            // 
            // pnlDealerAndCustomer
            // 
            this.pnlDealerAndCustomer.Controls.Add(this.dtpBillDate);
            this.pnlDealerAndCustomer.Controls.Add(this.lblBillDate);
            this.pnlDealerAndCustomer.Controls.Add(this.txtAddress);
            this.pnlDealerAndCustomer.Controls.Add(this.lblAddress);
            this.pnlDealerAndCustomer.Controls.Add(this.lblContact);
            this.pnlDealerAndCustomer.Controls.Add(this.txtContact);
            this.pnlDealerAndCustomer.Controls.Add(this.lblEmail);
            this.pnlDealerAndCustomer.Controls.Add(this.txtEmail);
            this.pnlDealerAndCustomer.Controls.Add(this.txtDealerAndCustomerName);
            this.pnlDealerAndCustomer.Controls.Add(this.lblDealerAndCustomerName);
            this.pnlDealerAndCustomer.Controls.Add(this.lblDealerAndCustomerSearch);
            this.pnlDealerAndCustomer.Controls.Add(this.txtDealerAndCustomerSearch);
            this.pnlDealerAndCustomer.Controls.Add(this.lblDealerAndCustomerDetails);
            this.pnlDealerAndCustomer.Location = new System.Drawing.Point(12, 49);
            this.pnlDealerAndCustomer.Name = "pnlDealerAndCustomer";
            this.pnlDealerAndCustomer.Size = new System.Drawing.Size(973, 92);
            this.pnlDealerAndCustomer.TabIndex = 63;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(815, 34);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(150, 22);
            this.dtpBillDate.TabIndex = 87;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(812, 13);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(61, 16);
            this.lblBillDate.TabIndex = 86;
            this.lblBillDate.Text = "Bill Date";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(606, 13);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 67);
            this.txtAddress.TabIndex = 84;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(540, 34);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 16);
            this.lblAddress.TabIndex = 85;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(272, 58);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(61, 16);
            this.lblContact.TabIndex = 83;
            this.lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(335, 53);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(196, 23);
            this.txtContact.TabIndex = 82;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(272, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 81;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(335, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 23);
            this.txtEmail.TabIndex = 79;
            // 
            // txtDealerAndCustomerName
            // 
            this.txtDealerAndCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDealerAndCustomerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerAndCustomerName.Location = new System.Drawing.Point(69, 55);
            this.txtDealerAndCustomerName.Name = "txtDealerAndCustomerName";
            this.txtDealerAndCustomerName.Size = new System.Drawing.Size(193, 23);
            this.txtDealerAndCustomerName.TabIndex = 78;
            // 
            // lblDealerAndCustomerName
            // 
            this.lblDealerAndCustomerName.AutoSize = true;
            this.lblDealerAndCustomerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerAndCustomerName.Location = new System.Drawing.Point(10, 60);
            this.lblDealerAndCustomerName.Name = "lblDealerAndCustomerName";
            this.lblDealerAndCustomerName.Size = new System.Drawing.Size(44, 16);
            this.lblDealerAndCustomerName.TabIndex = 80;
            this.lblDealerAndCustomerName.Text = "Name";
            // 
            // lblDealerAndCustomerSearch
            // 
            this.lblDealerAndCustomerSearch.AutoSize = true;
            this.lblDealerAndCustomerSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerAndCustomerSearch.Location = new System.Drawing.Point(9, 24);
            this.lblDealerAndCustomerSearch.Name = "lblDealerAndCustomerSearch";
            this.lblDealerAndCustomerSearch.Size = new System.Drawing.Size(54, 16);
            this.lblDealerAndCustomerSearch.TabIndex = 76;
            this.lblDealerAndCustomerSearch.Text = "Search";
            // 
            // txtDealerAndCustomerSearch
            // 
            this.txtDealerAndCustomerSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDealerAndCustomerSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerAndCustomerSearch.Location = new System.Drawing.Point(69, 22);
            this.txtDealerAndCustomerSearch.Name = "txtDealerAndCustomerSearch";
            this.txtDealerAndCustomerSearch.Size = new System.Drawing.Size(193, 23);
            this.txtDealerAndCustomerSearch.TabIndex = 75;
            // 
            // lblDealerAndCustomerDetails
            // 
            this.lblDealerAndCustomerDetails.AutoSize = true;
            this.lblDealerAndCustomerDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerAndCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.lblDealerAndCustomerDetails.Location = new System.Drawing.Point(10, 5);
            this.lblDealerAndCustomerDetails.Name = "lblDealerAndCustomerDetails";
            this.lblDealerAndCustomerDetails.Size = new System.Drawing.Size(233, 14);
            this.lblDealerAndCustomerDetails.TabIndex = 2;
            this.lblDealerAndCustomerDetails.Text = "DEALER AND CUSTOMER DETAILS";
            // 
            // pnlProductDetails
            // 
            this.pnlProductDetails.Controls.Add(this.btnAdd);
            this.pnlProductDetails.Controls.Add(this.txtQuantity);
            this.pnlProductDetails.Controls.Add(this.lblQuantity);
            this.pnlProductDetails.Controls.Add(this.textBox1);
            this.pnlProductDetails.Controls.Add(this.lblRate);
            this.pnlProductDetails.Controls.Add(this.txtInventory);
            this.pnlProductDetails.Controls.Add(this.lblInventory);
            this.pnlProductDetails.Controls.Add(this.txtProductDetailsName);
            this.pnlProductDetails.Controls.Add(this.lblProductDetailsName);
            this.pnlProductDetails.Controls.Add(this.lblProductDetailsSearch);
            this.pnlProductDetails.Controls.Add(this.txtProductDetailsSearch);
            this.pnlProductDetails.Controls.Add(this.lblProductDetails);
            this.pnlProductDetails.Location = new System.Drawing.Point(12, 147);
            this.pnlProductDetails.Name = "pnlProductDetails";
            this.pnlProductDetails.Size = new System.Drawing.Size(973, 100);
            this.pnlProductDetails.TabIndex = 64;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(815, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 37);
            this.btnAdd.TabIndex = 89;
            this.btnAdd.Text = "&ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(606, 59);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(193, 23);
            this.txtQuantity.TabIndex = 87;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(540, 61);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 16);
            this.lblQuantity.TabIndex = 88;
            this.lblQuantity.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(606, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 23);
            this.textBox1.TabIndex = 85;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(540, 32);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(38, 16);
            this.lblRate.TabIndex = 86;
            this.lblRate.Text = "Rate";
            // 
            // txtInventory
            // 
            this.txtInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInventory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(335, 60);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(193, 23);
            this.txtInventory.TabIndex = 83;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(257, 62);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(72, 16);
            this.lblInventory.TabIndex = 84;
            this.lblInventory.Text = "Inventory";
            // 
            // txtProductDetailsName
            // 
            this.txtProductDetailsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductDetailsName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDetailsName.Location = new System.Drawing.Point(335, 30);
            this.txtProductDetailsName.Name = "txtProductDetailsName";
            this.txtProductDetailsName.Size = new System.Drawing.Size(193, 23);
            this.txtProductDetailsName.TabIndex = 81;
            // 
            // lblProductDetailsName
            // 
            this.lblProductDetailsName.AutoSize = true;
            this.lblProductDetailsName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetailsName.Location = new System.Drawing.Point(272, 32);
            this.lblProductDetailsName.Name = "lblProductDetailsName";
            this.lblProductDetailsName.Size = new System.Drawing.Size(44, 16);
            this.lblProductDetailsName.TabIndex = 82;
            this.lblProductDetailsName.Text = "Name";
            // 
            // lblProductDetailsSearch
            // 
            this.lblProductDetailsSearch.AutoSize = true;
            this.lblProductDetailsSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetailsSearch.Location = new System.Drawing.Point(9, 32);
            this.lblProductDetailsSearch.Name = "lblProductDetailsSearch";
            this.lblProductDetailsSearch.Size = new System.Drawing.Size(54, 16);
            this.lblProductDetailsSearch.TabIndex = 78;
            this.lblProductDetailsSearch.Text = "Search";
            // 
            // txtProductDetailsSearch
            // 
            this.txtProductDetailsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductDetailsSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDetailsSearch.Location = new System.Drawing.Point(69, 30);
            this.txtProductDetailsSearch.Name = "txtProductDetailsSearch";
            this.txtProductDetailsSearch.Size = new System.Drawing.Size(193, 23);
            this.txtProductDetailsSearch.TabIndex = 77;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.ForeColor = System.Drawing.Color.White;
            this.lblProductDetails.Location = new System.Drawing.Point(9, 13);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(135, 14);
            this.lblProductDetails.TabIndex = 3;
            this.lblProductDetails.Text = "PRODUCT DETAILS";
            // 
            // pnlAddedProducts
            // 
            this.pnlAddedProducts.Controls.Add(this.grdAddedProducts);
            this.pnlAddedProducts.Controls.Add(this.lblAddedProducts);
            this.pnlAddedProducts.Location = new System.Drawing.Point(12, 253);
            this.pnlAddedProducts.Name = "pnlAddedProducts";
            this.pnlAddedProducts.Size = new System.Drawing.Size(481, 270);
            this.pnlAddedProducts.TabIndex = 65;
            // 
            // grdAddedProducts
            // 
            this.grdAddedProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAddedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAddedProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAddedProducts.Location = new System.Drawing.Point(12, 30);
            this.grdAddedProducts.Name = "grdAddedProducts";
            this.grdAddedProducts.Size = new System.Drawing.Size(455, 228);
            this.grdAddedProducts.TabIndex = 69;
            // 
            // lblAddedProducts
            // 
            this.lblAddedProducts.AutoSize = true;
            this.lblAddedProducts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedProducts.ForeColor = System.Drawing.Color.White;
            this.lblAddedProducts.Location = new System.Drawing.Point(9, 13);
            this.lblAddedProducts.Name = "lblAddedProducts";
            this.lblAddedProducts.Size = new System.Drawing.Size(133, 14);
            this.lblAddedProducts.TabIndex = 4;
            this.lblAddedProducts.Text = "ADDED PRODUCTS";
            // 
            // pnlCalculationDetails
            // 
            this.pnlCalculationDetails.Controls.Add(this.btnSave);
            this.pnlCalculationDetails.Controls.Add(this.txtReturnAmount);
            this.pnlCalculationDetails.Controls.Add(this.lblReturnAmount);
            this.pnlCalculationDetails.Controls.Add(this.txtPaidAmount);
            this.pnlCalculationDetails.Controls.Add(this.lblPaidAmount);
            this.pnlCalculationDetails.Controls.Add(this.txtGrandTotal);
            this.pnlCalculationDetails.Controls.Add(this.lblGrandTotal);
            this.pnlCalculationDetails.Controls.Add(this.txtGstPercentage);
            this.pnlCalculationDetails.Controls.Add(this.lblGstPercentage);
            this.pnlCalculationDetails.Controls.Add(this.txtDiscountPercentage);
            this.pnlCalculationDetails.Controls.Add(this.lblDiscountPercentage);
            this.pnlCalculationDetails.Controls.Add(this.txtSubTotal);
            this.pnlCalculationDetails.Controls.Add(this.lblSubTotal);
            this.pnlCalculationDetails.Controls.Add(this.lblCalculationDetails);
            this.pnlCalculationDetails.Location = new System.Drawing.Point(499, 253);
            this.pnlCalculationDetails.Name = "pnlCalculationDetails";
            this.pnlCalculationDetails.Size = new System.Drawing.Size(486, 270);
            this.pnlCalculationDetails.TabIndex = 66;
            this.pnlCalculationDetails.Tag = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(119, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 37);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReturnAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnAmount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtReturnAmount.Location = new System.Drawing.Point(119, 187);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.ReadOnly = true;
            this.txtReturnAmount.Size = new System.Drawing.Size(193, 23);
            this.txtReturnAmount.TabIndex = 97;
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmount.Location = new System.Drawing.Point(12, 194);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(106, 16);
            this.lblReturnAmount.TabIndex = 98;
            this.lblReturnAmount.Text = "Return Amount";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaidAmount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(119, 158);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(193, 23);
            this.txtPaidAmount.TabIndex = 95;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(12, 165);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(90, 16);
            this.lblPaidAmount.TabIndex = 96;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(119, 129);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(193, 23);
            this.txtGrandTotal.TabIndex = 93;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(12, 131);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(84, 16);
            this.lblGrandTotal.TabIndex = 94;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtGstPercentage
            // 
            this.txtGstPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGstPercentage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGstPercentage.Location = new System.Drawing.Point(119, 100);
            this.txtGstPercentage.Name = "txtGstPercentage";
            this.txtGstPercentage.Size = new System.Drawing.Size(193, 23);
            this.txtGstPercentage.TabIndex = 91;
            // 
            // lblGstPercentage
            // 
            this.lblGstPercentage.AutoSize = true;
            this.lblGstPercentage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGstPercentage.Location = new System.Drawing.Point(12, 102);
            this.lblGstPercentage.Name = "lblGstPercentage";
            this.lblGstPercentage.Size = new System.Drawing.Size(60, 16);
            this.lblGstPercentage.TabIndex = 92;
            this.lblGstPercentage.Text = "GST(%)";
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPercentage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercentage.Location = new System.Drawing.Point(119, 71);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(193, 23);
            this.txtDiscountPercentage.TabIndex = 89;
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercentage.Location = new System.Drawing.Point(12, 73);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(90, 16);
            this.lblDiscountPercentage.TabIndex = 90;
            this.lblDiscountPercentage.Text = "Discount(%)";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(119, 42);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(193, 23);
            this.txtSubTotal.TabIndex = 87;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(12, 44);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(71, 16);
            this.lblSubTotal.TabIndex = 88;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblCalculationDetails
            // 
            this.lblCalculationDetails.AutoSize = true;
            this.lblCalculationDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculationDetails.ForeColor = System.Drawing.Color.White;
            this.lblCalculationDetails.Location = new System.Drawing.Point(3, 13);
            this.lblCalculationDetails.Name = "lblCalculationDetails";
            this.lblCalculationDetails.Size = new System.Drawing.Size(166, 14);
            this.lblCalculationDetails.TabIndex = 5;
            this.lblCalculationDetails.Text = "CALCULATION DETAILS";
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(997, 535);
            this.Controls.Add(this.pnlCalculationDetails);
            this.Controls.Add(this.pnlAddedProducts);
            this.Controls.Add(this.pnlProductDetails);
            this.Controls.Add(this.pnlDealerAndCustomer);
            this.Controls.Add(this.pnlPurchaseAndSalesTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseAndSales";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase And Sales";
            this.pnlPurchaseAndSalesTop.ResumeLayout(false);
            this.pnlPurchaseAndSalesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlDealerAndCustomer.ResumeLayout(false);
            this.pnlDealerAndCustomer.PerformLayout();
            this.pnlProductDetails.ResumeLayout(false);
            this.pnlProductDetails.PerformLayout();
            this.pnlAddedProducts.ResumeLayout(false);
            this.pnlAddedProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedProducts)).EndInit();
            this.pnlCalculationDetails.ResumeLayout(false);
            this.pnlCalculationDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPurchaseAndSalesTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblPurchaseAndSalesTop;
        private System.Windows.Forms.Panel pnlDealerAndCustomer;
        private System.Windows.Forms.Panel pnlProductDetails;
        private System.Windows.Forms.Panel pnlAddedProducts;
        private System.Windows.Forms.Panel pnlCalculationDetails;
        private System.Windows.Forms.Label lblDealerAndCustomerDetails;
        private System.Windows.Forms.Label lblDealerAndCustomerSearch;
        private System.Windows.Forms.TextBox txtDealerAndCustomerSearch;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDealerAndCustomerName;
        private System.Windows.Forms.Label lblDealerAndCustomerName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.TextBox txtProductDetailsName;
        private System.Windows.Forms.Label lblProductDetailsName;
        private System.Windows.Forms.Label lblProductDetailsSearch;
        private System.Windows.Forms.TextBox txtProductDetailsSearch;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddedProducts;
        private System.Windows.Forms.DataGridView grdAddedProducts;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtGstPercentage;
        private System.Windows.Forms.Label lblGstPercentage;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblCalculationDetails;
        private System.Windows.Forms.Button btnSave;
    }
}