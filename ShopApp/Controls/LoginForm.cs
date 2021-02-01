using ShopApp.Controls;
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

namespace ShopApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Zehmet olmasa Password ve Usernamei doldurun");
                return;
            }

            if (!CheckUsername(usernameTextBox.Text))
            {
                MessageBox.Show("Daxil etdiyiniz username sistemde yoxdur");
                return;
            }

            if (!CheckPassword(usernameTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Daxil etdiyiniz sifre yalnisdir");
                passwordTextBox.Text = String.Empty;
                return;
            }

            BookForm bookForm = new BookForm(this);
            bookForm.Show();
        }


        private bool CheckUsername(string argUsername)
        {
            var users = Database.Users.GetAll();

            foreach (var user in users)
            {
                if (user.UserName == argUsername)
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckPassword(string argUsername, string argPassword)
        {
            var users = Database.Users.GetAll();

            foreach (var user in users)
            {
                if (user.UserName == argUsername)
                {
                    if (user.Password == argPassword)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
