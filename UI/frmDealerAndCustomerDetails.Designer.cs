namespace EasyBilling.UI
{
    partial class frmDealerAndCustomerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDealerAndCustomerDetails));
            this.lbType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.grdDealerAndCustomerDetails = new System.Windows.Forms.DataGridView();
            this.pnlPurchaseAndSalesTop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblDelaerAndCustomerTop = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.btnTypeSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDealerAndCustomerDetails)).BeginInit();
            this.pnlPurchaseAndSalesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(12, 44);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(40, 16);
            this.lbType.TabIndex = 85;
            this.lbType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbType.Location = new System.Drawing.Point(52, 41);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(154, 24);
            this.cmbType.TabIndex = 82;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(633, 41);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 25);
            this.btnShowAll.TabIndex = 84;
            this.btnShowAll.Text = "&Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // grdDealerAndCustomerDetails
            // 
            this.grdDealerAndCustomerDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDealerAndCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDealerAndCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDealerAndCustomerDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDealerAndCustomerDetails.Location = new System.Drawing.Point(12, 73);
            this.grdDealerAndCustomerDetails.Name = "grdDealerAndCustomerDetails";
            this.grdDealerAndCustomerDetails.Size = new System.Drawing.Size(697, 326);
            this.grdDealerAndCustomerDetails.TabIndex = 83;
            this.grdDealerAndCustomerDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDealerAndCustomerDetails_CellDoubleClick);
            // 
            // pnlPurchaseAndSalesTop
            // 
            this.pnlPurchaseAndSalesTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlPurchaseAndSalesTop.Controls.Add(this.pictureBoxClose);
            this.pnlPurchaseAndSalesTop.Controls.Add(this.lblDelaerAndCustomerTop);
            this.pnlPurchaseAndSalesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPurchaseAndSalesTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchaseAndSalesTop.Name = "pnlPurchaseAndSalesTop";
            this.pnlPurchaseAndSalesTop.Size = new System.Drawing.Size(720, 36);
            this.pnlPurchaseAndSalesTop.TabIndex = 81;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(684, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblDelaerAndCustomerTop
            // 
            this.lblDelaerAndCustomerTop.AutoSize = true;
            this.lblDelaerAndCustomerTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelaerAndCustomerTop.ForeColor = System.Drawing.Color.White;
            this.lblDelaerAndCustomerTop.Location = new System.Drawing.Point(229, 9);
            this.lblDelaerAndCustomerTop.Name = "lblDelaerAndCustomerTop";
            this.lblDelaerAndCustomerTop.Size = new System.Drawing.Size(282, 18);
            this.lblDelaerAndCustomerTop.TabIndex = 1;
            this.lblDelaerAndCustomerTop.Text = "DEALER AND CUSTOMER DETAILS";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(287, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 16);
            this.lblSearch.TabIndex = 88;
            this.lblSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(556, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 25);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchKeyword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyword.Location = new System.Drawing.Point(347, 42);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(203, 23);
            this.txtSearchKeyword.TabIndex = 86;
            // 
            // btnTypeSearch
            // 
            this.btnTypeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnTypeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeSearch.ForeColor = System.Drawing.Color.White;
            this.btnTypeSearch.Location = new System.Drawing.Point(212, 40);
            this.btnTypeSearch.Name = "btnTypeSearch";
            this.btnTypeSearch.Size = new System.Drawing.Size(71, 25);
            this.btnTypeSearch.TabIndex = 89;
            this.btnTypeSearch.Text = "Search";
            this.btnTypeSearch.UseVisualStyleBackColor = false;
            this.btnTypeSearch.Click += new System.EventHandler(this.btnTypeSearch_Click);
            // 
            // frmDealerAndCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(720, 409);
            this.Controls.Add(this.btnTypeSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchKeyword);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grdDealerAndCustomerDetails);
            this.Controls.Add(this.pnlPurchaseAndSalesTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDealerAndCustomerDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDealerAndCustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDealerAndCustomerDetails)).EndInit();
            this.pnlPurchaseAndSalesTop.ResumeLayout(false);
            this.pnlPurchaseAndSalesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView grdDealerAndCustomerDetails;
        private System.Windows.Forms.Panel pnlPurchaseAndSalesTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblDelaerAndCustomerTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Button btnTypeSearch;
    }
}