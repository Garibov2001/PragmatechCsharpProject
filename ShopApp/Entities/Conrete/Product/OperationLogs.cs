using SalesManagement.Entities.Abstract;
using SalesManagement.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities.Conrete.Product
{
    public class OperationLogs : IEntity
    {
        public int ID { get; set; }
        public int OperationStatus { get; set; }
        public DateTime OperationDate { get; set; }

        //Reference to product:
        public int ProductID { get; set; }
        public Product Product { get; set; }

        //Reference to product:
        public int UserID { get; set; }
        public User User { get; set; }    
    }
}
