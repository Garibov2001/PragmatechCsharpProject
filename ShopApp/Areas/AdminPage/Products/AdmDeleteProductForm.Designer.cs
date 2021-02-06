namespace ShopApp.Areas.AdminPage.Products
{
    partial class AdmDeleteProductForm
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
            this.lbl_remove = new System.Windows.Forms.Label();
            this.rtb_reason = new System.Windows.Forms.RichTextBox();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_remove
            // 
            this.lbl_remove.AutoSize = true;
            this.lbl_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remove.Location = new System.Drawing.Point(44, 50);
            this.lbl_remove.Name = "lbl_remove";
            this.lbl_remove.Size = new System.Drawing.Size(167, 20);
            this.lbl_remove.TabIndex = 37;
            this.lbl_remove.Text = "Silinmə səbəbi qeyd et";
            // 
            // rtb_reason
            // 
            this.rtb_reason.Location = new System.Drawing.Point(25, 92);
            this.rtb_reason.Name = "rtb_reason";
            this.rtb_reason.Size = new System.Drawing.Size(197, 57);
            this.rtb_reason.TabIndex = 36;
            this.rtb_reason.Text = "";
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeProduct.Location = new System.Drawing.Point(48, 169);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(142, 39);
            this.btn_removeProduct.TabIndex = 34;
            this.btn_removeProduct.Text = "Sil";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // AdmDeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 243);
            this.Controls.Add(this.lbl_remove);
            this.Controls.Add(this.rtb_reason);
            this.Controls.Add(this.btn_removeProduct);
            this.Name = "AdmDeleteProductForm";
            this.Text = "AdmDeleteProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_remove;
        private System.Windows.Forms.RichTextBox rtb_reason;
        private System.Windows.Forms.Button btn_removeProduct;
    }
}