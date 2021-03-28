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
        private string ISBN;
        private string title;
        private string publishingHouse;
        //private bool loanable;
        private Data publishingData;
        private Location location;
        private bool premium;
        private float val;
        private List<string> autors = new List<string>();
        private List<string> genders = new List<string>();
    }


}
