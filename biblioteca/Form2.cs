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
        private void cleanPanels()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            comboBox2.Text = "";
            textBox7.Text = "";
            numericUpDownIL.Text = "0.00";
            //hideAllPanels();
        }

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("hai cliccato");
            //List<int> elements = selectedListBoxElements();
            //foreach (var index in elements)
            //{
            //    showElements(index);
            //}
        }

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
    }
}
