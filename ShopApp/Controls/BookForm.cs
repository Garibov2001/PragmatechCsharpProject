using ShopApp.DataAccessLayer;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Controls
{
    public partial class BookForm : Form
    {
        public Form _form { get; set; }
        public BookForm(Form form)
        {
            _form = form;
            _form.Hide();
            InitializeComponent();
            SeedValues();
        }

        public void SeedValues()
        {
            Book book1 = new Book { Name = "Arnorld Shwarneger" };
            Book book2 = new Book { Name = "Harry Poter" };
            Book book3 = new Book { Name = "Deli kur" };

            

            Database.Books.Add(book1);
            Database.Books.Add(book2);
            Database.Books.Add(book3);

            List<Book> books = Database.Books.GetAll();

            int x_coordinate = 41;
            foreach (var book in books)
            {
                GroupBox gbx = new GroupBox();
                gbx.Text = book.Name;
                gbx.Size = new Size(161, 133);
                gbx.Location = new Point(x_coordinate, 43);
                x_coordinate += 256;
                this.Controls.Add(gbx);
            }

        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.Close();
        }
    }
}
