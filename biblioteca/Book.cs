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
        //private bool loanable;
        public int publishingYear;
        public Location location;
        public bool premium;
        public float val;
        public List<string> authors = new List<string>();
        public List<string> genders = new List<string>();
    }


}
