using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public Product  Product { get; set; }
        public int Quantity { get; set; }

    }
}
