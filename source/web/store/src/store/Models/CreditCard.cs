using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class CreditCard
    {
        public string Number { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVC { get; set; }
        public string NameOnCard { get; set; }

        private bool IsValid() { return true; }
    }
}
