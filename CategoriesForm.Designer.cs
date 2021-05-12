
namespace PHP_SRaPS
{
    partial class CategoriesForm
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
            this.lsbCategories = new System.Windows.Forms.ListBox();
            this.lblAllCategories = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnCategoryNameEdit = new System.Windows.Forms.Button();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbCategories
            // 
            this.lsbCategories.FormattingEnabled = true;
            this.lsbCategories.ItemHeight = 15;
            this.lsbCategories.Location = new System.Drawing.Point(12, 48);
            this.lsbCategories.Name = "lsbCategories";
            this.lsbCategories.Size = new System.Drawing.Size(171, 154);
            this.lsbCategories.TabIndex = 0;
            this.lsbCategories.SelectedIndexChanged += new System.EventHandler(this.lsbCategories_SelectedIndexChanged);
            // 
            // lblAllCategories
            // 
            this.lblAllCategories.AutoSize = true;
            this.lblAllCategories.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllCategories.Location = new System.Drawing.Point(12, 9);
            this.lblAllCategories.Name = "lblAllCategories";
            this.lblAllCategories.Size = new System.Drawing.Size(129, 26);
            this.lblAllCategories.TabIndex = 33;
            this.lblAllCategories.Text = "All Categories";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(189, 48);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(91, 15);
            this.lblCategoryName.TabIndex = 36;
            this.lblCategoryName.Text = "Category name:";
            // 
            // btnCategoryNameEdit
            // 
            this.btnCategoryNameEdit.Location = new System.Drawing.Point(368, 66);
            this.btnCategoryNameEdit.Name = "btnCategoryNameEdit";
            this.btnCategoryNameEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryNameEdit.TabIndex = 35;
            this.btnCategoryNameEdit.Text = "Edit";
            this.btnCategoryNameEdit.UseVisualStyleBackColor = true;
            this.btnCategoryNameEdit.Click += new System.EventHandler(this.btnCategoryNameEdit_Click);
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(189, 66);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.ReadOnly = true;
            this.txbCategoryName.Size = new System.Drawing.Size(173, 23);
            this.txbCategoryName.TabIndex = 34;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(12, 208);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(58, 23);
            this.btnRemoveCategory.TabIndex = 38;
            this.btnRemoveCategory.Text = "Remove";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(76, 208);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(107, 23);
            this.btnAddCategory.TabIndex = 37;
            this.btnAddCategory.Text = "Add New";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(341, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(454, 246);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnCategoryNameEdit);
            this.Controls.Add(this.txbCategoryName);
            this.Controls.Add(this.lblAllCategories);
            this.Controls.Add(this.lsbCategories);
            this.Name = "CategoriesForm";
            this.Text = "Item Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbCategories;
        private System.Windows.Forms.Label lblAllCategories;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Button btnCategoryNameEdit;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnClose;
    }
}