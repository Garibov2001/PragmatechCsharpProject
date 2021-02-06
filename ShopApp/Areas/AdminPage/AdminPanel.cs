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
            LoadFeedbacks();
            LoadBuysSells();
            FillSearchCategories(cmb_products_search);
            LoadAllCategories();
        }
        public void LoadAllCategories(Expression<Func<ProductCategory, bool>> expression = null)
        {
            var categories = expression == null
                ? _unitOfWork.ProductCategories.GetAll()
                : _unitOfWork.ProductCategories.GetAll(expression);

            List<dynamic> wholeCategories = new List<dynamic>();

            foreach (var category in categories)
            {
                wholeCategories.Add(new
                {
                    ID = category.ID,
                    CategoryName = category.Name,                    
                });
            }
            // Hide the id in the grid

            // Hide the id in the grid
            dgw_categories.Columns.Clear();
            dgw_categories.DataSource = wholeCategories;

            //Because of out of index exception
            if (dgw_categories.Columns.Count > 0)
            {
                dgw_categories.Columns[0].Visible = false;

                //Edit Button:
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.HeaderText = "Editlemek";
                editBtn.Name = "edit_btn";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;

                dgw_categories.Columns.Add(editBtn);
                //Remove Button:
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Silmek";
                deleteBtn.Name = "delete_btn";
                deleteBtn.Text = "Sil";
                deleteBtn.UseColumnTextForButtonValue = true;

                dgw_categories.Columns.Add(deleteBtn);
            }
        }

        public void LoadBuysSells(Expression<Func<PurchaseLog, bool>> expression = null)
        {
            var purchases = expression == null
                ? _unitOfWork.PurchaseLogs.GetAll()
                : _unitOfWork.PurchaseLogs.GetAll(expression);

            List<dynamic> wholePurchases = new List<dynamic>();

            foreach (var purchase in purchases)
            {
                var product = _unitOfWork.Products.Get(x => x.ID == purchase.ProductID);
                var seller = _unitOfWork.Users.Get(x => x.ID == product.UserID);
                var buyer = _unitOfWork.Users.Get(x => x.ID == purchase.UserID);
                var product_category = _unitOfWork.ProductCategories.Get(x => x.ID == product.ProductCategoryID);

                wholePurchases.Add(new
                {
                    ID = product.ID,
                    ProductName = product.Name,
                    ProductCategory = product_category.Name,
                    ProductPrice = product.Price,
                    ProductCount = product.Count,
                    ProductStatus = (ProductStatus)product.ProductStatus,
                    Buyer = buyer.Name + " " + buyer.Surname,
                    Seller = seller.Name + " " + seller.Surname,
                    PurchaseDate = purchase.PurchaseDate,
                });
            }
            // Hide the id in the grid

            // Hide the id in the grid
            dgw_buyssells.Columns.Clear();
            dgw_buyssells.DataSource = wholePurchases;

            //Because of out of index exception
            if (dgw_buyssells.Columns.Count > 0)
            {
                dgw_buyssells.Columns[0].Visible = false;
            }
        }


        public void LoadFeedbacks(Expression<Func<OperationLog, bool>> expression = null)
        {
            var logs = expression == null
                ? _unitOfWork.OperationLogs.GetAll()
                : _unitOfWork.OperationLogs.GetAll(expression);

            List<dynamic> wholeLogs = new List<dynamic>();

            foreach (var log in logs)
            {
                var product = _unitOfWork.Products.Get(x => x.ID == log.ProductID);
                var product_owner = _unitOfWork.Users.Get(x => x.ID == product.UserID);
                var product_category = _unitOfWork.ProductCategories.Get(x => x.ID == product.ProductCategoryID);


                wholeLogs.Add(new
                {
                    ID = product.ID,
                    ProductName = product.Name,
                    ProductCategory = product_category.Name,
                    ProductPrice = product.Price,
                    ProductCount = product.Count,
                    ProductStatus = (ProductStatus)product.ProductStatus,
                    Owner = product_owner.Name + " " + product_owner.Surname,
                    OperationDescrip = log.OperationDescription,
                    OperationStatus = (OperationStatus)log.OperationStatus,
                    OperationDate = log.OperationDate,
                });
            }
            // Hide the id in the grid

            // Hide the id in the grid
            dgw_feedbacks.Columns.Clear();
            dgw_feedbacks.DataSource = wholeLogs;

            //Because of out of index exception
            if (dgw_feedbacks.Columns.Count > 0)
            {
                dgw_feedbacks.Columns[0].Visible = false;               
            }
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
            txb_products_search.Text = string.Empty;
            cmb_products_search.Items.Clear();
            FillSearchCategories(cmb_products_search);
            LoadProducts();
        }

        private void dgw_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                //Check button:
                if (buttonCell != null && dgv.Columns[buttonCell.ColumnIndex].Name == "edit_btn")
                {
                    var productID = (int)dgv.CurrentRow.Cells["ID"].Value;
                    var product = _unitOfWork.Products.Get(x => x.ID == productID);
                    var editProductForm = new AdmEditProductForm(product);
                    editProductForm.ShowDialog();                 
                }
                else if (buttonCell != null && dgv.Columns[buttonCell.ColumnIndex].Name == "delete_btn")
                {
                    var productID = (int)dgv.CurrentRow.Cells["ID"].Value;
                    var product = _unitOfWork.Products.Get(x => x.ID == productID);
                    if (product.ProductStatus == (int)ProductStatus.Deleted)
                    {
                        MessageBox.Show("Bu product artiq siliib", "Yalnışlıqların düzəldin.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    var remProdForm = new AdmDeleteProductForm(product);
                    remProdForm.ShowDialog();
                }

                LoadProducts();
            }
        }

        private void dgw_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                //Check button:
                if (buttonCell != null && dgv.Columns[buttonCell.ColumnIndex].Name == "edit_btn")
                {
                    var categoryID = (int)dgv.CurrentRow.Cells["ID"].Value;
                    var category = _unitOfWork.ProductCategories.Get(x => x.ID == categoryID);

                    var editCate = new AdmEditCategoryForm(category);
                    editCate.ShowDialog();
                }
                else if (buttonCell != null && dgv.Columns[buttonCell.ColumnIndex].Name == "delete_btn")
                {
                    var result = MessageBox.Show("Bunu etmek istediyinden eminsen?", "Kategoriyani silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var categoryID = (int)dgv.CurrentRow.Cells["ID"].Value;
                        var category = _unitOfWork.ProductCategories.Get(x => x.ID == categoryID);
                        _unitOfWork.ProductCategories.Delete(category);
                    }                                        
                }

                LoadProducts();
                LoadFeedbacks();
                LoadBuysSells();
                LoadAllCategories();
                cmb_products_search.Items.Clear();
                FillSearchCategories(cmb_products_search);
            }

        }

        private void btn_addCtegory_Click(object sender, EventArgs e)
        {
            var addForm = new AdmAddCategoryForm();
            addForm.ShowDialog();

            LoadProducts();
            LoadFeedbacks();
            LoadBuysSells();
            LoadAllCategories();
            cmb_products_search.Items.Clear();
            FillSearchCategories(cmb_products_search);
        }

        private void btn_admAddProduct_Click(object sender, EventArgs e)
        {
            var addProduct = new AdmAddProductForm();
            addProduct.ShowDialog();
            LoadProducts();
        }
    }
}
