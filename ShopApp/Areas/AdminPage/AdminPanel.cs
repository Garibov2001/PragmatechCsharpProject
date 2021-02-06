using SalesManagement.Entities.Authentication;
using ShopApp.Areas.AdminPage.Authentication;
using ShopApp.Areas.AdminPage.Products;
using ShopApp.DataAccessLayer;
using ShopApp.Entities.Conrete.Product;
using ShopApp.Enums;
using ShopApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Areas.AdminPage
{
    public partial class AdminPanel : Form
    {
        private UnitOfWork _unitOfWork;
        private static AdminLoginForm LoginForm { get; set; }
        public static User CurrentUser { get; set; }
        public AdminPanel(AdminLoginForm _loginForm)
        {
            _unitOfWork = new UnitOfWork();
            LoginForm = _loginForm;
            LoginForm.Hide();
            InitializeComponent();
            LoadProducts();
            FillSearchCategories(cmb_products_search);
        }
        public void LoadProducts(Expression<Func<Product, bool>> expression = null)
        {
            var products = expression == null
                ? _unitOfWork.Products.GetAll()
                : _unitOfWork.Products.GetAll(expression);

            List<dynamic> wholeProducts = new List<dynamic>();

            foreach (var product in products)
            {
                var owner = _unitOfWork.Users.Get(x => x.ID == product.UserID);
                var category = _unitOfWork.ProductCategories.Get(x => x.ID == product.ProductCategoryID);

                wholeProducts.Add(new
                {
                    ID = product.ID,
                    ProductName = product.Name,
                    ProductCategory = category.Name,
                    ProductPrice = product.Price,
                    ProductCount = product.Count,
                    Owner = owner.Name + " " + owner.Surname,
                    OwnerTel = owner.PhoneNumber,
                    Status = (ProductStatus)product.ProductStatus
                });
            }
            // Hide the id in the grid

            // Hide the id in the grid
            dgw_products.Columns.Clear();
            dgw_products.DataSource = wholeProducts;

            //Because of out of index exception
            if (dgw_products.Columns.Count > 0)
            {
                dgw_products.Columns[0].Visible = false;

                //Edit Button:
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.HeaderText = "Editlemek";
                editBtn.Name = "edit_btn";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;

                dgw_products.Columns.Add(editBtn);
                //Remove Button:
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Silmek";
                deleteBtn.Name = "delete_btn";
                deleteBtn.Text = "Sil";
                deleteBtn.UseColumnTextForButtonValue = true;

                dgw_products.Columns.Add(deleteBtn);
            }
        }
        private void FillSearchCategories(ComboBox argController)
        {
            argController.Items.Add(new ComboboxItem { Value = -1, Text = " -- Bütün məhsullar --" });

            var categories = _unitOfWork.ProductCategories.GetAll();

            foreach (var category in categories)
            {
                argController.Items.Add(new ComboboxItem { Value = category.ID, Text = category.Name });
            }

            foreach (ComboboxItem item in argController.Items)
            {
                if ((int)item.Value == -1)
                {
                    argController.SelectedIndex = argController.Items.IndexOf(item);
                    break;
                }
            }
        }       
        private void txb_products_search_TextChanged(object sender, EventArgs e)
        {
            // Initialize the search combo box wih category "Butun mehsullar"
            foreach (ComboboxItem item in cmb_products_search.Items)
            {
                if ((int)item.Value == -1)
                {
                    cmb_products_search.SelectedIndex = cmb_products_search.Items.IndexOf(item);
                    break;
                }
            }

            if (string.IsNullOrEmpty(txb_products_search.Text))
                LoadProducts();
            else
                LoadProducts(x => x.Name.Contains(txb_products_search.Text));
        }
        private void cmb_products_search_SelectedValueChanged(object sender, EventArgs e)
        {
            //Initialize search text box
            txb_products_search.Text = string.Empty;

            int category_id = (int)(cmb_products_search.SelectedItem as ComboboxItem).Value;

            // Condition is necessery because we have "Butun mehsullar" category
            if (category_id > 0)
                LoadProducts(x => x.ProductCategoryID == category_id);
            else
                LoadProducts();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Close();
        }

        private void btn_products_detailed_search_Click(object sender, EventArgs e)
        {
            AdmDetailedSearchForm searchForm = new AdmDetailedSearchForm(this);
            searchForm.Show();
        }

        private void btn__products_refresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
