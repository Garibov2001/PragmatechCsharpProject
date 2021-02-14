using ShopApp.DataAccessLayer;
using ShopApp.Enitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            List<Product> products;
            using (Database db = new Database())
            {
                products = db.GetAllProducts();
            }

            foreach (var product in products)            
                result.AppendLine($"ID: {product.ID}, Name = {product.Name}, Price = {product.Price}");

            rtb_resul.Text = result.ToString();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var name = txb_name.Text;
            var price = Convert.ToInt32(txb_price.Text);

            using (Database db = new Database())
            {
                db.CreateProduct(name, price);
            }

            MessageBox.Show("Product elave olundu");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txb_id.Text);
            var name = txb_name.Text;
            var price = Convert.ToInt32(txb_price.Text);

            using (Database db = new Database())
            {
                db.UpdateProduct(id,name, price);
            }

            MessageBox.Show("Product update olundu");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txb_id.Text);            

            using (Database db = new Database())
            {
                db.DeleteProduct(id);
            }

            MessageBox.Show("Product ugurla silindi");

        }
    }
}
