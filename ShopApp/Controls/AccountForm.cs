using SalesManagement.Entities.Authentication;
using ShopApp.Controls.Authentication;
using ShopApp.Controls.Products;
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

namespace ShopApp.Controls
{
    public partial class AccountForm : Form
    {
        private UnitOfWork _unitOfWork;
        private static LoginForm LoginForm { get; set; }
        public static User CurrentUser { get; set; }
        public AccountForm(LoginForm _loginForm)
        {
            _unitOfWork = new UnitOfWork();
            LoginForm = _loginForm;
            InitializeComponent();
            FillSearchCategories(cmb_my_products_search);
            FillSearchCategories(cmb_all_products_search);
            LoadPersonalPurchases();
            LoadPersonalSales();
            LoadAdminFeedbacks();
        }

        public void LoadAdminFeedbacks(Expression<Func<OperationLog, bool>> expression = null)
        {
            var products = _unitOfWork.Products.GetAll(x => x.UserID == CurrentUser.ID);
            IEnumerable<int> extract = from product in products select product.ID;

            var logs = expression == null
                ? _unitOfWork.OperationLogs.GetAll((x => extract.Contains(x.ProductID)))
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
                    OperationDescrip = log.OperationDescription,
                    OperationStatus = (OperationStatus)log.OperationStatus,
                    OperationDate = log.OperationDate,
                });
            }

            // Hide the id in the grid
            dgw_admin_feedbacks.Columns.Clear();
            dgw_admin_feedbacks.DataSource = wholeLogs;

            //Because of out of index exception
            if (dgw_admin_feedbacks.Columns.Count > 0)
            {
                dgw_admin_feedbacks.Columns[0].Visible = false;
            }
        }
        private void LoadPersonalSales()
        {
            var products = _unitOfWork.Products.GetAll(x => x.UserID == CurrentUser.ID);
            IEnumerable<int> extract = from product in products select product.ID;
            var purchases = _unitOfWork.PurchaseLogs.GetAll(x => extract.Contains(x.ProductID));

            List<dynamic> wholePurchases = new List<dynamic>();

            foreach (var purchase in purchases)
            {
                var product = _unitOfWork.Products.Get(x => x.ID == purchase.ProductID);
                var buyer = _unitOfWork.Users.Get(x => x.ID == purchase.UserID);

                wholePurchases.Add(new
                {
                    ID = purchase.ID,
                    ProductName = product.Name,
                    ProductCategory = _unitOfWork.ProductCategories.Get(x => x.ID == product.ProductCategoryID).Name,
                    ProductPrice = product.Price,
                    PurchaseCount = 1,
                    Buyer = buyer.Name + " " + buyer.Surname,
                    BuyerTel = buyer.PhoneNumber,
                    PurchaseDate = purchase.PurchaseDate.Date
                });
            }
            // Hide the id in the grid

            // Hide the id in the grid
            dgw_mySales.Columns.Clear();
            dgw_mySales.DataSource = wholePurchases;

            if (dgw_mySales.Columns.Count > 0)
            {
                dgw_mySales.Columns[0].Visible = false;
            }
        }


        private void LoadPersonalPurchases()
        {
            var purchases = _unitOfWork.PurchaseLogs.GetAll(x => x.UserID == CurrentUser.ID);

            List<dynamic> wholePurchases = new List<dynamic>();

            foreach (var purchase in purchases)
            {
                var product = _unitOfWork.Products.Get(x => x.ID == purchase.ProductID);
                var seller = _unitOfWork.Users.Get(x => x.ID == product.UserID);

                wholePurchases.Add(new
                {
                    ID = purchase.ID,
                    ProductName = product.Name,
                    ProductCategory = _unitOfWork.ProductCategories.Get(x => x.ID == product.ProductCategoryID).Name,
                    ProductPrice = product.Price,
                    PurchaseCount = 1,
                    Seller = seller.Name + " " + seller.Surname,
                    SellerTel = seller.PhoneNumber,
                    PurchaseDate = purchase.PurchaseDate.Date
                });
            }
            // Hide the id in the grid

            // Hide the id in the grid
            dgw_myPurchases.Columns.Clear();
            dgw_myPurchases.DataSource = wholePurchases;

            if (dgw_myPurchases.Columns.Count > 0)
            {
                dgw_myPurchases.Columns[0].Visible = false;
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

        public void LoadAllProducts(Expression<Func<Product, bool>> expression = null)
        {
            // Only Aktiv products:
            var products = expression == null
                ? _unitOfWork.Products.GetAll(x => x.ProductStatus == (int)ProductStatus.Aktiv && x.Count > 0)
                : _unitOfWork.Products.GetAll(expression);

            List<dynamic> wholeProducts = new List<dynamic>();

            foreach (var product in products)
            {
                wholeProducts.Add(new
                {
                    ID = product.ID,
                    ProductName = product.Name,
                    Category = _unitOfWork.ProductCategories.Get(x => x.ID == product.ProductCategoryID).Name,
                    Price = product.Price,
                    User = _unitOfWork.Users.Get(x => x.ID == product.UserID).Name + " " + _unitOfWork.Users.Get(x => x.ID == product.UserID).Surname,
                    UserTel = _unitOfWork.Users.Get(x => x.ID == product.UserID).PhoneNumber,
                    Count = product.Count,
                });
            }
            // Hide the id in the grid

            // Hide the id in the grid
            dgw_allProducts.Columns.Clear();
            dgw_allProducts.DataSource = wholeProducts;

            //Because of out of index exception
            if (dgw_allProducts.Columns.Count > 0)
            {
                dgw_allProducts.Columns[0].Visible = false;

                //Edit Button:
                DataGridViewButtonColumn purchaseBtn = new DataGridViewButtonColumn();
                purchaseBtn.HeaderText = "Satın al";
                purchaseBtn.Name = "purchaseBtn";
                purchaseBtn.Text = "Satın al";
                purchaseBtn.UseColumnTextForButtonValue = true;

                dgw_allProducts.Columns.Add(purchaseBtn);
            }
        }

        public void LoadPersonalProducts(Expression<Func<Product, bool>> expression = null)
        {
            var products = expression == null
                ? _unitOfWork.Products.GetAll(x => x.UserID == CurrentUser.ID)
                : _unitOfWork.Products.GetAll(expression);

            List<dynamic> wholeProducts = new List<dynamic>();

            foreach (var product in products)
            {
                wholeProducts.Add(new
                {
                    ID = product.ID,
                    ProductName = product.Name,
                    Category = _unitOfWork.ProductCategories.Get(x => x.ID == product.ProductCategoryID).Name,
                    Price = product.Price,
                    Count = product.Count,
                    Status = (ProductStatus)product.ProductStatus,
                });
            }

            // Hide the id in the grid
            dgw_myProducts.Columns.Clear();
            dgw_myProducts.DataSource = wholeProducts;

            //Because of out of index exception
            if (dgw_myProducts.Columns.Count > 0)
            {
                dgw_myProducts.Columns[0].Visible = false;

                //Edit Button:
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.HeaderText = "Editlemek";
                editBtn.Name = "edit_btn";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;

                dgw_myProducts.Columns.Add(editBtn);
                //Remove Button:
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Silmek";
                deleteBtn.Name = "delete_btn";
                deleteBtn.Text = "Sil";
                deleteBtn.UseColumnTextForButtonValue = true;

                dgw_myProducts.Columns.Add(deleteBtn);

            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoginForm.Hide();
            lbl_name_surname.Text += CurrentUser.Name + " " + CurrentUser.Surname;
            lbl_email.Text += CurrentUser.Email;
            lbl_phone.Text += CurrentUser.PhoneNumber;
            lbl_balance.Text += CurrentUser.Balance;
            LoadAllProducts();
            LoadPersonalProducts();
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Close();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadAllProducts();
            LoadPersonalProducts();
        }

        private void dgw_myProducts_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    if (product.ProductStatus == (int)ProductStatus.Deleted)
                    {
                        MessageBox.Show("Silinmis mehsulu editlemek mumkun deyil", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    var editProductForm = new EditProductForm(product);
                    editProductForm.ShowDialog();
                }
                else if (buttonCell != null && dgv.Columns[buttonCell.ColumnIndex].Name == "delete_btn")
                {
                    var result = MessageBox.Show("Bunu etmek istediyinden eminsen?", "Mehsulu silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var productID = (int)dgv.CurrentRow.Cells["ID"].Value;
                        var product = _unitOfWork.Products.Get(x => x.ID == productID);

                        if (product.ProductStatus == (int)ProductStatus.Deleted)
                        {
                            MessageBox.Show("Silinmis mehsulu yeniden silmek mumkun deyil", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        product.ProductStatus = (int)ProductStatus.Deleted;
                        _unitOfWork.Products.Update(product);
                    }                  
                }
            }


            LoadAllProducts();
            LoadPersonalProducts();
            LoadPersonalPurchases();
            LoadPersonalSales();
            LoadAdminFeedbacks();
        }

        private void txb_my_products_search_TextChanged(object sender, EventArgs e)
        {
            // Initialize the search combo box wih category "Butun mehsullar"
            foreach (ComboboxItem item in cmb_my_products_search.Items)
            {
                if ((int)item.Value == -1)
                {
                    cmb_my_products_search.SelectedIndex = cmb_my_products_search.Items.IndexOf(item);
                    break;
                }
            }

            if (string.IsNullOrEmpty(txb_my_products_search.Text))
                LoadPersonalProducts();
            else
                LoadPersonalProducts(x =>
                    x.UserID == CurrentUser.ID &&
                    x.Name.Contains(txb_my_products_search.Text));
        }

        private void cmb_my_products_search_SelectedValueChanged(object sender, EventArgs e)
        {
            //Initialize search text box
            txb_my_products_search.Text = string.Empty;

            int category_id = (int)(cmb_my_products_search.SelectedItem as ComboboxItem).Value;

            // Condition is necessery because we have "Butun mehsullar" category
            if (category_id > 0)
                LoadPersonalProducts(x =>
                    x.UserID == CurrentUser.ID &&
                    x.ProductCategoryID == category_id);
            else
                LoadPersonalProducts();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }


        private void txb_all_products_search_TextChanged(object sender, EventArgs e)
        {
            // Initialize the search combo box wih category "Butun mehsullar"
            foreach (ComboboxItem item in cmb_all_products_search.Items)
            {
                if ((int)item.Value == -1)
                {
                    cmb_all_products_search.SelectedIndex = cmb_all_products_search.Items.IndexOf(item);
                    break;
                }
            }

            if (string.IsNullOrEmpty(txb_all_products_search.Text))
                LoadAllProducts();
            else
                LoadAllProducts(x => x.Name.Contains(txb_all_products_search.Text) && x.Count > 0);
        }

        private void cmb_all_products_search_SelectedValueChanged(object sender, EventArgs e)
        {
            //Initialize search text box
            txb_all_products_search.Text = string.Empty;

            int category_id = (int)(cmb_all_products_search.SelectedItem as ComboboxItem).Value;

            // Condition is necessery because we have "Butun mehsullar" category
            if (category_id > 0)
                LoadAllProducts(x => x.ProductCategoryID == category_id && x.Count > 0);
            else
                LoadAllProducts();
        }

        private void btn_detailed_search_Click(object sender, EventArgs e)
        {
            DetailedSearchForm searchForm = new DetailedSearchForm(this, true);
            searchForm.Show();
        }

        private void btn_all_products_detailed_search_Click(object sender, EventArgs e)
        {
            DetailedSearchForm searchForm = new DetailedSearchForm(this, false);
            searchForm.Show();
        }

        private void btn_my_products_refresh_Click(object sender, EventArgs e)
        {
            txb_my_products_search.Text = string.Empty;
            cmb_my_products_search.Items.Clear();
            FillSearchCategories(cmb_my_products_search);
            LoadPersonalProducts();
        }

        private void btn_all_products_refresh_Click(object sender, EventArgs e)
        {
            txb_all_products_search.Text = string.Empty;
            cmb_all_products_search.Items.Clear();
            FillSearchCategories(cmb_all_products_search);
            LoadAllProducts();
        }

        private void dgw_allProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                //Check button:
                if (buttonCell != null && dgv.Columns[buttonCell.ColumnIndex].Name == "purchaseBtn")
                {
                    //Get ID from row                    
                    var productID = (int)dgv.CurrentRow.Cells["ID"].Value;
                    var product = _unitOfWork.Products.Get(x => x.ID == productID);
                    var buyer = CurrentUser;
                    var seller = _unitOfWork.Users.Get(x => x.ID == product.UserID);

                    if (buyer.Balance < product.Price)
                    {
                        MessageBox.Show("Sizin balansinizda kifayet qeder mebleg yoxdur", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (buyer.ID == seller.ID)
                    {
                        MessageBox.Show("Siz oz mehsulunuzu ala bilmersiniz", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Decrease product count
                    product.Count -= 1;
                    _unitOfWork.Products.Update(product);

                    //Increase seller balance (according product price)
                    seller.Balance += product.Price;
                    _unitOfWork.Users.Update(seller);

                    //Decrease buyer balance (according product price)
                    buyer.Balance -= product.Price;
                    _unitOfWork.Users.Update(buyer);

                    //Add this to PurchaseLog

                    var purchLog = new PurchaseLog
                    {
                        ProductID = product.ID,
                        UserID = buyer.ID,
                        PurchaseDate = DateTime.Now,
                    };

                    _unitOfWork.PurchaseLogs.Create(purchLog);

                    //Refresh the pages
                    lbl_balance.Text = $"Balance : {buyer.Balance}";

                    LoadAllProducts();
                    LoadPersonalProducts();
                    LoadPersonalPurchases();
                    LoadPersonalSales();
                    LoadAdminFeedbacks();
                }
            }
        }
    }
}
