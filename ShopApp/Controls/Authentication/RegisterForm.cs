using SalesManagement.Entities.Authentication;
using ShopApp.DataAccessLayer;
using ShopApp.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Controls.Authentication
{
    public partial class RegisterForm : Form
    {
        private UnitOfWork unitOfWork;
        public RegisterForm()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            List<bool> validationResult = new List<bool>();

            var feedback = new StringBuilder();
           
            validationResult.Add(txb_name.Text.IsValidName(feedback));
            validationResult.Add(txb_surname.Text.IsValidSurname(feedback));
            validationResult.Add(txb_email.Text.IsValidEmail(feedback));
            validationResult.Add(txb_phone.Text.IsValidPhoneNumber(feedback));
            validationResult.Add(txb_password.Text.IsValidPassword(txb_confirm_password.Text, feedback));

            if (validationResult.Any(elem => elem == false))
            {
                MessageBox.Show(feedback.ToString(), "Yalnışlıqların düzəldin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new User
            {
                Name = txb_name.Text,
                Surname = txb_surname.Text,
                Email = txb_email.Text,
                PhoneNumber = txb_phone.Text,
                Password = txb_password.Text,
                Balance = 500
            };

            if (!unitOfWork.Users.IsUniqueUser(newUser))
            {
                MessageBox.Show("Bu emaildə user artıq mövcüddur", "Yalnışlıqları düzəldin.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = unitOfWork.Users.Create(newUser);
            var role = unitOfWork.Roles.Get(x => x.Name == "Customer");

            unitOfWork.UsersRoles.Create(
                new UserRole {RoleID = role.ID, UserID = user.ID });

            MessageBox.Show("Accountunuz uğurla yaradıldı", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
