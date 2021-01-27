using ShopApp.DataAccessLayer;
using ShopApp.Entity;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) 
                || string.IsNullOrEmpty(nameTextBox.Text)
                || string.IsNullOrEmpty(lastNameTextBox.Text)
                || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Zehmet olmasa butun xanalari doldurun");
                return;
            }


            //Check for unique username
            if (IsUserExist(usernameTextBox.Text))
            {
                MessageBox.Show("Bu username artiq sistemde var!");
                return;
            }

            var newUser = new User()
            {
                Name = nameTextBox.Text,
                LastName = lastNameTextBox.Text,
                UserName = usernameTextBox.Text,
                Password = passwordTextBox.Text         
            };

            Database.AddUser(newUser);

            MessageBox.Show("Account yaradildi");
            this.Close();
        }



        private bool IsUserExist(string argUsername)
        {
            var users = Database.GetAll();

            foreach (var user in users)
            {
                if (user.UserName == argUsername)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
