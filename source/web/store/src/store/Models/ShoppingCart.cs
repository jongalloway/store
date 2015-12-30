using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public List<OrderDetail> CartItems { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastMOdified { get; set; }
        public bool Saved { get; set; }
    }
}
