
namespace PHP_SRaPS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpBusiness = new System.Windows.Forms.TabPage();
            this.lblEmployeeDetails = new System.Windows.Forms.Label();
            this.lblEmployeePassword = new System.Windows.Forms.Label();
            this.btnEmployeePasswordEdit = new System.Windows.Forms.Button();
            this.txbEmployeePassword = new System.Windows.Forms.TextBox();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnEmployeeEdit = new System.Windows.Forms.Button();
            this.lblBusinessPassword = new System.Windows.Forms.Label();
            this.btnBusinessPasswordEdit = new System.Windows.Forms.Button();
            this.txbBusinessPassword = new System.Windows.Forms.TextBox();
            this.txbHoursTotal = new System.Windows.Forms.TextBox();
            this.txbHoursThisWeek = new System.Windows.Forms.TextBox();
            this.lblHoursTotal = new System.Windows.Forms.Label();
            this.lblHoursThisWeek = new System.Windows.Forms.Label();
            this.btnViewEmployeeSale = new System.Windows.Forms.Button();
            this.lblEmployeeSales = new System.Windows.Forms.Label();
            this.lsbEmployeeSales = new System.Windows.Forms.ListBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txbStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lsbEmployees = new System.Windows.Forms.ListBox();
            this.btnBusinessNameEdit = new System.Windows.Forms.Button();
            this.txbBusinessName = new System.Windows.Forms.TextBox();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.lblSalesperson = new System.Windows.Forms.Label();
            this.cmbSalesperson = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lsbSearchItems = new System.Windows.Forms.ListBox();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnlSearchBy = new System.Windows.Forms.Panel();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnBarcode = new System.Windows.Forms.RadioButton();
            this.rbtnCategory = new System.Windows.Forms.RadioButton();
            this.splcTransaction = new System.Windows.Forms.SplitContainer();
            this.btnCartRemove = new System.Windows.Forms.Button();
            this.lsbCart = new System.Windows.Forms.ListBox();
            this.lblCartDiscountPercentage = new System.Windows.Forms.Label();
            this.txbCartDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblCartDiscountDollar = new System.Windows.Forms.Label();
            this.txbCartDiscountDollar = new System.Windows.Forms.TextBox();
            this.btnCartAdd = new System.Windows.Forms.Button();
            this.btnProcessSale = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxbTransaction = new System.Windows.Forms.RichTextBox();
            this.txbTotalDiscountPercentage = new System.Windows.Forms.TextBox();
            this.txbTotalDiscountDollar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.tbpReporting = new System.Windows.Forms.TabPage();
            this.lblBusinessDayExplanation = new System.Windows.Forms.Label();
            this.lblSelectionExplanation = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblOnStaff = new System.Windows.Forms.Label();
            this.lsbClockedIn = new System.Windows.Forms.ListBox();
            this.lblBusinessDaySalesArrow = new System.Windows.Forms.Label();
            this.rtxbSaleData = new System.Windows.Forms.RichTextBox();
            this.lblSalesMade = new System.Windows.Forms.Label();
            this.lsbBusinessDaySales = new System.Windows.Forms.ListBox();
            this.lsbBusinessDays = new System.Windows.Forms.ListBox();
            this.lblBusinessDays = new System.Windows.Forms.Label();
            this.printDialogTransaction = new System.Windows.Forms.PrintDialog();
            this.printDocumentTransaction = new System.Drawing.Printing.PrintDocument();
            this.printPreviewTransaction = new System.Windows.Forms.PrintPreviewDialog();
            this.tbcMain.SuspendLayout();
            this.tbpBusiness.SuspendLayout();
            this.tbpSales.SuspendLayout();
            this.pnlSearchBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcTransaction)).BeginInit();
            this.splcTransaction.Panel1.SuspendLayout();
            this.splcTransaction.Panel2.SuspendLayout();
            this.splcTransaction.SuspendLayout();
            this.tbpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(9, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Sales Reporting and Prediction System";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblVersion.Location = new System.Drawing.Point(468, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(56, 14);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "V_1.0.7";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpBusiness);
            this.tbcMain.Controls.Add(this.tbpSales);
            this.tbcMain.Controls.Add(this.tbpReporting);
            this.tbcMain.Location = new System.Drawing.Point(10, 33);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(514, 339);
            this.tbcMain.TabIndex = 3;
            // 
            // tbpBusiness
            // 
            this.tbpBusiness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpBusiness.Controls.Add(this.lblEmployeeDetails);
            this.tbpBusiness.Controls.Add(this.lblEmployeePassword);
            this.tbpBusiness.Controls.Add(this.btnEmployeePasswordEdit);
            this.tbpBusiness.Controls.Add(this.txbEmployeePassword);
            this.tbpBusiness.Controls.Add(this.btnClock);
            this.tbpBusiness.Controls.Add(this.btnEmployeeEdit);
            this.tbpBusiness.Controls.Add(this.lblBusinessPassword);
            this.tbpBusiness.Controls.Add(this.btnBusinessPasswordEdit);
            this.tbpBusiness.Controls.Add(this.txbBusinessPassword);
            this.tbpBusiness.Controls.Add(this.txbHoursTotal);
            this.tbpBusiness.Controls.Add(this.txbHoursThisWeek);
            this.tbpBusiness.Controls.Add(this.lblHoursTotal);
            this.tbpBusiness.Controls.Add(this.lblHoursThisWeek);
            this.tbpBusiness.Controls.Add(this.btnViewEmployeeSale);
            this.tbpBusiness.Controls.Add(this.lblEmployeeSales);
            this.tbpBusiness.Controls.Add(this.lsbEmployeeSales);
            this.tbpBusiness.Controls.Add(this.txbLastName);
            this.tbpBusiness.Controls.Add(this.lblLastName);
            this.tbpBusiness.Controls.Add(this.txbFirstName);
            this.tbpBusiness.Controls.Add(this.lblFirstName);
            this.tbpBusiness.Controls.Add(this.txbStaffID);
            this.tbpBusiness.Controls.Add(this.lblStaffID);
            this.tbpBusiness.Controls.Add(this.lblBusinessName);
            this.tbpBusiness.Controls.Add(this.btnRemoveEmployee);
            this.tbpBusiness.Controls.Add(this.btnAddEmployee);
            this.tbpBusiness.Controls.Add(this.lblEmployees);
            this.tbpBusiness.Controls.Add(this.lsbEmployees);
            this.tbpBusiness.Controls.Add(this.btnBusinessNameEdit);
            this.tbpBusiness.Controls.Add(this.txbBusinessName);
            this.tbpBusiness.Location = new System.Drawing.Point(4, 22);
            this.tbpBusiness.Name = "tbpBusiness";
            this.tbpBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBusiness.Size = new System.Drawing.Size(506, 313);
            this.tbpBusiness.TabIndex = 0;
            this.tbpBusiness.Text = "Business";
            this.tbpBusiness.UseVisualStyleBackColor = true;
            this.tbpBusiness.Click += new System.EventHandler(this.tbpBusiness_Click);
            // 
            // lblEmployeeDetails
            // 
            this.lblEmployeeDetails.AutoSize = true;
            this.lblEmployeeDetails.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeDetails.Location = new System.Drawing.Point(193, 54);
            this.lblEmployeeDetails.Name = "lblEmployeeDetails";
            this.lblEmployeeDetails.Size = new System.Drawing.Size(155, 23);
            this.lblEmployeeDetails.TabIndex = 29;
            this.lblEmployeeDetails.Text = "Employee Details";
            // 
            // lblEmployeePassword
            // 
            this.lblEmployeePassword.AutoSize = true;
            this.lblEmployeePassword.Location = new System.Drawing.Point(302, 80);
            this.lblEmployeePassword.Name = "lblEmployeePassword";
            this.lblEmployeePassword.Size = new System.Drawing.Size(99, 13);
            this.lblEmployeePassword.TabIndex = 28;
            this.lblEmployeePassword.Text = "Personal password:";
            // 
            // btnEmployeePasswordEdit
            // 
            this.btnEmployeePasswordEdit.Enabled = false;
            this.btnEmployeePasswordEdit.Location = new System.Drawing.Point(433, 95);
            this.btnEmployeePasswordEdit.Name = "btnEmployeePasswordEdit";
            this.btnEmployeePasswordEdit.Size = new System.Drawing.Size(64, 20);
            this.btnEmployeePasswordEdit.TabIndex = 27;
            this.btnEmployeePasswordEdit.Text = "Edit";
            this.btnEmployeePasswordEdit.UseVisualStyleBackColor = true;
            this.btnEmployeePasswordEdit.Click += new System.EventHandler(this.btnEmployeePasswordEdit_Click);
            // 
            // txbEmployeePassword
            // 
            this.txbEmployeePassword.Location = new System.Drawing.Point(302, 95);
            this.txbEmployeePassword.Name = "txbEmployeePassword";
            this.txbEmployeePassword.ReadOnly = true;
            this.txbEmployeePassword.Size = new System.Drawing.Size(127, 20);
            this.txbEmployeePassword.TabIndex = 26;
            this.txbEmployeePassword.UseSystemPasswordChar = true;
            // 
            // btnClock
            // 
            this.btnClock.Enabled = false;
            this.btnClock.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnClock.Location = new System.Drawing.Point(197, 242);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(129, 29);
            this.btnClock.TabIndex = 25;
            this.btnClock.Text = "CLOCK IN";
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnEmployeeEdit
            // 
            this.btnEmployeeEdit.Enabled = false;
            this.btnEmployeeEdit.Location = new System.Drawing.Point(197, 283);
            this.btnEmployeeEdit.Name = "btnEmployeeEdit";
            this.btnEmployeeEdit.Size = new System.Drawing.Size(129, 20);
            this.btnEmployeeEdit.TabIndex = 24;
            this.btnEmployeeEdit.Text = "Edit Employee";
            this.btnEmployeeEdit.UseVisualStyleBackColor = true;
            this.btnEmployeeEdit.Click += new System.EventHandler(this.btnEmployeeEdit_Click);
            // 
            // lblBusinessPassword
            // 
            this.lblBusinessPassword.AutoSize = true;
            this.lblBusinessPassword.Location = new System.Drawing.Point(299, 3);
            this.lblBusinessPassword.Name = "lblBusinessPassword";
            this.lblBusinessPassword.Size = new System.Drawing.Size(87, 13);
            this.lblBusinessPassword.TabIndex = 23;
            this.lblBusinessPassword.Text = "Admin password:";
            // 
            // btnBusinessPasswordEdit
            // 
            this.btnBusinessPasswordEdit.Location = new System.Drawing.Point(432, 18);
            this.btnBusinessPasswordEdit.Name = "btnBusinessPasswordEdit";
            this.btnBusinessPasswordEdit.Size = new System.Drawing.Size(64, 20);
            this.btnBusinessPasswordEdit.TabIndex = 22;
            this.btnBusinessPasswordEdit.Text = "Edit";
            this.btnBusinessPasswordEdit.UseVisualStyleBackColor = true;
            this.btnBusinessPasswordEdit.Click += new System.EventHandler(this.btnBusinessPasswordEdit_Click);
            // 
            // txbBusinessPassword
            // 
            this.txbBusinessPassword.Location = new System.Drawing.Point(299, 18);
            this.txbBusinessPassword.Name = "txbBusinessPassword";
            this.txbBusinessPassword.ReadOnly = true;
            this.txbBusinessPassword.Size = new System.Drawing.Size(127, 20);
            this.txbBusinessPassword.TabIndex = 21;
            this.txbBusinessPassword.UseSystemPasswordChar = true;
            // 
            // txbHoursTotal
            // 
            this.txbHoursTotal.Location = new System.Drawing.Point(197, 209);
            this.txbHoursTotal.Name = "txbHoursTotal";
            this.txbHoursTotal.ReadOnly = true;
            this.txbHoursTotal.Size = new System.Drawing.Size(129, 20);
            this.txbHoursTotal.TabIndex = 20;
            // 
            // txbHoursThisWeek
            // 
            this.txbHoursThisWeek.Location = new System.Drawing.Point(197, 171);
            this.txbHoursThisWeek.Name = "txbHoursThisWeek";
            this.txbHoursThisWeek.ReadOnly = true;
            this.txbHoursThisWeek.Size = new System.Drawing.Size(129, 20);
            this.txbHoursThisWeek.TabIndex = 19;
            // 
            // lblHoursTotal
            // 
            this.lblHoursTotal.AutoSize = true;
            this.lblHoursTotal.Location = new System.Drawing.Point(197, 193);
            this.lblHoursTotal.Name = "lblHoursTotal";
            this.lblHoursTotal.Size = new System.Drawing.Size(61, 13);
            this.lblHoursTotal.TabIndex = 18;
            this.lblHoursTotal.Text = "Hours total:";
            // 
            // lblHoursThisWeek
            // 
            this.lblHoursThisWeek.AutoSize = true;
            this.lblHoursThisWeek.Location = new System.Drawing.Point(197, 156);
            this.lblHoursThisWeek.Name = "lblHoursThisWeek";
            this.lblHoursThisWeek.Size = new System.Drawing.Size(86, 13);
            this.lblHoursThisWeek.TabIndex = 17;
            this.lblHoursThisWeek.Text = "Hours this week:";
            // 
            // btnViewEmployeeSale
            // 
            this.btnViewEmployeeSale.Enabled = false;
            this.btnViewEmployeeSale.Location = new System.Drawing.Point(338, 283);
            this.btnViewEmployeeSale.Name = "btnViewEmployeeSale";
            this.btnViewEmployeeSale.Size = new System.Drawing.Size(159, 20);
            this.btnViewEmployeeSale.TabIndex = 16;
            this.btnViewEmployeeSale.Text = "View";
            this.btnViewEmployeeSale.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeSales
            // 
            this.lblEmployeeSales.AutoSize = true;
            this.lblEmployeeSales.Location = new System.Drawing.Point(338, 156);
            this.lblEmployeeSales.Name = "lblEmployeeSales";
            this.lblEmployeeSales.Size = new System.Drawing.Size(36, 13);
            this.lblEmployeeSales.TabIndex = 15;
            this.lblEmployeeSales.Text = "Sales:";
            // 
            // lsbEmployeeSales
            // 
            this.lsbEmployeeSales.FormattingEnabled = true;
            this.lsbEmployeeSales.Location = new System.Drawing.Point(338, 171);
            this.lsbEmployeeSales.Name = "lsbEmployeeSales";
            this.lsbEmployeeSales.Size = new System.Drawing.Size(160, 108);
            this.lsbEmployeeSales.TabIndex = 14;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(338, 133);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.ReadOnly = true;
            this.txbLastName.Size = new System.Drawing.Size(160, 20);
            this.txbLastName.TabIndex = 13;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(338, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last name:";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(197, 133);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.ReadOnly = true;
            this.txbFirstName.Size = new System.Drawing.Size(129, 20);
            this.txbFirstName.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(197, 118);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First name:";
            // 
            // txbStaffID
            // 
            this.txbStaffID.Location = new System.Drawing.Point(197, 95);
            this.txbStaffID.Name = "txbStaffID";
            this.txbStaffID.ReadOnly = true;
            this.txbStaffID.Size = new System.Drawing.Size(91, 20);
            this.txbStaffID.TabIndex = 9;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(197, 80);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(46, 13);
            this.lblStaffID.TabIndex = 8;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(6, 3);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(81, 13);
            this.lblBusinessName.TabIndex = 7;
            this.lblBusinessName.Text = "Business name:";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(10, 283);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(60, 20);
            this.btnRemoveEmployee.TabIndex = 6;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(76, 283);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(81, 20);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add New";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(9, 54);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(101, 23);
            this.lblEmployees.TabIndex = 4;
            this.lblEmployees.Text = "Employees";
            // 
            // lsbEmployees
            // 
            this.lsbEmployees.FormattingEnabled = true;
            this.lsbEmployees.Location = new System.Drawing.Point(10, 80);
            this.lsbEmployees.Name = "lsbEmployees";
            this.lsbEmployees.Size = new System.Drawing.Size(147, 199);
            this.lsbEmployees.TabIndex = 3;
            this.lsbEmployees.SelectedIndexChanged += new System.EventHandler(this.lsbEmployees_SelectedIndexChanged);
            // 
            // btnBusinessNameEdit
            // 
            this.btnBusinessNameEdit.Location = new System.Drawing.Point(229, 18);
            this.btnBusinessNameEdit.Name = "btnBusinessNameEdit";
            this.btnBusinessNameEdit.Size = new System.Drawing.Size(64, 20);
            this.btnBusinessNameEdit.TabIndex = 2;
            this.btnBusinessNameEdit.Text = "Edit";
            this.btnBusinessNameEdit.UseVisualStyleBackColor = true;
            this.btnBusinessNameEdit.Click += new System.EventHandler(this.btnBusinessNameEdit_Click);
            // 
            // txbBusinessName
            // 
            this.txbBusinessName.Location = new System.Drawing.Point(6, 18);
            this.txbBusinessName.Name = "txbBusinessName";
            this.txbBusinessName.ReadOnly = true;
            this.txbBusinessName.Size = new System.Drawing.Size(217, 20);
            this.txbBusinessName.TabIndex = 1;
            // 
            // tbpSales
            // 
            this.tbpSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpSales.Controls.Add(this.lblSalesperson);
            this.tbpSales.Controls.Add(this.cmbSalesperson);
            this.tbpSales.Controls.Add(this.label2);
            this.tbpSales.Controls.Add(this.lblCart);
            this.tbpSales.Controls.Add(this.lsbSearchItems);
            this.tbpSales.Controls.Add(this.btnEditItem);
            this.tbpSales.Controls.Add(this.lblSearchBy);
            this.tbpSales.Controls.Add(this.btnRemoveItem);
            this.tbpSales.Controls.Add(this.btnAddItem);
            this.tbpSales.Controls.Add(this.pnlSearchBy);
            this.tbpSales.Controls.Add(this.splcTransaction);
            this.tbpSales.Controls.Add(this.txbSearch);
            this.tbpSales.Location = new System.Drawing.Point(4, 22);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSales.Size = new System.Drawing.Size(506, 313);
            this.tbpSales.TabIndex = 1;
            this.tbpSales.Text = "Sales";
            this.tbpSales.UseVisualStyleBackColor = true;
            this.tbpSales.Click += new System.EventHandler(this.tbpSales_Click);
            // 
            // lblSalesperson
            // 
            this.lblSalesperson.AutoSize = true;
            this.lblSalesperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesperson.Location = new System.Drawing.Point(257, 10);
            this.lblSalesperson.Name = "lblSalesperson";
            this.lblSalesperson.Size = new System.Drawing.Size(68, 13);
            this.lblSalesperson.TabIndex = 14;
            this.lblSalesperson.Text = "Salesperson:";
            // 
            // cmbSalesperson
            // 
            this.cmbSalesperson.FormattingEnabled = true;
            this.cmbSalesperson.Location = new System.Drawing.Point(331, 8);
            this.cmbSalesperson.Name = "cmbSalesperson";
            this.cmbSalesperson.Size = new System.Drawing.Size(158, 21);
            this.cmbSalesperson.TabIndex = 13;
            this.cmbSalesperson.TextUpdate += new System.EventHandler(this.cmbSalesperson_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Avalible Items";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCart.Location = new System.Drawing.Point(203, 3);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(45, 23);
            this.lblCart.TabIndex = 7;
            this.lblCart.Text = "Cart";
            // 
            // lsbSearchItems
            // 
            this.lsbSearchItems.FormattingEnabled = true;
            this.lsbSearchItems.Location = new System.Drawing.Point(9, 77);
            this.lsbSearchItems.Name = "lsbSearchItems";
            this.lsbSearchItems.Size = new System.Drawing.Size(181, 199);
            this.lsbSearchItems.TabIndex = 12;
            this.lsbSearchItems.SelectedIndexChanged += new System.EventHandler(this.lsbSearchItems_SelectedIndexChanged);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(71, 283);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(57, 20);
            this.btnEditItem.TabIndex = 11;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(132, 10);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(58, 13);
            this.lblSearchBy.TabIndex = 5;
            this.lblSearchBy.Text = "Search by:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(9, 283);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(57, 20);
            this.btnRemoveItem.TabIndex = 10;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(132, 283);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(58, 20);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "New";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pnlSearchBy
            // 
            this.pnlSearchBy.Controls.Add(this.rbtnName);
            this.pnlSearchBy.Controls.Add(this.rbtnBarcode);
            this.pnlSearchBy.Controls.Add(this.rbtnCategory);
            this.pnlSearchBy.Location = new System.Drawing.Point(9, 26);
            this.pnlSearchBy.Name = "pnlSearchBy";
            this.pnlSearchBy.Size = new System.Drawing.Size(180, 21);
            this.pnlSearchBy.TabIndex = 8;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnName.Location = new System.Drawing.Point(3, 3);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(48, 16);
            this.rbtnName.TabIndex = 2;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnBarcode
            // 
            this.rbtnBarcode.AutoSize = true;
            this.rbtnBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBarcode.Location = new System.Drawing.Point(57, 3);
            this.rbtnBarcode.Name = "rbtnBarcode";
            this.rbtnBarcode.Size = new System.Drawing.Size(57, 16);
            this.rbtnBarcode.TabIndex = 3;
            this.rbtnBarcode.Text = "Barcode";
            this.rbtnBarcode.UseVisualStyleBackColor = true;
            // 
            // rbtnCategory
            // 
            this.rbtnCategory.AutoSize = true;
            this.rbtnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCategory.Location = new System.Drawing.Point(121, 3);
            this.rbtnCategory.Name = "rbtnCategory";
            this.rbtnCategory.Size = new System.Drawing.Size(61, 16);
            this.rbtnCategory.TabIndex = 4;
            this.rbtnCategory.Text = "Category";
            this.rbtnCategory.UseVisualStyleBackColor = true;
            // 
            // splcTransaction
            // 
            this.splcTransaction.Location = new System.Drawing.Point(207, 35);
            this.splcTransaction.Name = "splcTransaction";
            this.splcTransaction.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcTransaction.Panel1
            // 
            this.splcTransaction.Panel1.Controls.Add(this.btnCartRemove);
            this.splcTransaction.Panel1.Controls.Add(this.lsbCart);
            this.splcTransaction.Panel1.Controls.Add(this.lblCartDiscountPercentage);
            this.splcTransaction.Panel1.Controls.Add(this.txbCartDiscountPercentage);
            this.splcTransaction.Panel1.Controls.Add(this.lblCartDiscountDollar);
            this.splcTransaction.Panel1.Controls.Add(this.txbCartDiscountDollar);
            this.splcTransaction.Panel1.Controls.Add(this.btnCartAdd);
            // 
            // splcTransaction.Panel2
            // 
            this.splcTransaction.Panel2.Controls.Add(this.btnProcessSale);
            this.splcTransaction.Panel2.Controls.Add(this.btnPrintReceipt);
            this.splcTransaction.Panel2.Controls.Add(this.label3);
            this.splcTransaction.Panel2.Controls.Add(this.rtxbTransaction);
            this.splcTransaction.Panel2.Controls.Add(this.txbTotalDiscountPercentage);
            this.splcTransaction.Panel2.Controls.Add(this.txbTotalDiscountDollar);
            this.splcTransaction.Panel2.Controls.Add(this.label4);
            this.splcTransaction.Size = new System.Drawing.Size(286, 268);
            this.splcTransaction.SplitterDistance = 130;
            this.splcTransaction.SplitterWidth = 3;
            this.splcTransaction.TabIndex = 7;
            // 
            // btnCartRemove
            // 
            this.btnCartRemove.Location = new System.Drawing.Point(37, 87);
            this.btnCartRemove.Name = "btnCartRemove";
            this.btnCartRemove.Size = new System.Drawing.Size(27, 27);
            this.btnCartRemove.TabIndex = 7;
            this.btnCartRemove.Text = "<<";
            this.btnCartRemove.UseVisualStyleBackColor = true;
            this.btnCartRemove.Click += new System.EventHandler(this.btnCartRemove_Click);
            // 
            // lsbCart
            // 
            this.lsbCart.FormattingEnabled = true;
            this.lsbCart.Location = new System.Drawing.Point(69, 6);
            this.lsbCart.Name = "lsbCart";
            this.lsbCart.Size = new System.Drawing.Size(213, 121);
            this.lsbCart.TabIndex = 6;
            this.lsbCart.SelectedIndexChanged += new System.EventHandler(this.lsbCart_SelectedIndexChanged);
            this.lsbCart.SizeChanged += new System.EventHandler(this.lsbCart_SizeChanged);
            // 
            // lblCartDiscountPercentage
            // 
            this.lblCartDiscountPercentage.AutoSize = true;
            this.lblCartDiscountPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartDiscountPercentage.Location = new System.Drawing.Point(6, 45);
            this.lblCartDiscountPercentage.Name = "lblCartDiscountPercentage";
            this.lblCartDiscountPercentage.Size = new System.Drawing.Size(58, 12);
            this.lblCartDiscountPercentage.TabIndex = 5;
            this.lblCartDiscountPercentage.Text = "Discount (%)";
            // 
            // txbCartDiscountPercentage
            // 
            this.txbCartDiscountPercentage.Location = new System.Drawing.Point(4, 61);
            this.txbCartDiscountPercentage.Name = "txbCartDiscountPercentage";
            this.txbCartDiscountPercentage.Size = new System.Drawing.Size(59, 20);
            this.txbCartDiscountPercentage.TabIndex = 4;
            this.txbCartDiscountPercentage.Leave += new System.EventHandler(this.txbCartDiscountPercentage_Leave);
            // 
            // lblCartDiscountDollar
            // 
            this.lblCartDiscountDollar.AutoSize = true;
            this.lblCartDiscountDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartDiscountDollar.Location = new System.Drawing.Point(6, 6);
            this.lblCartDiscountDollar.Name = "lblCartDiscountDollar";
            this.lblCartDiscountDollar.Size = new System.Drawing.Size(55, 12);
            this.lblCartDiscountDollar.TabIndex = 3;
            this.lblCartDiscountDollar.Text = "Discount ($)";
            // 
            // txbCartDiscountDollar
            // 
            this.txbCartDiscountDollar.Location = new System.Drawing.Point(4, 22);
            this.txbCartDiscountDollar.Name = "txbCartDiscountDollar";
            this.txbCartDiscountDollar.Size = new System.Drawing.Size(59, 20);
            this.txbCartDiscountDollar.TabIndex = 2;
            this.txbCartDiscountDollar.Leave += new System.EventHandler(this.txbCartDiscountDollar_Leave);
            // 
            // btnCartAdd
            // 
            this.btnCartAdd.Location = new System.Drawing.Point(4, 87);
            this.btnCartAdd.Name = "btnCartAdd";
            this.btnCartAdd.Size = new System.Drawing.Size(27, 27);
            this.btnCartAdd.TabIndex = 1;
            this.btnCartAdd.Text = ">>";
            this.btnCartAdd.UseVisualStyleBackColor = true;
            this.btnCartAdd.Click += new System.EventHandler(this.btnCartAdd_Click);
            // 
            // btnProcessSale
            // 
            this.btnProcessSale.Location = new System.Drawing.Point(213, 112);
            this.btnProcessSale.Name = "btnProcessSale";
            this.btnProcessSale.Size = new System.Drawing.Size(69, 20);
            this.btnProcessSale.TabIndex = 14;
            this.btnProcessSale.Text = "Process";
            this.btnProcessSale.UseVisualStyleBackColor = true;
            this.btnProcessSale.Click += new System.EventHandler(this.btnProcessSale_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(134, 112);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(76, 20);
            this.btnPrintReceipt.TabIndex = 13;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Discount (%)";
            // 
            // rtxbTransaction
            // 
            this.rtxbTransaction.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbTransaction.Location = new System.Drawing.Point(4, 4);
            this.rtxbTransaction.Name = "rtxbTransaction";
            this.rtxbTransaction.ReadOnly = true;
            this.rtxbTransaction.Size = new System.Drawing.Size(278, 92);
            this.rtxbTransaction.TabIndex = 0;
            this.rtxbTransaction.Text = "";
            this.rtxbTransaction.WordWrap = false;
            // 
            // txbTotalDiscountPercentage
            // 
            this.txbTotalDiscountPercentage.Location = new System.Drawing.Point(69, 112);
            this.txbTotalDiscountPercentage.Name = "txbTotalDiscountPercentage";
            this.txbTotalDiscountPercentage.Size = new System.Drawing.Size(59, 20);
            this.txbTotalDiscountPercentage.TabIndex = 10;
            this.txbTotalDiscountPercentage.Leave += new System.EventHandler(this.txbTotalDiscountPercentage_Leave);
            // 
            // txbTotalDiscountDollar
            // 
            this.txbTotalDiscountDollar.Location = new System.Drawing.Point(4, 112);
            this.txbTotalDiscountDollar.Name = "txbTotalDiscountDollar";
            this.txbTotalDiscountDollar.Size = new System.Drawing.Size(59, 20);
            this.txbTotalDiscountDollar.TabIndex = 8;
            this.txbTotalDiscountDollar.Leave += new System.EventHandler(this.txbTotalDiscountDollar_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Discount ($)";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(9, 53);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(181, 20);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // tbpReporting
            // 
            this.tbpReporting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpReporting.Controls.Add(this.lblBusinessDayExplanation);
            this.tbpReporting.Controls.Add(this.lblSelectionExplanation);
            this.tbpReporting.Controls.Add(this.btnGenerateReport);
            this.tbpReporting.Controls.Add(this.lblOnStaff);
            this.tbpReporting.Controls.Add(this.lsbClockedIn);
            this.tbpReporting.Controls.Add(this.lblBusinessDaySalesArrow);
            this.tbpReporting.Controls.Add(this.rtxbSaleData);
            this.tbpReporting.Controls.Add(this.lblSalesMade);
            this.tbpReporting.Controls.Add(this.lsbBusinessDaySales);
            this.tbpReporting.Controls.Add(this.lsbBusinessDays);
            this.tbpReporting.Controls.Add(this.lblBusinessDays);
            this.tbpReporting.Location = new System.Drawing.Point(4, 22);
            this.tbpReporting.Name = "tbpReporting";
            this.tbpReporting.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReporting.Size = new System.Drawing.Size(506, 313);
            this.tbpReporting.TabIndex = 2;
            this.tbpReporting.Text = "Reporting";
            this.tbpReporting.UseVisualStyleBackColor = true;
            this.tbpReporting.Click += new System.EventHandler(this.tbpReporting_Click);
            // 
            // lblBusinessDayExplanation
            // 
            this.lblBusinessDayExplanation.AutoSize = true;
            this.lblBusinessDayExplanation.Location = new System.Drawing.Point(182, 277);
            this.lblBusinessDayExplanation.Name = "lblBusinessDayExplanation";
            this.lblBusinessDayExplanation.Size = new System.Drawing.Size(314, 13);
            this.lblBusinessDayExplanation.TabIndex = 18;
            this.lblBusinessDayExplanation.Text = "Business Days are generated when the last employee clocks out.";
            // 
            // lblSelectionExplanation
            // 
            this.lblSelectionExplanation.AutoSize = true;
            this.lblSelectionExplanation.Location = new System.Drawing.Point(166, 290);
            this.lblSelectionExplanation.Name = "lblSelectionExplanation";
            this.lblSelectionExplanation.Size = new System.Drawing.Size(330, 13);
            this.lblSelectionExplanation.TabIndex = 17;
            this.lblSelectionExplanation.Text = "Shift-click to select a range of business days, then generate a report.";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(10, 278);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 25);
            this.btnGenerateReport.TabIndex = 16;
            this.btnGenerateReport.Text = "Report from Selection";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // lblOnStaff
            // 
            this.lblOnStaff.AutoSize = true;
            this.lblOnStaff.Location = new System.Drawing.Point(7, 184);
            this.lblOnStaff.Name = "lblOnStaff";
            this.lblOnStaff.Size = new System.Drawing.Size(49, 13);
            this.lblOnStaff.TabIndex = 15;
            this.lblOnStaff.Text = "On Staff:";
            // 
            // lsbClockedIn
            // 
            this.lsbClockedIn.FormattingEnabled = true;
            this.lsbClockedIn.Location = new System.Drawing.Point(10, 200);
            this.lsbClockedIn.Name = "lsbClockedIn";
            this.lsbClockedIn.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbClockedIn.Size = new System.Drawing.Size(120, 69);
            this.lsbClockedIn.TabIndex = 14;
            // 
            // lblBusinessDaySalesArrow
            // 
            this.lblBusinessDaySalesArrow.AutoSize = true;
            this.lblBusinessDaySalesArrow.Location = new System.Drawing.Point(132, 88);
            this.lblBusinessDaySalesArrow.Name = "lblBusinessDaySalesArrow";
            this.lblBusinessDaySalesArrow.Size = new System.Drawing.Size(13, 13);
            this.lblBusinessDaySalesArrow.TabIndex = 12;
            this.lblBusinessDaySalesArrow.Text = ">";
            // 
            // rtxbSaleData
            // 
            this.rtxbSaleData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbSaleData.Location = new System.Drawing.Point(218, 31);
            this.rtxbSaleData.Name = "rtxbSaleData";
            this.rtxbSaleData.ReadOnly = true;
            this.rtxbSaleData.Size = new System.Drawing.Size(278, 238);
            this.rtxbSaleData.TabIndex = 11;
            this.rtxbSaleData.Text = "";
            this.rtxbSaleData.WordWrap = false;
            // 
            // lblSalesMade
            // 
            this.lblSalesMade.AutoSize = true;
            this.lblSalesMade.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSalesMade.Location = new System.Drawing.Point(165, 5);
            this.lblSalesMade.Name = "lblSalesMade";
            this.lblSalesMade.Size = new System.Drawing.Size(105, 23);
            this.lblSalesMade.TabIndex = 10;
            this.lblSalesMade.Text = "Sales Made";
            // 
            // lsbBusinessDaySales
            // 
            this.lsbBusinessDaySales.FormattingEnabled = true;
            this.lsbBusinessDaySales.Location = new System.Drawing.Point(146, 31);
            this.lsbBusinessDaySales.Name = "lsbBusinessDaySales";
            this.lsbBusinessDaySales.Size = new System.Drawing.Size(66, 238);
            this.lsbBusinessDaySales.TabIndex = 9;
            this.lsbBusinessDaySales.SelectedIndexChanged += new System.EventHandler(this.lsbBusinessDaySales_SelectedIndexChanged);
            // 
            // lsbBusinessDays
            // 
            this.lsbBusinessDays.FormattingEnabled = true;
            this.lsbBusinessDays.Location = new System.Drawing.Point(10, 31);
            this.lsbBusinessDays.Name = "lsbBusinessDays";
            this.lsbBusinessDays.Size = new System.Drawing.Size(120, 147);
            this.lsbBusinessDays.TabIndex = 8;
            this.lsbBusinessDays.SelectedIndexChanged += new System.EventHandler(this.lsbBusinessDays_SelectedIndexChanged);
            // 
            // lblBusinessDays
            // 
            this.lblBusinessDays.AutoSize = true;
            this.lblBusinessDays.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBusinessDays.Location = new System.Drawing.Point(6, 5);
            this.lblBusinessDays.Name = "lblBusinessDays";
            this.lblBusinessDays.Size = new System.Drawing.Size(127, 23);
            this.lblBusinessDays.TabIndex = 7;
            this.lblBusinessDays.Text = "Business Days";
            // 
            // printDialogTransaction
            // 
            this.printDialogTransaction.Document = this.printDocumentTransaction;
            this.printDialogTransaction.UseEXDialog = true;
            // 
            // printDocumentTransaction
            // 
            this.printDocumentTransaction.DocumentName = "Receipt";
            this.printDocumentTransaction.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTransaction_PrintPage);
            // 
            // printPreviewTransaction
            // 
            this.printPreviewTransaction.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewTransaction.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewTransaction.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewTransaction.Document = this.printDocumentTransaction;
            this.printPreviewTransaction.Enabled = true;
            this.printPreviewTransaction.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewTransaction.Icon")));
            this.printPreviewTransaction.Name = "printPreviewTransaction";
            this.printPreviewTransaction.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(535, 382);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "SRaPS V_1.0.7 (Prototype)";
            this.tbcMain.ResumeLayout(false);
            this.tbpBusiness.ResumeLayout(false);
            this.tbpBusiness.PerformLayout();
            this.tbpSales.ResumeLayout(false);
            this.tbpSales.PerformLayout();
            this.pnlSearchBy.ResumeLayout(false);
            this.pnlSearchBy.PerformLayout();
            this.splcTransaction.Panel1.ResumeLayout(false);
            this.splcTransaction.Panel1.PerformLayout();
            this.splcTransaction.Panel2.ResumeLayout(false);
            this.splcTransaction.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcTransaction)).EndInit();
            this.splcTransaction.ResumeLayout(false);
            this.tbpReporting.ResumeLayout(false);
            this.tbpReporting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpBusiness;
        private System.Windows.Forms.TabPage tbpSales;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ListBox lsbEmployees;
        private System.Windows.Forms.Button btnBusinessNameEdit;
        private System.Windows.Forms.TextBox txbBusinessName;
        private System.Windows.Forms.TabPage tbpReporting;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.TextBox txbHoursTotal;
        private System.Windows.Forms.TextBox txbHoursThisWeek;
        private System.Windows.Forms.Label lblHoursTotal;
        private System.Windows.Forms.Label lblHoursThisWeek;
        private System.Windows.Forms.Button btnViewEmployeeSale;
        private System.Windows.Forms.Label lblEmployeeSales;
        private System.Windows.Forms.ListBox lsbEmployeeSales;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txbStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblBusinessPassword;
        private System.Windows.Forms.Button btnBusinessPasswordEdit;
        private System.Windows.Forms.TextBox txbBusinessPassword;
        private System.Windows.Forms.Button btnEmployeeEdit;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Label lblEmployeePassword;
        private System.Windows.Forms.Button btnEmployeePasswordEdit;
        private System.Windows.Forms.TextBox txbEmployeePassword;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.RadioButton rbtnCategory;
        private System.Windows.Forms.RadioButton rbtnBarcode;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.SplitContainer splcTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSearchBy;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.ListBox lsbSearchItems;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblCartDiscountPercentage;
        private System.Windows.Forms.TextBox txbCartDiscountPercentage;
        private System.Windows.Forms.Label lblCartDiscountDollar;
        private System.Windows.Forms.TextBox txbCartDiscountDollar;
        private System.Windows.Forms.Button btnCartAdd;
        private System.Windows.Forms.ListBox lsbCart;
        private System.Windows.Forms.Button btnCartRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxbTransaction;
        private System.Windows.Forms.TextBox txbTotalDiscountPercentage;
        private System.Windows.Forms.TextBox txbTotalDiscountDollar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintDialog printDialogTransaction;
        private System.Drawing.Printing.PrintDocument printDocumentTransaction;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewTransaction;
        private System.Windows.Forms.ComboBox cmbSalesperson;
        private System.Windows.Forms.Label lblSalesperson;
        private System.Windows.Forms.Button btnProcessSale;
        private System.Windows.Forms.ListBox lsbBusinessDaySales;
        private System.Windows.Forms.ListBox lsbBusinessDays;
        private System.Windows.Forms.Label lblBusinessDays;
        private System.Windows.Forms.Label lblBusinessDaySalesArrow;
        private System.Windows.Forms.RichTextBox rtxbSaleData;
        private System.Windows.Forms.Label lblSalesMade;
        private System.Windows.Forms.ListBox lsbClockedIn;
        private System.Windows.Forms.Label lblOnStaff;
        private System.Windows.Forms.Label lblEmployeeDetails;
        private System.Windows.Forms.Label lblSelectionExplanation;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblBusinessDayExplanation;
    }
}

