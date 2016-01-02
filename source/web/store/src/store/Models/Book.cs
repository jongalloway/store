using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class Book : Product
    {
        public enum Genre
        {
            History,
            Science,
            Health,
            Cooking,
            Religion,
            LGBTQ,
            Biography,
            GeneralFiction,
            Literature,
            SciFiFantasy,
            Mystery,
            Horror,
            Thriller,


        }
        public virtual  int ID { get; set; }
        public virtual  string Name { get; set; }
        public virtual  List<Author> Authors { get; set; }
        public virtual  string ISBN { get; set; }
        public virtual  string ISBN13 { get; set; }
        public virtual  List<Genre> Genres { get; set; }



    }
}
