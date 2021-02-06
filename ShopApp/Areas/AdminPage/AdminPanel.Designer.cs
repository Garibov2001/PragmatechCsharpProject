namespace ShopApp.Areas.AdminPage
{
    partial class AdminPanel
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
            this.lbl_name_surname = new System.Windows.Forms.Label();
            this.management = new System.Windows.Forms.TabControl();
            this.products_management = new System.Windows.Forms.TabPage();
            this.btn__products_refresh = new System.Windows.Forms.Button();
            this.btn_products_detailed_search = new System.Windows.Forms.Button();
            this.cmb_products_search = new System.Windows.Forms.ComboBox();
            this.lb_filter_category = new System.Windows.Forms.Label();
            this.txb_products_search = new System.Windows.Forms.TextBox();
            this.lbl_by_name = new System.Windows.Forms.Label();
            this.dgw_products = new System.Windows.Forms.DataGridView();
            this.myPurchases = new System.Windows.Forms.TabPage();
            this.dgw_buyssells = new System.Windows.Forms.DataGridView();
            this.tp_categories = new System.Windows.Forms.TabPage();
            this.btn_addCtegory = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.dgw_categories = new System.Windows.Forms.DataGridView();
            this.tp_feedbacks = new System.Windows.Forms.TabPage();
            this.dgw_feedbacks = new System.Windows.Forms.DataGridView();
            this.management.SuspendLayout();
            this.products_management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_products)).BeginInit();
            this.myPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_buyssells)).BeginInit();
            this.tp_categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_categories)).BeginInit();
            this.tp_feedbacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_feedbacks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name_surname
            // 
            this.lbl_name_surname.AutoSize = true;
            this.lbl_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_surname.Location = new System.Drawing.Point(333, 9);
            this.lbl_name_surname.Name = "lbl_name_surname";
            this.lbl_name_surname.Size = new System.Drawing.Size(123, 25);
            this.lbl_name_surname.TabIndex = 4;
            this.lbl_name_surname.Text = "Admin Panel";
            // 
            // management
            // 
            this.management.Controls.Add(this.products_management);
            this.management.Controls.Add(this.myPurchases);
            this.management.Controls.Add(this.tp_categories);
            this.management.Controls.Add(this.tp_feedbacks);
            this.management.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.management.Location = new System.Drawing.Point(12, 48);
            this.management.Name = "management";
            this.management.SelectedIndex = 0;
            this.management.Size = new System.Drawing.Size(776, 390);
            this.management.TabIndex = 5;
            // 
            // products_management
            // 
            this.products_management.Controls.Add(this.btn__products_refresh);
            this.products_management.Controls.Add(this.btn_products_detailed_search);
            this.products_management.Controls.Add(this.cmb_products_search);
            this.products_management.Controls.Add(this.lb_filter_category);
            this.products_management.Controls.Add(this.txb_products_search);
            this.products_management.Controls.Add(this.lbl_by_name);
            this.products_management.Controls.Add(this.dgw_products);
            this.products_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_management.Location = new System.Drawing.Point(4, 25);
            this.products_management.Name = "products_management";
            this.products_management.Padding = new System.Windows.Forms.Padding(3);
            this.products_management.Size = new System.Drawing.Size(768, 361);
            this.products_management.TabIndex = 0;
            this.products_management.Text = "Bütün məhsullar";
            this.products_management.UseVisualStyleBackColor = true;
            // 
            // btn__products_refresh
            // 
            this.btn__products_refresh.Location = new System.Drawing.Point(644, 33);
            this.btn__products_refresh.Name = "btn__products_refresh";
            this.btn__products_refresh.Size = new System.Drawing.Size(97, 33);
            this.btn__products_refresh.TabIndex = 6;
            this.btn__products_refresh.Text = "Refresh";
            this.btn__products_refresh.UseVisualStyleBackColor = true;
            this.btn__products_refresh.Click += new System.EventHandler(this.btn__products_refresh_Click);
            // 
            // btn_products_detailed_search
            // 
            this.btn_products_detailed_search.Location = new System.Drawing.Point(496, 33);
            this.btn_products_detailed_search.Name = "btn_products_detailed_search";
            this.btn_products_detailed_search.Size = new System.Drawing.Size(123, 34);
            this.btn_products_detailed_search.TabIndex = 5;
            this.btn_products_detailed_search.Text = "Detallı axtarış";
            this.btn_products_detailed_search.UseVisualStyleBackColor = true;
            this.btn_products_detailed_search.Click += new System.EventHandler(this.btn_products_detailed_search_Click);
            // 
            // cmb_products_search
            // 
            this.cmb_products_search.FormattingEnabled = true;
            this.cmb_products_search.Location = new System.Drawing.Point(240, 43);
            this.cmb_products_search.Name = "cmb_products_search";
            this.cmb_products_search.Size = new System.Drawing.Size(237, 24);
            this.cmb_products_search.TabIndex = 4;
            this.cmb_products_search.SelectedValueChanged += new System.EventHandler(this.cmb_products_search_SelectedValueChanged);
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
            // txb_products_search
            // 
            this.txb_products_search.Location = new System.Drawing.Point(24, 44);
            this.txb_products_search.Name = "txb_products_search";
            this.txb_products_search.Size = new System.Drawing.Size(183, 23);
            this.txb_products_search.TabIndex = 2;
            this.txb_products_search.TextChanged += new System.EventHandler(this.txb_products_search_TextChanged);
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
            // dgw_products
            // 
            this.dgw_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_products.Location = new System.Drawing.Point(24, 97);
            this.dgw_products.Name = "dgw_products";
            this.dgw_products.Size = new System.Drawing.Size(717, 246);
            this.dgw_products.TabIndex = 0;
            this.dgw_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_products_CellClick);
            // 
            // myPurchases
            // 
            this.myPurchases.Controls.Add(this.dgw_buyssells);
            this.myPurchases.Location = new System.Drawing.Point(4, 25);
            this.myPurchases.Name = "myPurchases";
            this.myPurchases.Padding = new System.Windows.Forms.Padding(3);
            this.myPurchases.Size = new System.Drawing.Size(768, 361);
            this.myPurchases.TabIndex = 2;
            this.myPurchases.Text = "Alış və Satışlar";
            this.myPurchases.UseVisualStyleBackColor = true;
            // 
            // dgw_buyssells
            // 
            this.dgw_buyssells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_buyssells.Location = new System.Drawing.Point(15, 18);
            this.dgw_buyssells.Name = "dgw_buyssells";
            this.dgw_buyssells.Size = new System.Drawing.Size(734, 347);
            this.dgw_buyssells.TabIndex = 0;
            // 
            // tp_categories
            // 
            this.tp_categories.Controls.Add(this.btn_addCtegory);
            this.tp_categories.Controls.Add(this.lbl_category);
            this.tp_categories.Controls.Add(this.dgw_categories);
            this.tp_categories.Location = new System.Drawing.Point(4, 25);
            this.tp_categories.Name = "tp_categories";
            this.tp_categories.Padding = new System.Windows.Forms.Padding(3);
            this.tp_categories.Size = new System.Drawing.Size(768, 361);
            this.tp_categories.TabIndex = 4;
            this.tp_categories.Text = "Kategoriya əlavə et";
            this.tp_categories.UseVisualStyleBackColor = true;
            // 
            // btn_addCtegory
            // 
            this.btn_addCtegory.Location = new System.Drawing.Point(592, 90);
            this.btn_addCtegory.Name = "btn_addCtegory";
            this.btn_addCtegory.Size = new System.Drawing.Size(159, 40);
            this.btn_addCtegory.TabIndex = 6;
            this.btn_addCtegory.Text = "Kategoriya əlavə et";
            this.btn_addCtegory.UseVisualStyleBackColor = true;
            this.btn_addCtegory.Click += new System.EventHandler(this.btn_addCtegory_Click);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(26, 235);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(687, 25);
            this.lbl_category.TabIndex = 5;
            this.lbl_category.Text = "Qeyd : Əgər kategoriyanı silsəz həmin kategoriyaya aid productlar da silinəcək";
            // 
            // dgw_categories
            // 
            this.dgw_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_categories.Location = new System.Drawing.Point(31, 28);
            this.dgw_categories.Name = "dgw_categories";
            this.dgw_categories.Size = new System.Drawing.Size(516, 156);
            this.dgw_categories.TabIndex = 0;
            this.dgw_categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_categories_CellContentClick);
            // 
            // tp_feedbacks
            // 
            this.tp_feedbacks.Controls.Add(this.dgw_feedbacks);
            this.tp_feedbacks.Location = new System.Drawing.Point(4, 25);
            this.tp_feedbacks.Name = "tp_feedbacks";
            this.tp_feedbacks.Padding = new System.Windows.Forms.Padding(3);
            this.tp_feedbacks.Size = new System.Drawing.Size(768, 361);
            this.tp_feedbacks.TabIndex = 5;
            this.tp_feedbacks.Text = "Feedbacklərim";
            this.tp_feedbacks.UseVisualStyleBackColor = true;
            // 
            // dgw_feedbacks
            // 
            this.dgw_feedbacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_feedbacks.Location = new System.Drawing.Point(22, 36);
            this.dgw_feedbacks.Name = "dgw_feedbacks";
            this.dgw_feedbacks.Size = new System.Drawing.Size(721, 298);
            this.dgw_feedbacks.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.management);
            this.Controls.Add(this.lbl_name_surname);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.management.ResumeLayout(false);
            this.products_management.ResumeLayout(false);
            this.products_management.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_products)).EndInit();
            this.myPurchases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_buyssells)).EndInit();
            this.tp_categories.ResumeLayout(false);
            this.tp_categories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_categories)).EndInit();
            this.tp_feedbacks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_feedbacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name_surname;
        private System.Windows.Forms.TabControl management;
        private System.Windows.Forms.TabPage products_management;
        private System.Windows.Forms.Button btn__products_refresh;
        private System.Windows.Forms.Button btn_products_detailed_search;
        public System.Windows.Forms.ComboBox cmb_products_search;
        private System.Windows.Forms.Label lb_filter_category;
        public System.Windows.Forms.TextBox txb_products_search;
        private System.Windows.Forms.Label lbl_by_name;
        private System.Windows.Forms.DataGridView dgw_products;
        private System.Windows.Forms.TabPage myPurchases;
        private System.Windows.Forms.DataGridView dgw_buyssells;
        private System.Windows.Forms.TabPage tp_categories;
        private System.Windows.Forms.TabPage tp_feedbacks;
        private System.Windows.Forms.DataGridView dgw_feedbacks;
        private System.Windows.Forms.Button btn_addCtegory;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.DataGridView dgw_categories;
    }
}