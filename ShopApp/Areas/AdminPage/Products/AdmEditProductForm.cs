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
    public partial class AdmEditProductForm : Form
    {
        private UnitOfWork _unitOfWork;
        private Product _product;
        public AdmEditProductForm(Product argProduct)
        {
            _product = argProduct;
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
            FillTheFields();
        }

        private void FillTheFields()
        {
            txb_edit_name.Text = _product.Name;
            txb_edit_count.Text = _product.Count.ToString();
            txb_edit_price.Text = _product.Price.ToString();
            FillTheCategories(_product.ProductCategoryID);
            FillTheStatuses(_product.ProductStatus);
        }

        private void FillTheCategories(int argCategoryID)
        {
            var categories = _unitOfWork.ProductCategories.GetAll();

            foreach (var category in categories)
            {
                cmb_edit_category.Items.Add(new ComboboxItem { Value = category.ID, Text = category.Name });
                if (category.ID == argCategoryID)
                {
                    cmb_edit_category.SelectedIndex = categories.IndexOf(category);
                }
            }
        }

        private void FillTheStatuses(int argStatusID)
        {
            cmb_edit_status.Items.Add(new ComboboxItem { Value = (int)ProductStatus.Passiv, Text = ProductStatus.Passiv.ToString() });
            cmb_edit_status.Items.Add(new ComboboxItem { Value = (int)ProductStatus.Aktiv, Text = ProductStatus.Aktiv.ToString() });
            cmb_edit_status.Items.Add(new ComboboxItem { Value = (int)ProductStatus.Deleted, Text = ProductStatus.Deleted.ToString() });

            cmb_edit_status.SelectedIndex = argStatusID;
        }        

        private void btn_saveProduct_Click(object sender, EventArgs e)
        {
            List<bool> validationResult = new List<bool>();

            var feedback = new StringBuilder();
            validationResult.Add(AdminEditProductFormValidation.IsValidName(txb_edit_name.Text, feedback));
            validationResult.Add(AdminEditProductFormValidation.IsValidPrice(txb_edit_price.Text, feedback));
            validationResult.Add(AdminEditProductFormValidation.IsValidCount(txb_edit_count.Text, feedback));
            validationResult.Add(AdminEditProductFormValidation.IsValidReason(rtb_reason.Text, feedback));


            if (validationResult.Any(elem => elem == false))
            {
                MessageBox.Show(feedback.ToString(), "Yalnışlıqların düzəldin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var edittedProduct = new Product
            {
                ID = _product.ID,
                Name = txb_edit_name.Text,
                Count = Convert.ToInt32(txb_edit_count.Text),
                Price = Convert.ToInt32(txb_edit_price.Text),
                ProductCategoryID = (int)(cmb_edit_category.SelectedItem as ComboboxItem).Value,
                UserID = _product.UserID,
                ProductStatus = (int)(cmb_edit_status.SelectedItem as ComboboxItem).Value,
            };

            var newLog = new OperationLog
            {
                OperationDate = DateTime.Now,
                ProductID = _product.ID,
                UserID = AdminPanel.CurrentUser.ID,
                OperationDescription = rtb_reason.Text,
                OperationStatus = (int)OperationStatus.Edit
            };

            _unitOfWork.Products.Update(edittedProduct);

            _unitOfWork.OperationLogs.Create(newLog);

            this.Close();
        }
    }
}
