using SalesManagement.Entities.Abstract;
using SalesManagement.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities.Conrete.Product
{
    public class PurchaseLog : IEntity
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        
        //buyer
        public int UserID { get; set; }
        public User User { get; set; }

        public DateTime PurchaseDate { get; set; }

    }
}
