using SalesManagement.Entities.Authentication;
using ShopApp.Controls.Authentication;
using ShopApp.Controls.Products;
using ShopApp.DataAccessLayer;
using ShopApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void LoadAllProducts()
        {
            var products = _unitOfWork.Products.GetAll();

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
                    Status = (ProductStatus)product.ProductStatus,
                });
            }
            // Hide the id in the grid

            dgw_allProducts.Columns.Clear();
            dgw_allProducts.DataSource = wholeProducts;

            //Because of out of index exception
            if (dgw_allProducts.Columns.Count > 0)
            {
                dgw_allProducts.Columns[0].Visible = false;

            }
        }

        private void LoadPersonalProducts()
        {
            var products = _unitOfWork.Products.GetAll(x => x.UserID == CurrentUser.ID);

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
                editBtn.Name = "Editlemek";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;

                dgw_myProducts.Columns.Add(editBtn);
                //Remove Button:
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Silmek";
                deleteBtn.Name = "Silmek";
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
            // 0 - edit (because of datagrid bug i have to write or condition)
            if (e.ColumnIndex == 0 || e.ColumnIndex == dgw_myProducts.Columns.Count - 2)
            {
                foreach (DataGridViewCell cell in dgw_myProducts.CurrentRow.Cells)
                {
                    string name = dgw_myProducts.Columns[cell.ColumnIndex].Name;
                    if (name == "ID")
                    {
                        var productID = (int)cell.Value;
                        var product = _unitOfWork.Products.Get(x => x.ID == productID);

                        var editProductForm = new EditProductForm(product);
                        editProductForm.ShowDialog();                        
                        break;
                    }
                }
            }
            // 1 - remove
            else if (e.ColumnIndex == 1 || e.ColumnIndex == dgw_myProducts.Columns.Count - 1)
            {
                var result = MessageBox.Show("Bunu etmek istediyinden eminsen?", "Mehsulu silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewCell cell in dgw_myProducts.CurrentRow.Cells) 
                    {
                        string name = dgw_myProducts.Columns[cell.ColumnIndex].Name;
                        if (name == "ID")
                        {
                            var productID = (int)cell.Value;
                            var product = _unitOfWork.Products.Get(x => x.ID == productID);
                            _unitOfWork.Products.Delete(product);
                            break;
                        }
                    }                                            
                }
            }                           

            LoadAllProducts();
            LoadPersonalProducts();
        }



    }
}
