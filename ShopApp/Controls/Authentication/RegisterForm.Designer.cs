namespace ShopApp.Controls.Authentication
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_register = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txb_surname = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.txb_confirm_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.Location = new System.Drawing.Point(147, 9);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(120, 33);
            this.lbl_register.TabIndex = 1;
            this.lbl_register.Text = "Register ";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(153, 326);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(95, 37);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 57);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 25);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name";
            // 
            // txb_name
            // 
            this.txb_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_name.Location = new System.Drawing.Point(12, 96);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(169, 27);
            this.txb_name.TabIndex = 1;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(219, 58);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(96, 25);
            this.lbl_surname.TabIndex = 14;
            this.lbl_surname.Text = "Surname";
            // 
            // txb_surname
            // 
            this.txb_surname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_surname.Location = new System.Drawing.Point(224, 96);
            this.txb_surname.Name = "txb_surname";
            this.txb_surname.Size = new System.Drawing.Size(168, 27);
            this.txb_surname.TabIndex = 2;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(223, 143);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(150, 25);
            this.lbl_phone.TabIndex = 20;
            this.lbl_phone.Text = "Phone number";
            // 
            // txb_phone
            // 
            this.txb_phone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_phone.Location = new System.Drawing.Point(228, 181);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(168, 27);
            this.txb_phone.TabIndex = 4;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(16, 142);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(63, 25);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email";
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(16, 181);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(165, 27);
            this.txb_email.TabIndex = 3;
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.Location = new System.Drawing.Point(223, 231);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(181, 25);
            this.lbl_confirm.TabIndex = 24;
            this.lbl_confirm.Text = "Confirm Password";
            // 
            // txb_confirm_password
            // 
            this.txb_confirm_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_confirm_password.Location = new System.Drawing.Point(228, 269);
            this.txb_confirm_password.Name = "txb_confirm_password";
            this.txb_confirm_password.Size = new System.Drawing.Size(168, 27);
            this.txb_confirm_password.TabIndex = 6;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(12, 231);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(111, 25);
            this.lbl_password.TabIndex = 22;
            this.lbl_password.Text = "Passoword";
            // 
            // txb_password
            // 
            this.txb_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.Location = new System.Drawing.Point(16, 269);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(165, 27);
            this.txb_password.TabIndex = 5;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 414);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.txb_confirm_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.txb_surname);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.lbl_register);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txb_surname;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.TextBox txb_confirm_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txb_password;
    }
}