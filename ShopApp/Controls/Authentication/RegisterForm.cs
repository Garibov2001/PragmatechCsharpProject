using ShopApp.Validations;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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



        }
    }
}
