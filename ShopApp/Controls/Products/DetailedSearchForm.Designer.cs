namespace ShopApp.Controls.Products
{
    partial class DetailedSearchForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txb_count = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txb_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lb_header_search = new System.Windows.Forms.Label();
            this.cmb_categories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(88, 328);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 39);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Axtarış et";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(58, 136);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(95, 20);
            this.lbl_category.TabIndex = 17;
            this.lbl_category.Text = "Kateqoriyası";
            // 
            // txb_count
            // 
            this.txb_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_count.Location = new System.Drawing.Point(62, 287);
            this.txb_count.Name = "txb_count";
            this.txb_count.Size = new System.Drawing.Size(144, 26);
            this.txb_count.TabIndex = 4;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(58, 264);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(39, 20);
            this.lbl_count.TabIndex = 16;
            this.lbl_count.Text = "Sayı";
            // 
            // txb_price
            // 
            this.txb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_price.Location = new System.Drawing.Point(62, 224);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(144, 26);
            this.txb_price.TabIndex = 3;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(58, 201);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(58, 20);
            this.lbl_price.TabIndex = 13;
            this.lbl_price.Text = "Dəyəri ";
            // 
            // txb_name
            // 
            this.txb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_name.Location = new System.Drawing.Point(62, 90);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(144, 26);
            this.txb_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(58, 67);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(32, 20);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Adı";
            // 
            // lb_header_search
            // 
            this.lb_header_search.AutoSize = true;
            this.lb_header_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header_search.Location = new System.Drawing.Point(45, 20);
            this.lb_header_search.Name = "lb_header_search";
            this.lb_header_search.Size = new System.Drawing.Size(182, 29);
            this.lb_header_search.TabIndex = 8;
            this.lb_header_search.Text = "Detallı axtarış et";
            // 
            // cmb_categories
            // 
            this.cmb_categories.FormattingEnabled = true;
            this.cmb_categories.Location = new System.Drawing.Point(62, 159);
            this.cmb_categories.Name = "cmb_categories";
            this.cmb_categories.Size = new System.Drawing.Size(144, 21);
            this.cmb_categories.TabIndex = 2;
            // 
            // DetailedSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 425);
            this.Controls.Add(this.cmb_categories);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.txb_count);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lb_header_search);
            this.Name = "DetailedSearchForm";
            this.Text = "DetailedSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txb_count;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lb_header_search;
        private System.Windows.Forms.ComboBox cmb_categories;
    }
}