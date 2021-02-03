using ShopApp.DataAccessLayer;
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
    public partial class DetailedSearchForm : Form
    {
        public AccountForm AccountForm { get; set; }
        private bool IsFromPersonal { get; set; }
        private UnitOfWork _unitOfWork;
        public DetailedSearchForm(AccountForm argForm, bool argFromPersonal)
        {
            IsFromPersonal = argFromPersonal;
            AccountForm = argForm;
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
            FillSearchCategories();
        }

        private void FillSearchCategories()
        {
            var categories = _unitOfWork.ProductCategories.GetAll();

            foreach (var category in categories)
            {
                cmb_categories.Items.Add(new ComboboxItem { Value = category.ID, Text = category.Name });
            }            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<bool> validationResult = new List<bool>();

            var feedback = new StringBuilder();

            validationResult.Add(ProductFormValidation.IsValidName(txb_name.Text, feedback));
            validationResult.Add(ProductFormValidation.IsValidCategory(cmb_categories.SelectedItem, feedback));
            validationResult.Add(ProductFormValidation.IsValidPrice(txb_price.Text, feedback));
            validationResult.Add(ProductFormValidation.IsValidCount(txb_count.Text, feedback));

            if (validationResult.Any(elem => elem == false))
            {
                MessageBox.Show(feedback.ToString(), "Yalnışlıqların düzəldin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txb_name.Text;
            int category_id = (int)(cmb_categories.SelectedItem as ComboboxItem).Value;
            int count = Convert.ToInt32(txb_count.Text);
            int price = Convert.ToInt32(txb_price.Text);
           
            if (IsFromPersonal)
            {
                //Initilaize other search components:
                AccountForm.txb_my_products_search.Text = String.Empty;

                // Initialize the search combo box wih category "Butun mehsullar"
                foreach (ComboboxItem item in AccountForm.cmb_my_products_search.Items)
                {
                    if ((int)item.Value == -1)
                    {
                        AccountForm.cmb_my_products_search.SelectedIndex = AccountForm.cmb_my_products_search.Items.IndexOf(item);
                        break;
                    }
                }

                AccountForm.LoadPersonalProducts(x => 
                x.UserID == AccountForm.CurrentUser.ID && 
                x.Name == name && 
                x.Price == price &&
                x.Count == count && 
                x.ProductCategoryID == category_id);

                this.Close();            
            }
            else
            {
                AccountForm.LoadAllProducts(x =>
               x.Name == name &&
               x.Price == price &&
               x.Count == count &&
               x.ProductCategoryID == category_id);

               this.Close();
            }

        }
    }
}
