using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class CreditCard
    {
        public int ID { get; set; }
        public virtual string Number { get; set; }
        public virtual DateTime ExpirationDate { get; set; }
        public virtual int CVC { get; set; }
        public virtual string NameOnCard { get; set; }

        private bool IsValid() { return true; }
    }
}
