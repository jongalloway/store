using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Order
    {
        public int ID { get; set; }
        public enum ShippingType
        {
            Standard,
            SameDay,
            NextDay,
            TwoDay,
            Saturday,
            Sunday
        }

        public List<OrderDetail> Details { get; set; }

        public double Tax { get; set; }
        public double ShippingCost { get; set; }
        public double TotalCost { get; set; }
        public DateTime OrderDate { get; set; }
        public ShippingType Shipping { get; set; }
        public DateTime PromisedDate { get; set; }
        public ReturnInfo Return { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ShippingAddress { get; set; }
        public int BillingAddress { get; set; }
    }
}
