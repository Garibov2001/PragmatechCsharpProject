namespace ShopApp.Controls
{
    partial class AccountForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgw_allProducts = new System.Windows.Forms.DataGridView();
            this.pg_myProducts = new System.Windows.Forms.TabPage();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.dgw_myProducts = new System.Windows.Forms.DataGridView();
            this.lbl_name_surname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_allProducts)).BeginInit();
            this.pg_myProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_myProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.pg_myProducts);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgw_allProducts);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bütün məhsullar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgw_allProducts
            // 
            this.dgw_allProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_allProducts.Location = new System.Drawing.Point(24, 83);
            this.dgw_allProducts.Name = "dgw_allProducts";
            this.dgw_allProducts.Size = new System.Drawing.Size(717, 150);
            this.dgw_allProducts.TabIndex = 0;
            // 
            // pg_myProducts
            // 
            this.pg_myProducts.Controls.Add(this.btn_addProduct);
            this.pg_myProducts.Controls.Add(this.cmb_filter);
            this.pg_myProducts.Controls.Add(this.lbl_filter);
            this.pg_myProducts.Controls.Add(this.txb_search);
            this.pg_myProducts.Controls.Add(this.lbl_search);
            this.pg_myProducts.Controls.Add(this.dgw_myProducts);
            this.pg_myProducts.Location = new System.Drawing.Point(4, 25);
            this.pg_myProducts.Name = "pg_myProducts";
            this.pg_myProducts.Padding = new System.Windows.Forms.Padding(3);
            this.pg_myProducts.Size = new System.Drawing.Size(768, 389);
            this.pg_myProducts.TabIndex = 1;
            this.pg_myProducts.Text = "Məhsullarım";
            this.pg_myProducts.UseVisualStyleBackColor = true;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.Location = new System.Drawing.Point(601, 308);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(142, 39);
            this.btn_addProduct.TabIndex = 5;
            this.btn_addProduct.Text = "Məhsul əlavə et";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // cmb_filter
            // 
            this.cmb_filter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Location = new System.Drawing.Point(542, 48);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(201, 24);
            this.cmb_filter.TabIndex = 4;
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Location = new System.Drawing.Point(507, 16);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(236, 17);
            this.lbl_filter.TabIndex = 3;
            this.lbl_filter.Text = "Məhsulları kategoriyaya görə filterlə:";
            // 
            // txb_search
            // 
            this.txb_search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_search.Location = new System.Drawing.Point(20, 48);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(169, 23);
            this.txb_search.TabIndex = 2;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(17, 16);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(214, 17);
            this.lbl_search.TabIndex = 1;
            this.lbl_search.Text = "Məhsulun adına görə axtarış et:  ";
            // 
            // dgw_myProducts
            // 
            this.dgw_myProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_myProducts.Location = new System.Drawing.Point(20, 97);
            this.dgw_myProducts.Name = "dgw_myProducts";
            this.dgw_myProducts.Size = new System.Drawing.Size(723, 189);
            this.dgw_myProducts.TabIndex = 0;
            this.dgw_myProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_myProducts_CellClick);
            // 
            // lbl_name_surname
            // 
            this.lbl_name_surname.AutoSize = true;
            this.lbl_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_surname.Location = new System.Drawing.Point(12, 9);
            this.lbl_name_surname.Name = "lbl_name_surname";
            this.lbl_name_surname.Size = new System.Drawing.Size(132, 25);
            this.lbl_name_surname.TabIndex = 1;
            this.lbl_name_surname.Text = "Ad və soyad: ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 43);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(71, 25);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email: ";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(12, 79);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(89, 25);
            this.lbl_phone.TabIndex = 3;
            this.lbl_phone.Text = "Telefon :";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(650, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Hesabdan çıx";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 567);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name_surname);
            this.Controls.Add(this.tabControl1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_allProducts)).EndInit();
            this.pg_myProducts.ResumeLayout(false);
            this.pg_myProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_myProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage pg_myProducts;
        private System.Windows.Forms.Label lbl_name_surname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.DataGridView dgw_myProducts;
        private System.Windows.Forms.DataGridView dgw_allProducts;
    }
}