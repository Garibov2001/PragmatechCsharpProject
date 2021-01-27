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
                || string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Zehmet olmasa butun xanalari doldurun");
                return;
            }

            var user = new User()
            {
                Name = nameTextBox.Text,
                LastName = lastNameTextBox.Text,
                UserName = usernameTextBox.Text
            };

            Database.AddUser(user);

            MessageBox.Show("Account yaradildi");
            this.Close();
        }
    }
}
