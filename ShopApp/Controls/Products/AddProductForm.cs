using ShopApp.DataAccessLayer;
using ShopApp.Entities.Conrete.Product;
using ShopApp.Enums;
using ShopApp.Utilities;
using ShopApp.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Controls.Products
{
    public partial class AddProductForm : Form
    {
        private UnitOfWork _unitOfWork;
        public AddProductForm()
        {
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
            FillTheCategories();
        }

        private void FillTheCategories()
        {
            
            var categories = _unitOfWork.ProductCategories.GetAll();

            foreach (var category in categories)
            {
                cmb_category.Items.Add(new ComboboxItem { Value = category.ID, Text = category.Name});
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            List<bool> validationResult = new List<bool>();

            var feedback = new StringBuilder();

            validationResult.Add(ProductFormValidation.IsValidName(txb_name.Text, feedback));
            validationResult.Add(ProductFormValidation.IsValidPrice(txb_price.Text, feedback));
            validationResult.Add(ProductFormValidation.IsValidCount(txb_count.Text, feedback));
            validationResult.Add(ProductFormValidation.IsValidCategory(cmb_category.SelectedItem, feedback));

            if (validationResult.Any(elem => elem == false))
            {
                MessageBox.Show(feedback.ToString(), "Yalnışlıqların düzəldin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newProduct = new Product
            {
                Name = txb_name.Text,
                Count = Convert.ToInt32(txb_count.Text),
                Price = Convert.ToInt32(txb_price.Text),
                ProductCategoryID = (int)(cmb_category.SelectedItem as ComboboxItem).Value,
                UserID = AccountForm.CurrentUser.ID,
                ProductStatus = (int)ProductStatus.Aktiv,                
            };

            _unitOfWork.Products.Create(newProduct);
            MessageBox.Show("Məhsul uğurla əlavə olundu", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_category_Click(object sender, EventArgs e)
        {

        }

        private void txb_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_count_Click(object sender, EventArgs e)
        {

        }

        private void txb_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
