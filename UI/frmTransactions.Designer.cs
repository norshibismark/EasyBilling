namespace EasyBilling.UI
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPurchaseAndSalesTop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTransactionsTop = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.cmbTranasactionType = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.grdTransactionDetails = new System.Windows.Forms.DataGridView();
            this.pnlPurchaseAndSalesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPurchaseAndSalesTop
            // 
            this.pnlPurchaseAndSalesTop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlPurchaseAndSalesTop.Controls.Add(this.pictureBoxClose);
            this.pnlPurchaseAndSalesTop.Controls.Add(this.lblTransactionsTop);
            this.pnlPurchaseAndSalesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPurchaseAndSalesTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchaseAndSalesTop.Name = "pnlPurchaseAndSalesTop";
            this.pnlPurchaseAndSalesTop.Size = new System.Drawing.Size(821, 36);
            this.pnlPurchaseAndSalesTop.TabIndex = 63;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(785, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTransactionsTop
            // 
            this.lblTransactionsTop.AutoSize = true;
            this.lblTransactionsTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsTop.ForeColor = System.Drawing.Color.White;
            this.lblTransactionsTop.Location = new System.Drawing.Point(341, 9);
            this.lblTransactionsTop.Name = "lblTransactionsTop";
            this.lblTransactionsTop.Size = new System.Drawing.Size(136, 18);
            this.lblTransactionsTop.TabIndex = 1;
            this.lblTransactionsTop.Text = "TRANSACTIONS";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.Location = new System.Drawing.Point(12, 45);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(122, 16);
            this.lblTransactionType.TabIndex = 80;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // cmbTranasactionType
            // 
            this.cmbTranasactionType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTranasactionType.FormattingEnabled = true;
            this.cmbTranasactionType.Items.AddRange(new object[] {
            "PURCHASE",
            "SALES"});
            this.cmbTranasactionType.Location = new System.Drawing.Point(138, 42);
            this.cmbTranasactionType.Name = "cmbTranasactionType";
            this.cmbTranasactionType.Size = new System.Drawing.Size(174, 24);
            this.cmbTranasactionType.TabIndex = 77;
            this.cmbTranasactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTranasactionType_SelectedIndexChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(318, 42);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 25);
            this.btnShowAll.TabIndex = 79;
            this.btnShowAll.Text = "&Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // grdTransactionDetails
            // 
            this.grdTransactionDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTransactionDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTransactionDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTransactionDetails.Location = new System.Drawing.Point(12, 76);
            this.grdTransactionDetails.Name = "grdTransactionDetails";
            this.grdTransactionDetails.Size = new System.Drawing.Size(797, 341);
            this.grdTransactionDetails.TabIndex = 78;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(821, 427);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.cmbTranasactionType);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grdTransactionDetails);
            this.Controls.Add(this.pnlPurchaseAndSalesTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransactions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlPurchaseAndSalesTop.ResumeLayout(false);
            this.pnlPurchaseAndSalesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPurchaseAndSalesTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTransactionsTop;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.ComboBox cmbTranasactionType;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView grdTransactionDetails;
    }
}