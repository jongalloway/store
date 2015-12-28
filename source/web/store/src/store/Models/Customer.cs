using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Customer : Person
    {
        public List<Address> BillingAddresses { get; set;  }
        public List<Address> ShippingAddresses { get; set; }
        public List<Order> OrderHistory { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        int DefaultBillingAddress { get; set; }
        int DefaultShippingAddress { get; set; }
        List<Review> ReviewHistory { get; set; }


    }
}
