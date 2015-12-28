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
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Author> Authors { get; set; }
        public string ISBN { get; set; }
        public string ISBN13 { get; set; }
        public List<Genre> Genres { get; set; }



    }
}
