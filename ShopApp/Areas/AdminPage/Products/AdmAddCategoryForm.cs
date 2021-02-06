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
    public partial class AdmAddCategoryForm : Form
    {
        private UnitOfWork _unitOfWork;
        public AdmAddCategoryForm()
        {
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_category_name.Text))
            {
                MessageBox.Show("Kategoriyanın adı boş ola bilməz", "Yalnislari duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txb_category_name.Text.Any(elem => !char.IsLetter(elem)))
            {
                MessageBox.Show("Kategoriyanın adı yalniz herflerden teskil oluna biler", "Yalnislari duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txb_category_name.Text.Any(elem => elem > 128))
            {
                MessageBox.Show("Kategoriyanın adı yalniz ASCII herflerden teskil oluna biler", "Yalnislari duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_unitOfWork.ProductCategories.Get(x => x.Name == txb_category_name.Text.ToLower()) != null)
            {
                MessageBox.Show("Bu adda kategori artiq movcuddur", "Yalnislari duzelt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var newCategory = new ProductCategory
            {
                Name = txb_category_name.Text.ToLower()
            };

            _unitOfWork.ProductCategories.Create(newCategory);

            this.Close();

        }
    }
}
