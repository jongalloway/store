using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class ShoppingCart
    {
        public virtual int ID { get; set; }
        public virtual int CustomerID { get; set; }
        public virtual List<OrderDetail> CartItems { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateLastMOdified { get; set; }
        public virtual bool Saved { get; set; }
    }
}
