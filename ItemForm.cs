using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

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
            _item.RRP = Double.Parse(txbRRP.Text, NumberStyles.Currency);
            _item.DiscountDollar = Double.Parse(txbDiscountDollar.Text, NumberStyles.Currency);
            _item.DiscountPercentage = Double.Parse(txbDiscountPercentage.Text.Replace("%", "")) / 100;
            _item.Category = cmbCategory.Text;
            _item.Barcode = txbBarcode.Text.ToCharArray();
            _item.StockQuantity = Convert.ToInt32(nudStockQuantity.Value);
            _item.Update();
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
            txbRRP.Text = _item.RRP.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            txbDiscountDollar.Text = _item.DiscountDollar.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            txbDiscountPercentage.Text = _item.DiscountPercentage.ToString("P", CultureInfo.InvariantCulture);
            categoriesBindingSource.ResetBindings(false);
            txbBarcode.Text = new string(_item.Barcode);
            nudStockQuantity.Value = _item.StockQuantity;
        }

        private void cmbCategory_DropDown(object sender, EventArgs e)
        {
            categoriesBindingSource.ResetBindings(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbDiscountPercentage_Leave(object sender, EventArgs e)
        {
            double percentage;
            if (txbDiscountPercentage.Text != "" && Double.TryParse(txbDiscountPercentage.Text, out percentage))
            {
                double rrp = Double.Parse(txbRRP.Text, NumberStyles.Currency);
                double calc = rrp * (percentage / 100);
                string output = calc.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                txbDiscountDollar.Text = output;
                percentage = percentage / 100; //Not sure why this is needed, but it is
                txbDiscountPercentage.Text = percentage.ToString("P", CultureInfo.InvariantCulture);
            }
        }

        private void txbDiscountDollar_Leave(object sender, EventArgs e)
        {
            double dollar;
            if (txbDiscountDollar.Text != "" && Double.TryParse(txbDiscountDollar.Text, out dollar))
            {
                double rrp = Double.Parse(txbRRP.Text, NumberStyles.Currency);
                double calc = (rrp - (rrp - dollar)) / rrp;
                string output = calc.ToString("P", CultureInfo.InvariantCulture);
                txbDiscountPercentage.Text = output;
                txbDiscountDollar.Text = dollar.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void txbRRP_Leave(object sender, EventArgs e)
        {
            double rrp;
            if (txbRRP.Text != "" && Double.TryParse(txbRRP.Text, out rrp))
                txbRRP.Text = rrp.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
