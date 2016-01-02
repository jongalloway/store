using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public  class Review
    {
        public virtual int ID { get; set; }
        public virtual double Rating { get; set; }
        public virtual string ReviewText { get; set; }
        public virtual Customer Reviewer { get; set; }  
    }
}
