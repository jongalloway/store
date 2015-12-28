using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public abstract class Product
    {
        public int ID { get; set; }
        public decimal MSRP { get; set; }
        public decimal StandardPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Description { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
