using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRaPS
{
    public partial class MainForm : Form
    {
        public Business business = new Business("Default Business", "admin");
        BindingSource staffBindingSource = new BindingSource();
        BindingSource itemsBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();

            //Setup business screen
            staffBindingSource.DataSource = business.Staff;
            RefillBusiness();
            lsbEmployees.DisplayMember = "FullName";
            lsbEmployees.DataSource = staffBindingSource;

            //Setup sales screen
            itemsBindingSource.DataSource = business.Items;
            RefillSales();
            lsbSearchItems.DisplayMember = "Name";
            lsbSearchItems.DataSource = itemsBindingSource;
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
            itemsBindingSource.ResetBindings(false);
            lsbSearchItems.SelectedIndex = lsbSearchItems.Items.Count - 1;
            RefillSales();
            ItemForm itemForm = new ItemForm(this, item);
            itemForm.Show();
        }

        public void RefillSales()
        {
            itemsBindingSource.ResetBindings(false);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (lsbSearchItems.Items.Count > 0)
            {
                ItemForm itemForm = new ItemForm(this, business.Items[lsbSearchItems.SelectedIndex]);
                itemForm.Show();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lsbSearchItems.Items.Count > 0) {
                business.RemoveItem(lsbSearchItems.SelectedIndex);
                RefillSales();
            }
        }
    }
}
