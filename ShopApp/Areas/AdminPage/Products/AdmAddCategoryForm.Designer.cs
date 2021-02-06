namespace ShopApp.Areas.AdminPage.Products
{
    partial class AdmAddCategoryForm
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
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.txb_category_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(85, 168);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(105, 38);
            this.btn_addCategory.TabIndex = 39;
            this.btn_addCategory.Text = "Yadda saxla";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // txb_category_name
            // 
            this.txb_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_category_name.Location = new System.Drawing.Point(71, 115);
            this.txb_category_name.Name = "txb_category_name";
            this.txb_category_name.Size = new System.Drawing.Size(144, 26);
            this.txb_category_name.TabIndex = 36;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(126, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(32, 20);
            this.lbl_name.TabIndex = 38;
            this.lbl_name.Text = "Adı";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(22, 39);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(269, 29);
            this.lbl_category.TabIndex = 37;
            this.lbl_category.Text = "Yeni kateqoriya əlavə et";
            // 
            // AdmAddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.txb_category_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_category);
            this.Name = "AdmAddCategoryForm";
            this.Text = "AdmAddCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.TextBox txb_category_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_category;
    }
}