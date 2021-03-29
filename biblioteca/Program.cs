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
        public static List<Book> libri= new List<Book>();
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

        public static void CaricaLibri()
        {
            StreamReader sr = new StreamReader("libri.json");
            string json = sr.ReadToEnd();
            Program.utenti = JsonConvert.DeserializeObject<List<Utente>>(json);
            sr.Close();
        }

        public static void SalvaLibri()
        {
            StreamWriter sw = new StreamWriter("libri.json");
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
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            AddLog((Exception)e.ExceptionObject);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            AddLog(e.Exception);
        }

        static void AddLog(Exception exception)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"d:\tmp\app.log", true))
                {
                    sw.WriteLine(exception.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

