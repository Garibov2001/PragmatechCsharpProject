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

namespace ShopApp.Controls.Authentication
{
    public partial class LoginForm : Form
    {
        private UnitOfWork unitOfWork;
        public LoginForm()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var user = unitOfWork.Users.CheckAccount(txb_password.Text, txb_email.Text);

            if (user == null)
            {
                MessageBox.Show("Daxil etdiyiniz sifre ve ya email yalnisdir", "Yalnisi duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_password.Text = String.Empty;
                return;
            }


            AccountForm.CurrentUser = user;

            var accountForm = new AccountForm(this);
            accountForm.Show();
        }
    }

}
