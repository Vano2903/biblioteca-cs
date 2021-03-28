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
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void indietro_Click(object sender, EventArgs e) {
            this.Hide();
            var registraForm = new Form1();
            registraForm.Show();
        }

        private void insLibro_Click(object sender, EventArgs e)
        {

        }

    }
}
