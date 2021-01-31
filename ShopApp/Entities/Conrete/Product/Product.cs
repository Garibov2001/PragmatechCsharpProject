using SalesManagement.Entities.Abstract;
using SalesManagement.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities.Conrete.Product
{
    public class Product : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int ProductStatus { get; set; }

        //Relations:
        public int UserID { get; set; }
        public User User { get; set; }

        public int ProductCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }

    }
}
