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

            validationResult.Add(AddProductFormValidation.IsValidName(txb_name.Text, feedback));
            validationResult.Add(AddProductFormValidation.IsValidPrice(txb_price.Text, feedback));
            validationResult.Add(AddProductFormValidation.IsValidCount(txb_count.Text, feedback));
            validationResult.Add(AddProductFormValidation.IsValidCategory(cmb_category.SelectedItem, feedback));

            var test = cmb_category.SelectedItem;

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
    }

}
