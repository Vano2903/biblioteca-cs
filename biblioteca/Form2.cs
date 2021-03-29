using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*TODO
 * sistemare logica del form con panel che compaiono
*/

namespace biblioteca {
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Hide();
            // listBox1.Hide();
            showAllPanels();
            Program.CaricaLibri();
            showBooks();
            cleanPanels();
        }


        /*  private List<int> selectedListBoxElements()
          {
              List<int> elements = new List<int>();
              if (listBox1.SelectedItem.Equals("ISBN") == true)
              {
                  elements.Add(0);
              }
              if (listBox1.SelectedItem.Equals("titolo") == true)
              {
                  elements.Add(1);
              }
              else
              {
                  elements.Remove(1);
              }
              if (listBox1.SelectedItem.Equals("casa produttrice") == true)
              {
                  elements.Add(2);
              }
              else
              {
                  elements.Remove(2);
              }
              if (listBox1.SelectedItem.Equals("prestabile") == true)
              {
                  elements.Add(3);
              }
              else
              {
                  elements.Remove(3);
              }
              if (listBox1.SelectedItem.Equals("anno di produzione") == true)
              {
                  elements.Add(4);
              }
              else
              {
                  elements.Remove(4);
              }
              if (listBox1.SelectedItem.Equals("premium") == true)
              {
                  elements.Add(5);
              }
              else
              {
                  elements.Remove(5);
              }
              if (listBox1.SelectedItem.Equals("valore") == true)
              {
                  elements.Add(6);
              }
              else
              {
                  elements.Remove(6);
              }
              if (listBox1.SelectedItem.Equals("autori") == true)
              {
                  elements.Add(7);
              }
              else
              {
                  elements.Remove(7);
              }
              if (listBox1.SelectedItem.Equals("generi") == true)
              {
                  elements.Add(8);
              }
              else
              {
                  elements.Remove(8);
              }
              return elements;
          }
        */


        private void showElements(int i)
        {
            cleanPanels();
            switch (i)
            {
                case 0:
                    panelISBN.Show();
                    break;
                case 1:
                    panelTitle.Show();
                    break;
                case 2:
                    panelPublishingHouse.Show();
                    break;
                case 3:
                    panelLoanable.Show();
                    break;
                case 4:
                    panelPublishingYear.Show();
                    break;
                case 5:
                    panelPremium.Show();
                    break;
                case 6:
                    panelVal.Show();
                    break;
                case 7:
                    panelAuthors.Show();
                    break;
                case 8:
                    panelGenders.Show();
                    break;
            }
        }

        private void hideAllPanels() {
            panelISBN.Hide();
            panelTitle.Hide();
            panelPublishingHouse.Hide();
            panelLoanable.Hide();
            panelPublishingYear.Hide();
            panelPremium.Hide();
            panelVal.Hide();
            panelAuthors.Hide();
            panelGenders.Hide();
        }

        private void showAllPanels()
        {
            panelISBN.Show();
            panelTitle.Show();
            panelPublishingHouse.Show();
            panelLoanable.Show();
            panelPublishingYear.Show();
            panelPremium.Show();
            panelVal.Show();
            panelAuthors.Show();
            panelGenders.Show();
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e){
        //MessageBox.Show("hai cliccato");
        //List<int> elements = selectedListBoxElements();
        //foreach (var index in elements)
        //{
        //    showElements(index);
        //}
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            cleanPanels();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 accesso = new Form1();
            accesso.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && numericUpDownIL.Value > 0
                && comboBox1.Text != "" && comboBox2.Text != "" && numericUpDown1.Value > 0
                && textBox9.Text != "" && textBox10.Text != "")
            {
                addBook();
                showBooks();
                cleanPanels();
            }
            else MessageBox.Show("Campi incompleti");

        }
        private void ResizeListView1Columns()
        {
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }
        }
        private void showBooks()
        {
            listView1.Items.Clear();
            foreach (Book b in Program.libri)
            {
                string authors = string.Join(";", b.authors);
                string genders = string.Join(";", b.genders);
                string[] array = { b.ISBN, b.title, b.publishingHouse, b.loanable.ToString(), b.publishingYear.ToString(),
                b.premium.ToString(), b.val.ToString(), genders, authors};
                listView1.Items.Add(new ListViewItem(array));
            };
            ResizeListView1Columns();
        }




        private void addBook()
        {
            List<string> agenders = getAllGenders();
            List<string> aauthors = getAllAuthors();
            Book nuovolibro = new Book(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text == "falso" ? false : true,
                int.Parse(numericUpDown1.Text), comboBox2.Text == "falso" ? false : true,
                float.Parse(numericUpDownIL.Text), agenders, aauthors);
            Program.libri.Add(nuovolibro);
        }
        private List<string> getAllGenders()
        {
            List<string> genders = new List<string>();
            genders = textBox10.Text.Split(';').ToList();
            return genders;
        }
        private List<string> getAllAuthors()
        {
            List<string> authors = new List<string>();
            authors = textBox9.Text.Split(';').ToList();
            return authors;
        }
        private void cleanPanels()
        {
            textBox1.Text = ""; //ISBN;
            textBox2.Text = ""; //title;
            textBox3.Text = ""; //publishingHouse
            comboBox1.Text = ""; //loanable
            numericUpDown1.Text = "0"; //publishingYear
            comboBox2.Text = ""; //premium
            numericUpDownIL.Text = "0.00"; //val
            textBox9.Text = ""; //authors
            textBox10.Text = ""; //genders
        }
    }
}
