using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Author : Person
    {
        public int ID { get; set; }
        public List<Book> Books { get; set; }

    }
}
