using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Item
    {
        public int ID { get; set; }
        public Product  Product { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Name { get; set; }
        public int NumberOfItems { get; set; }

    }
}
