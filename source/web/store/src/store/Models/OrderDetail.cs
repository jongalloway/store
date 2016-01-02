using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class OrderDetail
    {
        public virtual int ID { get; set; }
        public virtual Product  Product { get; set; }
        public virtual int Quantity { get; set; }
    }
}
