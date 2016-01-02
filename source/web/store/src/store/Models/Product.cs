using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public  abstract class Product
    {
        public virtual int ID { get; set; }
        public virtual decimal MSRP { get; set; }
        public virtual decimal StandardPrice { get; set; }
        public virtual decimal SalePrice { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
