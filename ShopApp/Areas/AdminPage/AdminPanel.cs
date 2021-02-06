using SalesManagement.Entities.Authentication;
using ShopApp.Areas.AdminPage.Authentication;
using ShopApp.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Close();
        }
    }
}
