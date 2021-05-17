
namespace PHP_SRaPS
{
    partial class ItemForm
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
            this.txbDiscountDollar = new System.Windows.Forms.TextBox();
            this.lblDiscountDollar = new System.Windows.Forms.Label();
            this.txbRRP = new System.Windows.Forms.TextBox();
            this.lblRRP = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txbItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txbDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblEditingItem = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditCategories = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.nudStockQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDiscountDollar
            // 
            this.txbDiscountDollar.Location = new System.Drawing.Point(10, 93);
            this.txbDiscountDollar.Name = "txbDiscountDollar";
            this.txbDiscountDollar.Size = new System.Drawing.Size(91, 20);
            this.txbDiscountDollar.TabIndex = 27;
            this.txbDiscountDollar.Leave += new System.EventHandler(this.txbDiscountDollar_Leave);
            // 
            // lblDiscountDollar
            // 
            this.lblDiscountDollar.AutoSize = true;
            this.lblDiscountDollar.Location = new System.Drawing.Point(10, 78);
            this.lblDiscountDollar.Name = "lblDiscountDollar";
            this.lblDiscountDollar.Size = new System.Drawing.Size(102, 13);
            this.lblDiscountDollar.TabIndex = 26;
            this.lblDiscountDollar.Text = "Default discount ($):";
            // 
            // txbRRP
            // 
            this.txbRRP.Location = new System.Drawing.Point(254, 55);
            this.txbRRP.Name = "txbRRP";
            this.txbRRP.Size = new System.Drawing.Size(91, 20);
            this.txbRRP.TabIndex = 25;
            this.txbRRP.Leave += new System.EventHandler(this.txbRRP_Leave);
            // 
            // lblRRP
            // 
            this.lblRRP.AutoSize = true;
            this.lblRRP.Location = new System.Drawing.Point(254, 40);
            this.lblRRP.Name = "lblRRP";
            this.lblRRP.Size = new System.Drawing.Size(33, 13);
            this.lblRRP.TabIndex = 24;
            this.lblRRP.Text = "RRP:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(113, 55);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(129, 20);
            this.txbName.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name:";
            // 
            // txbItemID
            // 
            this.txbItemID.Location = new System.Drawing.Point(10, 55);
            this.txbItemID.Name = "txbItemID";
            this.txbItemID.ReadOnly = true;
            this.txbItemID.Size = new System.Drawing.Size(91, 20);
            this.txbItemID.TabIndex = 21;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(10, 40);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(44, 13);
            this.lblItemID.TabIndex = 20;
            this.lblItemID.Text = "Item ID:";
            // 
            // txbDiscountPercentage
            // 
            this.txbDiscountPercentage.Location = new System.Drawing.Point(113, 93);
            this.txbDiscountPercentage.Name = "txbDiscountPercentage";
            this.txbDiscountPercentage.Size = new System.Drawing.Size(91, 20);
            this.txbDiscountPercentage.TabIndex = 29;
            this.txbDiscountPercentage.Leave += new System.EventHandler(this.txbDiscountPercentage_Leave);
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Location = new System.Drawing.Point(113, 78);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(104, 13);
            this.lblDiscountPercentage.TabIndex = 28;
            this.lblDiscountPercentage.Text = "Default discount (%):";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(219, 78);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 30;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(219, 93);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(126, 21);
            this.cmbCategory.TabIndex = 31;
            this.cmbCategory.DropDown += new System.EventHandler(this.cmbCategory_DropDown);
            // 
            // lblEditingItem
            // 
            this.lblEditingItem.AutoSize = true;
            this.lblEditingItem.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.lblEditingItem.Location = new System.Drawing.Point(10, 8);
            this.lblEditingItem.Name = "lblEditingItem";
            this.lblEditingItem.Size = new System.Drawing.Size(117, 26);
            this.lblEditingItem.TabIndex = 32;
            this.lblEditingItem.Text = "Editing Item";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 25);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditCategories
            // 
            this.btnEditCategories.Location = new System.Drawing.Point(254, 161);
            this.btnEditCategories.Name = "btnEditCategories";
            this.btnEditCategories.Size = new System.Drawing.Size(90, 25);
            this.btnEditCategories.TabIndex = 34;
            this.btnEditCategories.Text = "Edit Categories";
            this.btnEditCategories.UseVisualStyleBackColor = true;
            this.btnEditCategories.Click += new System.EventHandler(this.btnEditCategories_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(10, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 25);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbBarcode
            // 
            this.txbBarcode.Location = new System.Drawing.Point(10, 132);
            this.txbBarcode.MaxLength = 13;
            this.txbBarcode.Name = "txbBarcode";
            this.txbBarcode.Size = new System.Drawing.Size(194, 20);
            this.txbBarcode.TabIndex = 37;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(10, 116);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(50, 13);
            this.lblBarcode.TabIndex = 36;
            this.lblBarcode.Text = "Barcode:";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(219, 116);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(80, 13);
            this.lblStockQuantity.TabIndex = 38;
            this.lblStockQuantity.Text = "Stock Quantity:";
            // 
            // nudStockQuantity
            // 
            this.nudStockQuantity.Location = new System.Drawing.Point(219, 132);
            this.nudStockQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStockQuantity.Name = "nudStockQuantity";
            this.nudStockQuantity.Size = new System.Drawing.Size(126, 20);
            this.nudStockQuantity.TabIndex = 39;
            this.nudStockQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(354, 193);
            this.Controls.Add(this.nudStockQuantity);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.txbBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditCategories);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEditingItem);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txbDiscountPercentage);
            this.Controls.Add(this.lblDiscountPercentage);
            this.Controls.Add(this.txbDiscountDollar);
            this.Controls.Add(this.lblDiscountDollar);
            this.Controls.Add(this.txbRRP);
            this.Controls.Add(this.lblRRP);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbItemID);
            this.Controls.Add(this.lblItemID);
            this.Name = "ItemForm";
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDiscountDollar;
        private System.Windows.Forms.Label lblDiscountDollar;
        private System.Windows.Forms.TextBox txbRRP;
        private System.Windows.Forms.Label lblRRP;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txbDiscountPercentage;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblEditingItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditCategories;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.NumericUpDown nudStockQuantity;
    }
}