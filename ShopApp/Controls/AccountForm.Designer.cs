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
            this.management = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_all_products_refresh = new System.Windows.Forms.Button();
            this.btn_all_products_detailed_search = new System.Windows.Forms.Button();
            this.cmb_all_products_search = new System.Windows.Forms.ComboBox();
            this.lb_filter_category = new System.Windows.Forms.Label();
            this.txb_all_products_search = new System.Windows.Forms.TextBox();
            this.lbl_by_name = new System.Windows.Forms.Label();
            this.dgw_allProducts = new System.Windows.Forms.DataGridView();
            this.pg_myProducts = new System.Windows.Forms.TabPage();
            this.btn_my_products_refresh = new System.Windows.Forms.Button();
            this.btn_my_products_detailed_search = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.cmb_my_products_search = new System.Windows.Forms.ComboBox();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.txb_my_products_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.dgw_myProducts = new System.Windows.Forms.DataGridView();
            this.lbl_name_surname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.myPurchases = new System.Windows.Forms.TabPage();
            this.mySales = new System.Windows.Forms.TabPage();
            this.dgw_myPurchases = new System.Windows.Forms.DataGridView();
            this.dgw_mySales = new System.Windows.Forms.DataGridView();
            this.adminFeedbacks = new System.Windows.Forms.TabPage();
            this.management.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_allProducts)).BeginInit();
            this.pg_myProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_myProducts)).BeginInit();
            this.myPurchases.SuspendLayout();
            this.mySales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_myPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_mySales)).BeginInit();
            this.SuspendLayout();
            // 
            // management
            // 
            this.management.Controls.Add(this.tabPage1);
            this.management.Controls.Add(this.pg_myProducts);
            this.management.Controls.Add(this.myPurchases);
            this.management.Controls.Add(this.mySales);
            this.management.Controls.Add(this.adminFeedbacks);
            this.management.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.management.Location = new System.Drawing.Point(12, 133);
            this.management.Name = "management";
            this.management.SelectedIndex = 0;
            this.management.Size = new System.Drawing.Size(776, 418);
            this.management.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_all_products_refresh);
            this.tabPage1.Controls.Add(this.btn_all_products_detailed_search);
            this.tabPage1.Controls.Add(this.cmb_all_products_search);
            this.tabPage1.Controls.Add(this.lb_filter_category);
            this.tabPage1.Controls.Add(this.txb_all_products_search);
            this.tabPage1.Controls.Add(this.lbl_by_name);
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
            // btn_all_products_refresh
            // 
            this.btn_all_products_refresh.Location = new System.Drawing.Point(644, 33);
            this.btn_all_products_refresh.Name = "btn_all_products_refresh";
            this.btn_all_products_refresh.Size = new System.Drawing.Size(97, 33);
            this.btn_all_products_refresh.TabIndex = 6;
            this.btn_all_products_refresh.Text = "Refresh";
            this.btn_all_products_refresh.UseVisualStyleBackColor = true;
            this.btn_all_products_refresh.Click += new System.EventHandler(this.btn_all_products_refresh_Click);
            // 
            // btn_all_products_detailed_search
            // 
            this.btn_all_products_detailed_search.Location = new System.Drawing.Point(496, 33);
            this.btn_all_products_detailed_search.Name = "btn_all_products_detailed_search";
            this.btn_all_products_detailed_search.Size = new System.Drawing.Size(123, 34);
            this.btn_all_products_detailed_search.TabIndex = 5;
            this.btn_all_products_detailed_search.Text = "Detallı axtarış";
            this.btn_all_products_detailed_search.UseVisualStyleBackColor = true;
            this.btn_all_products_detailed_search.Click += new System.EventHandler(this.btn_all_products_detailed_search_Click);
            // 
            // cmb_all_products_search
            // 
            this.cmb_all_products_search.FormattingEnabled = true;
            this.cmb_all_products_search.Location = new System.Drawing.Point(240, 43);
            this.cmb_all_products_search.Name = "cmb_all_products_search";
            this.cmb_all_products_search.Size = new System.Drawing.Size(237, 24);
            this.cmb_all_products_search.TabIndex = 4;
            this.cmb_all_products_search.SelectedValueChanged += new System.EventHandler(this.cmb_all_products_search_SelectedValueChanged);
            // 
            // lb_filter_category
            // 
            this.lb_filter_category.AutoSize = true;
            this.lb_filter_category.Location = new System.Drawing.Point(237, 15);
            this.lb_filter_category.Name = "lb_filter_category";
            this.lb_filter_category.Size = new System.Drawing.Size(240, 17);
            this.lb_filter_category.TabIndex = 3;
            this.lb_filter_category.Text = "Məhsulun kategoriyasına görə filterlə";
            // 
            // txb_all_products_search
            // 
            this.txb_all_products_search.Location = new System.Drawing.Point(24, 44);
            this.txb_all_products_search.Name = "txb_all_products_search";
            this.txb_all_products_search.Size = new System.Drawing.Size(183, 23);
            this.txb_all_products_search.TabIndex = 2;
            this.txb_all_products_search.TextChanged += new System.EventHandler(this.txb_all_products_search_TextChanged);
            // 
            // lbl_by_name
            // 
            this.lbl_by_name.AutoSize = true;
            this.lbl_by_name.Location = new System.Drawing.Point(21, 15);
            this.lbl_by_name.Name = "lbl_by_name";
            this.lbl_by_name.Size = new System.Drawing.Size(186, 17);
            this.lbl_by_name.TabIndex = 1;
            this.lbl_by_name.Text = "Məhsulun adına görə axtarış";
            // 
            // dgw_allProducts
            // 
            this.dgw_allProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_allProducts.Location = new System.Drawing.Point(24, 97);
            this.dgw_allProducts.Name = "dgw_allProducts";
            this.dgw_allProducts.Size = new System.Drawing.Size(717, 194);
            this.dgw_allProducts.TabIndex = 0;
            this.dgw_allProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_allProducts_CellClick);
            // 
            // pg_myProducts
            // 
            this.pg_myProducts.Controls.Add(this.btn_my_products_refresh);
            this.pg_myProducts.Controls.Add(this.btn_my_products_detailed_search);
            this.pg_myProducts.Controls.Add(this.btn_addProduct);
            this.pg_myProducts.Controls.Add(this.cmb_my_products_search);
            this.pg_myProducts.Controls.Add(this.lbl_filter);
            this.pg_myProducts.Controls.Add(this.txb_my_products_search);
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
            // btn_my_products_refresh
            // 
            this.btn_my_products_refresh.Location = new System.Drawing.Point(642, 42);
            this.btn_my_products_refresh.Name = "btn_my_products_refresh";
            this.btn_my_products_refresh.Size = new System.Drawing.Size(101, 35);
            this.btn_my_products_refresh.TabIndex = 7;
            this.btn_my_products_refresh.Text = "Refresh";
            this.btn_my_products_refresh.UseVisualStyleBackColor = true;
            this.btn_my_products_refresh.Click += new System.EventHandler(this.btn_my_products_refresh_Click);
            // 
            // btn_my_products_detailed_search
            // 
            this.btn_my_products_detailed_search.Location = new System.Drawing.Point(511, 42);
            this.btn_my_products_detailed_search.Name = "btn_my_products_detailed_search";
            this.btn_my_products_detailed_search.Size = new System.Drawing.Size(121, 35);
            this.btn_my_products_detailed_search.TabIndex = 6;
            this.btn_my_products_detailed_search.Text = "Detallı axtarış";
            this.btn_my_products_detailed_search.UseVisualStyleBackColor = true;
            this.btn_my_products_detailed_search.Click += new System.EventHandler(this.btn_detailed_search_Click);
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
            // cmb_my_products_search
            // 
            this.cmb_my_products_search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmb_my_products_search.FormattingEnabled = true;
            this.cmb_my_products_search.Location = new System.Drawing.Point(258, 47);
            this.cmb_my_products_search.Name = "cmb_my_products_search";
            this.cmb_my_products_search.Size = new System.Drawing.Size(233, 24);
            this.cmb_my_products_search.TabIndex = 4;
            this.cmb_my_products_search.SelectedValueChanged += new System.EventHandler(this.cmb_my_products_search_SelectedValueChanged);
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Location = new System.Drawing.Point(255, 16);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(236, 17);
            this.lbl_filter.TabIndex = 3;
            this.lbl_filter.Text = "Məhsulları kategoriyaya görə filterlə:";
            // 
            // txb_my_products_search
            // 
            this.txb_my_products_search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_my_products_search.Location = new System.Drawing.Point(20, 48);
            this.txb_my_products_search.Name = "txb_my_products_search";
            this.txb_my_products_search.Size = new System.Drawing.Size(194, 23);
            this.txb_my_products_search.TabIndex = 2;
            this.txb_my_products_search.TextChanged += new System.EventHandler(this.txb_my_products_search_TextChanged);
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
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(609, 79);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(88, 25);
            this.lbl_balance.TabIndex = 5;
            this.lbl_balance.Text = "Balans : ";
            // 
            // myPurchases
            // 
            this.myPurchases.Controls.Add(this.dgw_myPurchases);
            this.myPurchases.Location = new System.Drawing.Point(4, 25);
            this.myPurchases.Name = "myPurchases";
            this.myPurchases.Padding = new System.Windows.Forms.Padding(3);
            this.myPurchases.Size = new System.Drawing.Size(768, 389);
            this.myPurchases.TabIndex = 2;
            this.myPurchases.Text = "Alışlarım";
            this.myPurchases.UseVisualStyleBackColor = true;
            // 
            // mySales
            // 
            this.mySales.Controls.Add(this.dgw_mySales);
            this.mySales.Location = new System.Drawing.Point(4, 25);
            this.mySales.Name = "mySales";
            this.mySales.Padding = new System.Windows.Forms.Padding(3);
            this.mySales.Size = new System.Drawing.Size(768, 389);
            this.mySales.TabIndex = 3;
            this.mySales.Text = "Satışlarım";
            this.mySales.UseVisualStyleBackColor = true;
            // 
            // dgw_myPurchases
            // 
            this.dgw_myPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_myPurchases.Location = new System.Drawing.Point(15, 18);
            this.dgw_myPurchases.Name = "dgw_myPurchases";
            this.dgw_myPurchases.Size = new System.Drawing.Size(734, 347);
            this.dgw_myPurchases.TabIndex = 0;
            // 
            // dgw_mySales
            // 
            this.dgw_mySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_mySales.Location = new System.Drawing.Point(19, 20);
            this.dgw_mySales.Name = "dgw_mySales";
            this.dgw_mySales.Size = new System.Drawing.Size(727, 343);
            this.dgw_mySales.TabIndex = 0;
            // 
            // adminFeedbacks
            // 
            this.adminFeedbacks.Location = new System.Drawing.Point(4, 25);
            this.adminFeedbacks.Name = "adminFeedbacks";
            this.adminFeedbacks.Padding = new System.Windows.Forms.Padding(3);
            this.adminFeedbacks.Size = new System.Drawing.Size(768, 389);
            this.adminFeedbacks.TabIndex = 4;
            this.adminFeedbacks.Text = "Admindən feedbacklər";
            this.adminFeedbacks.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 567);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name_surname);
            this.Controls.Add(this.management);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.management.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_allProducts)).EndInit();
            this.pg_myProducts.ResumeLayout(false);
            this.pg_myProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_myProducts)).EndInit();
            this.myPurchases.ResumeLayout(false);
            this.mySales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_myPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_mySales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl management;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage pg_myProducts;
        private System.Windows.Forms.Label lbl_name_surname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_addProduct;
        public System.Windows.Forms.ComboBox cmb_my_products_search;
        private System.Windows.Forms.Label lbl_filter;
        public System.Windows.Forms.TextBox txb_my_products_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.DataGridView dgw_myProducts;
        private System.Windows.Forms.DataGridView dgw_allProducts;
        private System.Windows.Forms.Label lb_filter_category;
        public System.Windows.Forms.TextBox txb_all_products_search;
        private System.Windows.Forms.Label lbl_by_name;
        public System.Windows.Forms.ComboBox cmb_all_products_search;
        private System.Windows.Forms.Button btn_my_products_detailed_search;
        private System.Windows.Forms.Button btn_all_products_detailed_search;
        private System.Windows.Forms.Button btn_my_products_refresh;
        private System.Windows.Forms.Button btn_all_products_refresh;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.TabPage myPurchases;
        private System.Windows.Forms.TabPage mySales;
        private System.Windows.Forms.DataGridView dgw_myPurchases;
        private System.Windows.Forms.DataGridView dgw_mySales;
        private System.Windows.Forms.TabPage adminFeedbacks;
    }
}