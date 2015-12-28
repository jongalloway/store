using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SkuOrISBN { get; set; }
        public decimal MSRP { get; set; }
        public decimal StandardPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Description { get; set; }
    }
}
