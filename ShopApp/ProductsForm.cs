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
            using (Database db = new Database("MyDatabase"))
            {
                products = db.GetAllProducts();
            }

            foreach (var product in products)            
                result.AppendLine($"ID: {product.ID}, Name = {product.Name}, Price = {product.Price}");

            rtb_resul.Text = result.ToString();
        }
    }
}
