using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Address
    {
        public virtual int ID { get; set; }
        // Currently only supporting US & Canada
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string StateOrProvince { get; set; }
        public virtual string ZipOrPostalCode { get; set; }

    }
}
