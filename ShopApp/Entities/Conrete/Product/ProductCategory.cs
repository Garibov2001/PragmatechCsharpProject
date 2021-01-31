using SalesManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities.Conrete.Product
{
    public class ProductCategory : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
