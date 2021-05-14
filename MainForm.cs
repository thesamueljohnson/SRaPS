using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PHP_SRaPS
{
    public partial class MainForm : Form
    {
        public Business business = new Business("Default Business", "admin");
        BindingSource staffBindingSource = new BindingSource();
        private string searchType = "Name";

        public MainForm()
        {
            InitializeComponent();

            //Setup business screen
            staffBindingSource.DataSource = business.Staff;
            RefillBusiness();
            lsbEmployees.DisplayMember = "FullName";
            lsbEmployees.DataSource = staffBindingSource;

            //Setup sales screen
            RefillSales();
            lsbSearchItems.DisplayMember = "StockString";
            cmbSalesperson.DisplayMember = "FullName";
            cmbSalesperson.DataSource = staffBindingSource;
            lsbCart.DisplayMember = "CartString";
            rbtnName.CheckedChanged += new EventHandler(searchRadiosChanged);
            rbtnBarcode.CheckedChanged += new EventHandler(searchRadiosChanged);
            rbtnCategory.CheckedChanged += new EventHandler(searchRadiosChanged);

            System.Drawing.Printing.PaperSize paperSize = new System.Drawing.Printing.PaperSize("Receipt", 400, 500);
            printDocumentTransaction.DefaultPageSettings.PaperSize = paperSize;
        }

        //BUSINESS SCREEN ================================================
        private void btnBusinessNameEdit_Click(object sender, EventArgs e)
        {
            if(txbBusinessName.ReadOnly)
            {
                txbBusinessName.ReadOnly = false;
                btnBusinessNameEdit.Text = "Save";
            } else
            {
                txbBusinessName.ReadOnly = true;
                btnBusinessNameEdit.Text = "Edit";
                if(txbBusinessName.Text != "")
                {
                    Authorise("Administrator", business.Password, btnBusinessNameEdit);
                } else
                {
                    txbBusinessName.Text = business.Name;
                }
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (lsbEmployees.Items.Count > 0) {
                if (business.Staff[lsbEmployees.SelectedIndex].FullName != "New Salesperson")
                {
                    Authorise("Administrator", business.Password, btnRemoveEmployee);
                }
                else
                {
                    //Allow user to delete default salespeople without authorising
                    business.Staff.Remove(business.Staff[lsbEmployees.SelectedIndex]);
                    RefillBusiness();
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            business.AddStaff("New", "Salesperson");
            staffBindingSource.ResetBindings(false);
            lsbEmployees.SelectedIndex = lsbEmployees.Items.Count - 1;
            RefillBusiness();
        }

        private void btnBusinessPasswordEdit_Click(object sender, EventArgs e)
        {
            if (txbBusinessPassword.ReadOnly)
            {
                txbBusinessPassword.ReadOnly = false;
                btnBusinessPasswordEdit.Text = "Save";
            }
            else
            {
                txbBusinessPassword.ReadOnly = true;
                btnBusinessPasswordEdit.Text = "Edit";
                if (txbBusinessPassword.Text != "")
                {
                    Authorise("Administrator", business.Password, btnBusinessPasswordEdit);
                }
                else
                {
                    txbBusinessPassword.Text = business.Password;
                }
            }
        }

        private void lsbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbEmployees.SelectedIndex < 0)
            {
                //Empty the employee details if there are no employees
                EmptyEmployeeDetails();
            }
            else
            {
                //Fill in the employee details for the selected employee
                Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
                FillEmployeeDetails(target);
            }
        }

        private void btnEmployeeEdit_Click(object sender, EventArgs e)
        {
            if (btnEmployeeEdit.Text == "Edit Employee")
            {
                txbFirstName.ReadOnly = false;
                txbLastName.ReadOnly = false;
                btnEmployeeEdit.Text = "Save";
            }
            else
            {
                txbFirstName.ReadOnly = true;
                txbLastName.ReadOnly = true;
                btnEmployeeEdit.Text = "Edit Employee";
                if (txbFirstName.Text != "" && txbLastName.Text != "")
                {
                    //Update the business staff object if both textboxes are not empty
                    Authorise("Administrator", business.Password, btnEmployeeEdit);
                } else
                {
                    //If one of the textboxes is empty disregard changes and revert textbox text
                    FillEmployeeDetails(business.Staff[lsbEmployees.SelectedIndex]);
                }
            }
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
            Authorise(target.FullName, target.Password, btnClock);
        }

        public void RefillBusiness()
        {
            //Refill pages with business data
            staffBindingSource.ResetBindings(false);
            txbBusinessName.Text = business.Name;
            txbBusinessPassword.Text = business.Password;
            if (lsbEmployees.SelectedIndex >= 0 && lsbEmployees.SelectedIndex < lsbEmployees.Items.Count)
            {
                FillEmployeeDetails(business.Staff[lsbEmployees.SelectedIndex]);
            } else
            {
                EmptyEmployeeDetails();
            }
        }

        public void FillEmployeeDetails(Salesperson target)
        {
            txbStaffID.Text = target.StaffID.ToString();
            txbEmployeePassword.Text = target.Password;
            txbFirstName.Text = target.FirstName;
            txbLastName.Text = target.LastName;
            txbHoursThisWeek.Text = target.HoursThisWeek.TotalHours.ToString("N2");
            txbHoursTotal.Text = target.HoursTotal.TotalHours.ToString("N2");

            //Reset the clock state if the employee is clocked in/out
            if (target.DayStart == DateTime.MinValue)
            {
                btnClock.Text = "CLOCK IN";
            }
            else
            {
                btnClock.Text = "CLOCK OUT";
            }
            btnClock.Enabled = true;
            btnEmployeeEdit.Enabled = true;
            btnEmployeePasswordEdit.Enabled = true;
            btnViewEmployeeSale.Enabled = true;
        }

        public void EmptyEmployeeDetails()
        {
            txbStaffID.Text = "";
            txbEmployeePassword.Text = "";
            txbFirstName.Text = "";
            txbLastName.Text = "";
            txbHoursThisWeek.Text = "";
            txbHoursTotal.Text = "";
            btnClock.Enabled = false;
            btnEmployeeEdit.Enabled = false;
            btnEmployeePasswordEdit.Enabled = false;
            btnViewEmployeeSale.Enabled = false;
        }

        public void Authorise(string username, string password, object sender)
        {
            //Create a login form which will ask the user for a password
            LoginForm login = new LoginForm(this, username, password, sender);
            login.Show();
            this.Enabled = false;
        }

        public void PostAuthorise(object sender)
        {
            //Do different things depending on who requested the authorisation
            ///Saving change in business name
            if (sender == btnBusinessNameEdit)
                business.Name = txbBusinessName.Text;
            ///Saving change in business password
            if (sender == btnBusinessPasswordEdit)
                business.ChangePassword(txbBusinessPassword.Text);
            ///Saving change in employee data
            if (sender == btnEmployeeEdit)
                business.UpdateStaff(lsbEmployees.SelectedIndex, txbFirstName.Text, txbLastName.Text);
            ///Saving change in employee data
            if (sender == btnEmployeePasswordEdit && lsbEmployees.Items.Count > 0)
                business.Staff[lsbEmployees.SelectedIndex].ChangePassword(txbEmployeePassword.Text);
            //Clocking in or out
            if(sender == btnClock)
            {
                Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
                if (target.DayStart == DateTime.MinValue)
                {
                    btnClock.Text = "CLOCK OUT";
                    target.DayStart = DateTime.Now;
                }
                else
                {
                    btnClock.Text = "CLOCK IN";
                    target.DayEnd = DateTime.Now;
                    target.AddDayHours();
                }
            }
            if(sender == btnRemoveEmployee)
                business.Staff.Remove(business.Staff[lsbEmployees.SelectedIndex]);

            RefillBusiness();
        }

        private void btnEmployeePasswordEdit_Click(object sender, EventArgs e)
        {
            if (txbEmployeePassword.ReadOnly)
            {
                txbEmployeePassword.ReadOnly = false;
                btnEmployeePasswordEdit.Text = "Save";
            }
            else
            {
                txbEmployeePassword.ReadOnly = true;
                btnEmployeePasswordEdit.Text = "Edit";
                if (txbEmployeePassword.Text != "")
                {
                    Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
                    Authorise(target.FullName, target.Password, btnEmployeePasswordEdit);
                }
                else
                {
                    RefillBusiness();
                }
            }
        }

        //SALES SCREEN ==========================================
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item item = business.AddItem("New Unnamed Item");
            lsbSearchItems.SelectedIndex = lsbSearchItems.Items.Count - 1;
            RefillSales();
            ItemForm itemForm = new ItemForm(this, item);
            itemForm.Show();
        }

        public void RefillSales()
        {
            staffBindingSource.ResetBindings(false);
            RefillSearchList();
            RefillCart();
            RefillTransaction();
        }

        public void RefillSearchList()
        {
            lsbSearchItems.Items.Clear();

            foreach (Item item in business.Items)
            {
                if (txbSearch.Text == "")
                {
                    lsbSearchItems.Items.Add(item);
                }
                else
                {
                    switch(searchType)
                    {
                        case ("Name"):
                            if (item.Name.StartsWith(txbSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                                lsbSearchItems.Items.Add(item);
                            break;
                        case ("Barcode"):
                            if (new string(item.Barcode).StartsWith(txbSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                                lsbSearchItems.Items.Add(item);
                            break;
                        case ("Category"):
                            if (item.Category.StartsWith(txbSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                                lsbSearchItems.Items.Add(item);
                            break;
                    }
                }
            }
        }

        public void RefillTransaction()
        {
            rtxbTransaction.Text = "";
            string details = "Thank you for shopping at " + business.Name + "! \n\n";

            foreach(Item item in lsbCart.Items)
            {
                string str = item.Name + " (RRP: " + item.RRP.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + ")\n(Base Discount: -" + item.DiscountDollar.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + ") (Bonus Discount -" + item.BonusDiscountDollar.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + ")\n(" + item.CartQuantity.ToString() + " X " + item.RRP.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + ") Final Price: " + item.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                details += str + "\n\n";
            }

            rtxbTransaction.Text = details;
        }

        public void RefillCart()
        {
            if (lsbCart.Items.Count > 0 && lsbCart.SelectedIndex >= 0)
            {
                Item item = lsbCart.SelectedItem as Item;
                txbCartDiscountDollar.Text = item.BonusDiscountDollar.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                txbCartDiscountPercentage.Text = item.BonusDiscountPercentage.ToString("P", CultureInfo.InvariantCulture);
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (lsbSearchItems.Items.Count > 0 && lsbSearchItems.SelectedIndex >= 0)
            {
                ItemForm itemForm = new ItemForm(this, business.Items[lsbSearchItems.SelectedIndex]);
                itemForm.Show();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lsbSearchItems.Items.Count > 0 && lsbSearchItems.SelectedIndex >= 0) {
                business.RemoveItem(lsbSearchItems.SelectedIndex);
                RefillSales();
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            RefillSearchList();
        }

        private void searchRadiosChanged(object sender, EventArgs e)
        {
            if (rbtnName.Checked)
                searchType = "Name";
            if (rbtnBarcode.Checked)
                searchType = "Barcode";
            if (rbtnCategory.Checked)
                searchType = "Category";
        }

        private void btnCartAdd_Click(object sender, EventArgs e)
        {
            if (lsbSearchItems.Items.Count > 0 && lsbSearchItems.SelectedIndex >= 0)
            {
                Item searchItem = lsbSearchItems.SelectedItem as Item;
                if (searchItem.StockQuantity - searchItem.CartQuantity > 0)
                {
                    if (!lsbCart.Items.Contains(lsbSearchItems.SelectedItem))
                    {
                        //Add the selected search item to cart
                        int index = lsbCart.Items.Add(searchItem);
                        Item cartItem = lsbCart.Items[index] as Item;
                        cartItem.CartQuantity = 1;
                        cartItem.Update();
                    }
                    else
                    {
                        //Incriment the cart item quantity
                        Item cartItem = lsbCart.Items[lsbCart.FindStringExact(searchItem.CartString)] as Item;
                        cartItem.CartQuantity++;
                        cartItem.Update();
                    }

                    //Update the display strings
                    lsbSearchItems.DisplayMember = null;
                    lsbSearchItems.DisplayMember = "StockString";
                    lsbCart.DisplayMember = null;
                    lsbCart.DisplayMember = "CartString";

                    RefillCart();
                    RefillTransaction();
                }
            }
        }

        private void btnCartRemove_Click(object sender, EventArgs e)
        {
            if (lsbCart.Items.Count > 0 && lsbCart.SelectedIndex >= 0)
            {
                Item item = lsbCart.Items[lsbCart.SelectedIndex] as Item;
                item.CartQuantity--;
                item.Update();
                if(item.CartQuantity <= 0)
                    lsbCart.Items.RemoveAt(lsbCart.SelectedIndex);

                //Update the display strings
                lsbSearchItems.DisplayMember = null;
                lsbSearchItems.DisplayMember = "StockString";
                lsbCart.DisplayMember = null;
                lsbCart.DisplayMember = "CartString";

                RefillTransaction();
            }
        }

        private void lsbCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefillCart();
            RefillTransaction();
        }

        private void printDocumentTransaction_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Load in the rich textbox data
            int x = 10;
            int y = 10;
            int charPos = 0;

            while(charPos < rtxbTransaction.Text.Length)
            {
                if(rtxbTransaction.Text[charPos] == '\n')
                {
                    x = 10;
                    y += 20;
                    charPos++;
                }
                else if(rtxbTransaction.Text[charPos] == '\r')
                {
                    charPos++;
                } else
                {
                    rtxbTransaction.Select(charPos, 1);
                    e.Graphics.DrawString(rtxbTransaction.SelectedText, rtxbTransaction.SelectionFont, new SolidBrush(rtxbTransaction.SelectionColor), new PointF(x, y));
                    x += 8;
                    charPos++;
                }
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (printDialogTransaction.ShowDialog() == DialogResult.OK)
            {
                if (printPreviewTransaction.ShowDialog() == DialogResult.OK)
                    printDocumentTransaction.Print();
            }
        }

        private void txbCartDiscountDollar_Leave(object sender, EventArgs e)
        {
            if (lsbCart.Items.Count > 0 && lsbCart.SelectedIndex >= 0)
            {
                double dollar;
                if (txbCartDiscountDollar.Text != "" && Double.TryParse(txbCartDiscountDollar.Text, out dollar))
                {
                    Item item = lsbCart.SelectedItem as Item;
                    double calc = (item.RRP - (item.RRP - dollar)) / item.RRP;
                    item.BonusDiscountPercentage = calc;
                    item.BonusDiscountDollar = dollar;
                    item.Update();
                    RefillCart();
                    RefillTransaction();
                }
            }
        }

        private void txbCartDiscountPercentage_Leave(object sender, EventArgs e)
        {
            if (lsbCart.Items.Count > 0 && lsbCart.SelectedIndex >= 0)
            {
                double percentage;
                if (txbCartDiscountPercentage.Text != "" && Double.TryParse(txbCartDiscountPercentage.Text, out percentage))
                {
                    Item item = lsbCart.SelectedItem as Item;
                    double calc = item.RRP * (percentage / 100);
                    item.BonusDiscountDollar = calc;
                    percentage = percentage / 100; //Not sure why this is needed, but it is
                    item.BonusDiscountPercentage = percentage;
                    item.Update();
                    RefillCart();
                    RefillTransaction();
                }
            }
        }

        private void tbpSales_Click(object sender, EventArgs e)
        {
            RefillSales();
        }

        private void tbpBusiness_Click(object sender, EventArgs e)
        {
            RefillBusiness();
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            if (cmbSalesperson.Items.Count > 0 && lsbCart.Items.Count > 0)
            {
                if (btnProcessSale.Text == "Process")
                {
                    btnProcessSale.Text = "Confirm";
                }
                else
                {
                    //Construct and save the sale
                    Salesperson salesperson = cmbSalesperson.SelectedItem as Salesperson;
                    Sale sale = new Sale(salesperson);
                    for(var i = 0; i < lsbCart.Items.Count; i++)
                    {
                        Item item = lsbCart.Items[i] as Item;
                        item.StockQuantity -= item.CartQuantity;

                        Item duplicateItem = new Item(0, "");
                        duplicateItem.Duplicate(item);
                        duplicateItem.StockQuantity = 0;
                        sale.Items.Add(duplicateItem);

                        item.CartQuantity = 0;
                        item.Update();
                    }

                    lsbCart.Items.Clear();
                    btnProcessSale.Text = "Process";
                    RefillSales();
                }
            }
        }
    }
}
