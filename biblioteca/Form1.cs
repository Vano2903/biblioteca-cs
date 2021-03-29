using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

/*TODO 
 * condizioni password 
 * regex per email
 * messaggio errore per utente non trovato (login) x
 * messaggio errore per password non valida (singup)
 * messaggio errore per email giá usata (signup) x
 * controllo password di conferma (signup)
 * aggiungi sicurezza per singup come bibliotecario (hash che cambia giornalmente, inserirla come campo per conferma)
 * bloccare i controlli se ci sono campi vuoti x
*/
namespace biblioteca {
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            login.Visible = true;
            signUp.Visible = false;
        }


        //change to singup panel
        private void button4_Click(object sender, EventArgs e)
        {
            signUp.Visible = false;
            login.Visible = true;
        }

        //change to login panel
        private void button5_Click(object sender, EventArgs e)
        {
            signUp.Visible = true;
            login.Visible = false;
        }

        //controlli di login 
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox3.Text == "")
            {
                errorLogin.Text = "tutti i campi devono essere compilati";
            }
            else
            {
                bool found = false;
                Program.CaricaUtenti();
                foreach (var utente in Program.utenti)
                {
                    if (textBox4.Text == utente.getMail())
                    {
                        if (textBox3.Text == utente.getPassword())
                        {
                            found = true;
                            if (utente.getIsUtente() == true)
                            {
                                
                                Hide();
                                Form3 utent = new Form3();
                                utent.Show();
                                break;
                            }
                            else
                            {
                                
                                Hide();
                                Form2 b = new Form2();
                                b.Show();
                                break;
                            }
                        }
                    }
                }
                if (found == false)
                {
                    errorLogin.Text = "utente non trovato";
                }
            }
        }

        private int checkRadios()
        {
            if (radioButton1.Checked == true)
            {
                return 1;
            }
            else if (radioButton2.Checked == true)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        private int checkSignUp()
        {
            int type = checkRadios();
            if (type == -1)
            {
                return -1;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "")
            {
                return -1;
            }
            return type;
        }
        //controlli di singUp 
        private void button2_Click(object sender, EventArgs e)
        {
            bool used = false;
            int type = checkSignUp();
            if (type == -1)
            {
                messageSignUp.Text = "tutti i campi devono essere compilati";
            }
            else
            {
                Program.CaricaUtenti();
                foreach (var utente in Program.utenti)
                {
                    if (textBox4.Text == utente.getMail())
                    {
                        messageSignUp.Text = "email giá registrata";
                        used = true;
                        break;
                    }
                }
                if (used == false)
                {
                    Utente newUtente = new Utente(textBox1.Text, textBox2.Text, type == 2 ? false : true);
                    Program.utenti.Add(newUtente);
                    Program.SalvaUtenti();
                    messageSignUp.Text = "utente registrato correttamente";
                    signUp.Visible = false;
                    login.Visible = true;
                }
            }
        }


    }
}