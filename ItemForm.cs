using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRaPS
{
    public partial class ItemForm : Form
    {
        private MainForm _mainForm;
        private Item _item;

        BindingSource categoriesBindingSource = new BindingSource();

        public ItemForm(MainForm mainForm, Item item)
        {
            _mainForm = mainForm;
            _item = item;

            InitializeComponent();

            categoriesBindingSource.DataSource = mainForm.business.Categories;
            cmbCategory.DataSource = categoriesBindingSource;

            Refill();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            _item.Name = txbName.Text;
            _item.RRP = Convert.ToDouble(txbRRP.Text);
            _item.DiscountDollar = Convert.ToDouble(txbDiscountDollar.Text);
            _item.DiscountPercentage = Convert.ToDouble(txbDiscountPercentage.Text);
            _item.Category = cmbCategory.Text;
            _mainForm.RefillSales();
            Close();
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm(_mainForm);
            categoriesForm.Show();
        }

        public void Refill()
        {
            txbItemID.Text = _item.ItemID.ToString();
            txbName.Text = _item.Name;
            txbRRP.Text = _item.RRP.ToString();
            txbDiscountDollar.Text = _item.DiscountDollar.ToString();
            txbDiscountPercentage.Text = _item.DiscountPercentage.ToString();
            categoriesBindingSource.ResetBindings(false);
        }

        private void cmbCategory_DropDown(object sender, EventArgs e)
        {
            categoriesBindingSource.ResetBindings(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
