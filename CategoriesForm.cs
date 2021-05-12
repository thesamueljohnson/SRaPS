using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRaPS
{
    public partial class CategoriesForm : Form
    {
        private MainForm _mainForm;

        BindingSource categoriesBindingSource = new BindingSource();
        public CategoriesForm(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();

            categoriesBindingSource.DataSource = mainForm.business.Categories;
            Refill();
            //lsbCategories.DisplayMember = "Name";
            lsbCategories.DataSource = categoriesBindingSource;
        }

        public void Refill()
        {
            categoriesBindingSource.ResetBindings(false);

            if (lsbCategories.SelectedIndex >= 0 && lsbCategories.SelectedIndex < lsbCategories.Items.Count)
            {
                txbCategoryName.Text = _mainForm.business.Categories[lsbCategories.SelectedIndex];
            }
            else
            {
                txbCategoryName.Text = "";
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            _mainForm.business.AddCategory("New Category");
            categoriesBindingSource.ResetBindings(false);
            lsbCategories.SelectedIndex = lsbCategories.Items.Count-1;
            Refill();
        }

        private void btnCategoryNameEdit_Click(object sender, EventArgs e)
        {
            //Make sure a category is selected
            if (lsbCategories.Items.Count > 0)
            {
                if (txbCategoryName.ReadOnly)
                {
                    txbCategoryName.ReadOnly = false;
                    btnCategoryNameEdit.Text = "Save";
                }
                else
                {
                    txbCategoryName.ReadOnly = true;
                    btnCategoryNameEdit.Text = "Edit";
                    if (txbCategoryName.Text != "")
                        _mainForm.business.UpdateCategory(lsbCategories.SelectedIndex, txbCategoryName.Text);
                    Refill();
                }
            }
        }

        private void lsbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refill();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (lsbCategories.Items.Count > 0)
            {
                _mainForm.business.RemoveCategory(lsbCategories.SelectedIndex);
                Refill();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
