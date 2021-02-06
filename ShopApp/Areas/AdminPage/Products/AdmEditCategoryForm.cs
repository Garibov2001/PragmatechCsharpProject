using ShopApp.DataAccessLayer;
using ShopApp.Entities.Conrete.Product;
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
    public partial class AdmEditCategoryForm : Form
    {
        private UnitOfWork _unitOfWork;
        private ProductCategory _category;
        public AdmEditCategoryForm(ProductCategory productCategory)
        {
            _category = productCategory;
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_edit_name.Text))
            {
                MessageBox.Show("Kategoriyanın adı boş ola bilməz", "Yalnislari duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txb_edit_name.Text.Any(elem => !char.IsLetter(elem)))
            {
                MessageBox.Show("Kategoriyanın adı yalniz herflerden teskil oluna biler", "Yalnislari duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txb_edit_name.Text.Any(elem => elem > 128))
            {
                MessageBox.Show("Kategoriyanın adı yalniz ASCII herflerden teskil oluna biler", "Yalnislari duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _category.Name = txb_edit_name.Text;
            _unitOfWork.ProductCategories.Update(_category);

            this.Close();
        }
    }
}
