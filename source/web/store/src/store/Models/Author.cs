using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Author : Person
    {
        public virtual int ID { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}
