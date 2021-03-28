using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace biblioteca
{


    static class Program
    {
        public static List<Utente> utenti = new List<Utente>();
            [STAThread]


        public static void CaricaUtenti()
        {
            StreamReader sr = new StreamReader("utenti.json");
            string json = sr.ReadToEnd();
            Program.utenti = JsonConvert.DeserializeObject<List<Utente>>(json);
            sr.Close();
        }

        public static void SalvaUtenti()
        {
            StreamWriter sw = new StreamWriter("utenti.json");
            string json = JsonConvert.SerializeObject(Program.utenti);
            sw.WriteLine(json);
            sw.Close();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
