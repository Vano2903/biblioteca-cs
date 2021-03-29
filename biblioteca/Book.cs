using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Book
    {
        
        public string ISBN;
        public string title;
        public string publishingHouse;
        public bool loanable;
        public int publishingYear;
        //public Location location;
        public bool premium;
        public float val;
        public List<string> authors = new List<string>();
        public List<string> genders = new List<string>();

        public Book(string nISBN, string ntitle, string npublishingHouse, bool nloanable, int npublishingYear, bool npremium, float nval, List<string> nauthors, List<string> ngenders)
        {
            ISBN = nISBN;
            title = ntitle;
            publishingHouse = npublishingHouse;
            loanable = nloanable;
            publishingYear = npublishingYear;
            premium = npremium;
            val = nval;
            authors = nauthors;
            genders = ngenders;
        }
    }

    
}
