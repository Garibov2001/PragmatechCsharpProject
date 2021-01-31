using SalesManagement.Entities.Authentication;
using ShopApp.Controls.Authentication;
using ShopApp.Controls.Products;
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
        private static LoginForm LoginForm { get; set; }
        public static User CurrentUser { get; set; }
        public AccountForm(LoginForm _loginForm)
        {
            LoginForm = _loginForm;
            
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoginForm.Hide();
            lbl_name_surname.Text += CurrentUser.Name + " " + CurrentUser.Surname;
            lbl_email.Text += CurrentUser.Email;
            lbl_phone.Text += CurrentUser.PhoneNumber;
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Close();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
    }
}
