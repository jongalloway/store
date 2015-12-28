using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Review
    {
        public int ID { get; set; }
        public double Rating { get; set; }
        public string ReviewText { get; set; }
        public Customer Reviewer { get; set; }  
    }
}
