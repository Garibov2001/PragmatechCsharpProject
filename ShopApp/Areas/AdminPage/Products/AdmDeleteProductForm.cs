using ShopApp.DataAccessLayer;
using ShopApp.Entities.Conrete.Product;
using ShopApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Areas.AdminPage.Products
{
    public partial class AdmDeleteProductForm : Form
    {
        private UnitOfWork _unitOfWork;
        private Product _product;
        public AdmDeleteProductForm(Product argProduct)
        {
            _product = argProduct;
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(rtb_reason.Text))
            {
                MessageBox.Show("Silinmə səbəbini qeyd edin.", "Problem.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var newLog = new OperationLog
            {
                OperationDate = DateTime.Now,
                ProductID = _product.ID,
                UserID = AdminPanel.CurrentUser.ID,
                OperationDescription = rtb_reason.Text,
                OperationStatus = (int)OperationStatus.Delete
            };

            _product.ProductStatus = (int)ProductStatus.Deleted;
            _unitOfWork.Products.Update(_product);

            _unitOfWork.OperationLogs.Create(newLog);

            this.Close();
        }
    }
}
