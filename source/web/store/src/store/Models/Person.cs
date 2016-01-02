using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public abstract class Person
    {
        public virtual  int ID { get; set; }
        public virtual  string FirstName { get; set; }
        public virtual  string LastName { get; set; }
        public virtual  string PhoneNumber { get; set; }
        public virtual  string Email { get; set; }
    }
}
