using SalesManagement.Entities.Authentication;
using ShopApp.Controls.Authentication;
using ShopApp.DataAccessLayer;
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

namespace ShopApp.Areas.AdminPage.Authentication
{
    public partial class AdminLoginForm : Form
    {
        private UnitOfWork _unitOfWork;
        private static LoginForm LoginForm { get; set; }
        public static User CurrentUser { get; set; }
        public AdminLoginForm(LoginForm _loginForm)
        {
            _unitOfWork = new UnitOfWork();
            LoginForm = _loginForm;
            LoginForm.Hide();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var user = AdminLoginFormValidation.CheckAccount(txb_password.Text, txb_email.Text);

            if (user == null)
            {
                MessageBox.Show("Email və ya şifrə yalnışdır", "Bildiris", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_password.Text = String.Empty;
                return;
            }


            MessageBox.Show("Qeseng");
            var admPanel = new AdminPanel(this);
            admPanel.Show();
        }

        private void AdminLoginForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            LoginForm.Close();
        }
    }
}
