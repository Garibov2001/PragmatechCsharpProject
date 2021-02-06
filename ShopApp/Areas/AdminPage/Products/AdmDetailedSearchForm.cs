using ShopApp.Controls;
using ShopApp.DataAccessLayer;
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
    public partial class AdmDetailedSearchForm : Form
    {
        public AdminPanel AdmPanel { get; set; }
        private UnitOfWork _unitOfWork;
        
        public AdmDetailedSearchForm(AdminPanel adminPanel)
        {
            AdmPanel = adminPanel;
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
            FillSearchCategories();
            FillOwnerCategories();
            FillProductStatusCategories();
        }


        private void FillSearchCategories()
        {
            var categories = _unitOfWork.ProductCategories.GetAll();

            foreach (var category in categories)
            {
                cmb_categories.Items.Add(new Utilities.ComboboxItem { Value = category.ID, Text = category.Name });
            }
        }

        private void FillOwnerCategories()
        {
            var role = _unitOfWork.Roles.Get(x => x.Name == "Customer");
            var categories = _unitOfWork.UsersRoles.GetAll(x => x.RoleID == role.ID);


            foreach (var category in categories)
            {
                var user = _unitOfWork.Users.Get(x => x.ID == category.UserID);
                cmb_product_owner.Items.Add(new Utilities.ComboboxItem { Value = user.ID, Text = $"{user.Name} {user.Surname}" });
            }

        }

        private void FillProductStatusCategories()
        {
            cmb_product_status.Items.Add(new Utilities.ComboboxItem { Value = (int)ProductStatus.Aktiv, Text = ProductStatus.Aktiv.ToString() });
            cmb_product_status.Items.Add(new Utilities.ComboboxItem { Value = (int)ProductStatus.Passiv, Text = ProductStatus.Passiv.ToString() });
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<bool> validationResult = new List<bool>();

            var feedback = new StringBuilder();

            validationResult.Add(AdminDetailedSearchValidation.IsValidName(txb_name.Text, feedback));
            validationResult.Add(AdminDetailedSearchValidation.IsValidCategory(cmb_categories.SelectedItem, feedback));
            validationResult.Add(AdminDetailedSearchValidation.IsValidPrice(txb_price.Text, feedback));
            validationResult.Add(AdminDetailedSearchValidation.IsValidCount(txb_count.Text, feedback));
            validationResult.Add(AdminDetailedSearchValidation.IsValidOwner(cmb_product_owner.SelectedItem, feedback));
            validationResult.Add(AdminDetailedSearchValidation.IsValidProductStatus(cmb_product_status.Text, feedback));

            if (validationResult.Any(elem => elem == false))
            {
                MessageBox.Show(feedback.ToString(), "Yalnışlıqların düzəldin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txb_name.Text;
            int category_id = (int)(cmb_categories.SelectedItem as ComboboxItem).Value;
            int price = Convert.ToInt32(txb_price.Text);
            int count = Convert.ToInt32(txb_count.Text);
            int owner_id = (int)(cmb_product_owner.SelectedItem as ComboboxItem).Value;
            int product_status_id = (int)(cmb_product_status.SelectedItem as ComboboxItem).Value;

            this.AdmPanel.LoadProducts(x =>
                x.Name == name && x.ProductCategoryID == category_id && x.Price == price &&
                x.Count == count && x.UserID == owner_id && x.ProductStatus == product_status_id);
        }
    }
}
