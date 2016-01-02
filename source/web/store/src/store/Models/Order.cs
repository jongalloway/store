using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public  class Order
    {
        public virtual int ID { get; set; }
        public  enum ShippingType
        {
            Standard,
            SameDay,
            NextDay,
            TwoDay,
            Saturday,
            Sunday
        }

        public virtual List<OrderDetail> Details { get; set; }

        public virtual double Tax { get; set; }
        public virtual double ShippingCost { get; set; }
        public virtual double TotalCost { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual ShippingType Shipping { get; set; }
        public virtual DateTime PromisedDate { get; set; }
        public virtual ReturnInfo Return { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
        public virtual int ShippingAddress { get; set; }
        public virtual int BillingAddress { get; set; }
    }
}
