namespace ShopApp.Areas.AdminPage.Products
{
    partial class AdmEditCategoryForm
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
            this.txb_edit_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_edit_category = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_edit_name
            // 
            this.txb_edit_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_edit_name.Location = new System.Drawing.Point(44, 111);
            this.txb_edit_name.Name = "txb_edit_name";
            this.txb_edit_name.Size = new System.Drawing.Size(144, 26);
            this.txb_edit_name.TabIndex = 31;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(99, 88);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(32, 20);
            this.lbl_name.TabIndex = 34;
            this.lbl_name.Text = "Adı";
            // 
            // lbl_edit_category
            // 
            this.lbl_edit_category.AutoSize = true;
            this.lbl_edit_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_category.Location = new System.Drawing.Point(21, 33);
            this.lbl_edit_category.Name = "lbl_edit_category";
            this.lbl_edit_category.Size = new System.Drawing.Size(213, 29);
            this.lbl_edit_category.TabIndex = 33;
            this.lbl_edit_category.Text = "Kateqoriyanı editlə";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(58, 164);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 38);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Yadda saxla";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AdmEditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 245);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txb_edit_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_edit_category);
            this.Name = "AdmEditCategoryForm";
            this.Text = "AdmEditCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_edit_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_edit_category;
        private System.Windows.Forms.Button btn_save;
    }
}