using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca {
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 accesso = new Form1();
            accesso.Show();
        }
       
        private List<int> selectedListBoxElements()
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
            if (listBox1.SelectedItem.Equals("casa produttrice") == true)
            {
                elements.Add(2);
            }
            if (listBox1.SelectedItem.Equals("prestabile") == true)
            {
                elements.Add(3);
            }
            if (listBox1.SelectedItem.Equals("anno di produzione") == true)
            {
                elements.Add(4);
            }
            if (listBox1.SelectedItem.Equals("premium") == true)
            {
                elements.Add(5);
            }
            if (listBox1.SelectedItem.Equals("valore") == true)
            {
                elements.Add(6);
            }
            if (listBox1.SelectedItem.Equals("autori") == true)
            {
                elements.Add(7);
            }
            if (listBox1.SelectedItem.Equals("generi") == true)
            {
                elements.Add(8);
            }
            return elements;
        }

        private void showElements(int i)
        {
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
                    panelPublishingData.Show();
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
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> elements = selectedListBoxElements();
            foreach(var index in elements)
            {

            }
        }
    }
}
