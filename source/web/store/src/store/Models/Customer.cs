using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public  class Customer : Person
    {
        public virtual List<Address> BillingAddresses { get; set;  }
        public virtual List<Address> ShippingAddresses { get; set; }
        public virtual List<Order> OrderHistory { get; set; }
        public virtual List<CreditCard> CreditCards { get; set; }
        public virtual Address DefaultBillingAddress { get; set; }
        public virtual Address DefaultShippingAddress { get; set; }
        public virtual List<Review> ReviewHistory { get; set; }


    }
}
