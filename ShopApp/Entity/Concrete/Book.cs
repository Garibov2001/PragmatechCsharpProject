using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity.Concrete
{
    public class Book : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
