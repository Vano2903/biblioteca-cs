using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

/*TODO
 * capire se utente é attivo o meno
 * fixare gli id perché il conteggio non é corretto 
*/
namespace biblioteca {
    class Utente {
        public string id;
        public string password;
        public bool isUtente;
        //private string name;
        //private string lastName;
        //private Data bornDate;
        public Data registrationData = new Data();// { get; set; }
        public string mail;
        //private Address address;
        public List<string> historianBooks = new List<string>();
        public List<Loan> loans = new List<Loan>();
        //private string phone;
        public List<Suspension> suspension = new List<Suspension>();
        public bool isPremium;

        //-----------------------------------------------metodi private


        private void GenId()
        {
            string lastId = System.IO.File.ReadAllText("config\\lastId.txt");
            int lastIdI = int.Parse(lastId);
            id = (lastIdI + 1).ToString();
            File.WriteAllText("config\\lastId.txt", id);
        }

        //-----------------------------------------------metodi public

        public bool getIsUtente()
        {
            return isUtente;
        }
        public string getPassword()
        {
            return password;
        }

        public string getMail()
        {
            return mail;
        }

        public Utente(string email, string password, bool isUtente)
        {
            registrationData.Today();
            GenId();
            this.mail = email;
            this.password = password;
            this.isUtente = isUtente;
            isPremium = false;
        }
    }
}