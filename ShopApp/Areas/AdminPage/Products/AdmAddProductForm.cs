using ShopApp.DataAccessLayer;
using ShopApp.Entities.Conrete.Product;
using ShopApp.Enums;
using ShopApp.Utilities;
using ShopApp.Utilities.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Areas.AdminPage.Products
{
    public partial class AdmAddProductForm : Form
    {
        private UnitOfWork _unitOfWork;
        public AdmAddProductForm()
        {
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
            FillTheCategories();
            FillTheUsers();
        }

        private void FillTheCategories()
        {
            var categories = _unitOfWork.ProductCategories.GetAll();

            foreach (var category in categories)
            {
                cmb_category.Items.Add(new ComboboxItem { Value = category.ID, Text = category.Name });
            }
        }

        private void FillTheUsers()
        {
            var role = _unitOfWork.Roles.Get(x => x.Name == "Customer");
            var categories = _unitOfWork.UsersRoles.GetAll(x => x.RoleID == role.ID);


            foreach (var category in categories)
            {
                var user = _unitOfWork.Users.Get(x => x.ID == category.UserID);
                cmb_user.Items.Add(new ComboboxItem { Value = user.ID, Text = $"{user.Name} {user.Surname}" });
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            List<bool> validationResult = new List<bool>();

            var feedback = new StringBuilder();

            validationResult.Add(AdminAddProductFormValidation.IsValidName(txb_name.Text, feedback));
            validationResult.Add(AdminAddProductFormValidation.IsValidPrice(txb_price.Text, feedback));
            validationResult.Add(AdminAddProductFormValidation.IsValidCount(txb_count.Text, feedback));
            validationResult.Add(AdminAddProductFormValidation.IsValidCategory(cmb_category.SelectedItem, feedback));
            validationResult.Add(AdminAddProductFormValidation.IsValidUser(cmb_user.SelectedItem, feedback));

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
                UserID = (int)(cmb_user.SelectedItem as ComboboxItem).Value,
                ProductStatus = (int)ProductStatus.Aktiv,
            };

            _unitOfWork.Products.Create(newProduct);
            MessageBox.Show("Məhsul uğurla əlavə olundu", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
