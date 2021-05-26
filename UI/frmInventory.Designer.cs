namespace EasyBilling.UI
{
    partial class frmInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.grdInventoryDetails = new System.Windows.Forms.DataGridView();
            this.pnlPurchaseAndSalesTop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblInventoryTop = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventoryDetails)).BeginInit();
            this.pnlPurchaseAndSalesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInventoryDetails
            // 
            this.grdInventoryDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInventoryDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdInventoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInventoryDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdInventoryDetails.Location = new System.Drawing.Point(12, 73);
            this.grdInventoryDetails.Name = "grdInventoryDetails";
            this.grdInventoryDetails.Size = new System.Drawing.Size(748, 393);
            this.grdInventoryDetails.TabIndex = 83;
            // 
            // pnlPurchaseAndSalesTop
            // 
            this.pnlPurchaseAndSalesTop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlPurchaseAndSalesTop.Controls.Add(this.pictureBoxClose);
            this.pnlPurchaseAndSalesTop.Controls.Add(this.lblInventoryTop);
            this.pnlPurchaseAndSalesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPurchaseAndSalesTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchaseAndSalesTop.Name = "pnlPurchaseAndSalesTop";
            this.pnlPurchaseAndSalesTop.Size = new System.Drawing.Size(771, 36);
            this.pnlPurchaseAndSalesTop.TabIndex = 81;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(734, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            // 
            // lblInventoryTop
            // 
            this.lblInventoryTop.AutoSize = true;
            this.lblInventoryTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTop.ForeColor = System.Drawing.Color.White;
            this.lblInventoryTop.Location = new System.Drawing.Point(330, 9);
            this.lblInventoryTop.Name = "lblInventoryTop";
            this.lblInventoryTop.Size = new System.Drawing.Size(105, 18);
            this.lblInventoryTop.TabIndex = 1;
            this.lblInventoryTop.Text = "INVENTORY";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(12, 45);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 85;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "PURCHASE",
            "SALES"});
            this.cmbCategory.Location = new System.Drawing.Point(86, 43);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(228, 24);
            this.cmbCategory.TabIndex = 82;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(320, 42);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 25);
            this.btnShowAll.TabIndex = 84;
            this.btnShowAll.Text = "&Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(771, 477);
            this.Controls.Add(this.grdInventoryDetails);
            this.Controls.Add(this.pnlPurchaseAndSalesTop);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnShowAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInventoryDetails)).EndInit();
            this.pnlPurchaseAndSalesTop.ResumeLayout(false);
            this.pnlPurchaseAndSalesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInventoryDetails;
        private System.Windows.Forms.Panel pnlPurchaseAndSalesTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblInventoryTop;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnShowAll;
    }
}