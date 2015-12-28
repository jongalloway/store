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

        public List<Item> Items { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }
        public ShippingType Shipping { get; set; }
        public DateTime PromisedDate { get; set; }
        public ReturnInfo Return { get; set; }

    }
}
