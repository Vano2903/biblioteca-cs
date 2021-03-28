
namespace biblioteca
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label6;
            this.libro = new System.Windows.Forms.TabControl();
            this.insLibro = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownIL = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPublishingHouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLoanable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPublishingData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPremium = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listGenders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delLibro = new System.Windows.Forms.TabPage();
            this.modLibro = new System.Windows.Forms.TabPage();
            this.contrPrestiti = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panelVal = new System.Windows.Forms.Panel();
            this.panelISBN = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPublishingHouse = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLoanable = new System.Windows.Forms.Panel();
            this.panelPublishingData = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAuthors = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelGenders = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            this.libro.SuspendLayout();
            this.insLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIL)).BeginInit();
            this.panelVal.SuspendLayout();
            this.panelISBN.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelPublishingHouse.SuspendLayout();
            this.panelLoanable.SuspendLayout();
            this.panelPublishingData.SuspendLayout();
            this.panelAuthors.SuspendLayout();
            this.panelGenders.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // libro
            // 
            this.libro.Controls.Add(this.insLibro);
            this.libro.Controls.Add(this.delLibro);
            this.libro.Controls.Add(this.modLibro);
            this.libro.Controls.Add(this.contrPrestiti);
            this.libro.Location = new System.Drawing.Point(2, 1);
            this.libro.Name = "libro";
            this.libro.SelectedIndex = 0;
            this.libro.Size = new System.Drawing.Size(796, 447);
            this.libro.TabIndex = 3;
            // 
            // insLibro
            // 
            this.insLibro.BackColor = System.Drawing.Color.Transparent;
            this.insLibro.Controls.Add(this.panelGenders);
            this.insLibro.Controls.Add(this.panelAuthors);
            this.insLibro.Controls.Add(this.panel5);
            this.insLibro.Controls.Add(this.panelPublishingData);
            this.insLibro.Controls.Add(this.panelLoanable);
            this.insLibro.Controls.Add(this.panelPublishingHouse);
            this.insLibro.Controls.Add(this.panelTitle);
            this.insLibro.Controls.Add(this.panelISBN);
            this.insLibro.Controls.Add(this.panelVal);
            this.insLibro.Controls.Add(this.listBox1);
            this.insLibro.Controls.Add(this.label1);
            this.insLibro.Controls.Add(this.logoutButton);
            this.insLibro.Controls.Add(this.button1);
            this.insLibro.Controls.Add(this.listView1);
            this.insLibro.Location = new System.Drawing.Point(4, 22);
            this.insLibro.Name = "insLibro";
            this.insLibro.Padding = new System.Windows.Forms.Padding(3);
            this.insLibro.Size = new System.Drawing.Size(788, 421);
            this.insLibro.TabIndex = 0;
            this.insLibro.Text = "inserisci libro";
            this.insLibro.Click += new System.EventHandler(this.insLibro_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "ISBN",
            "titolo ",
            "casa produttrice",
            "prestabile",
            "anno di produzione",
            "locazione",
            "premium",
            "valore",
            "autori",
            "generi"});
            this.listBox1.Location = new System.Drawing.Point(35, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(240, 69);
            this.listBox1.TabIndex = 21;
            this.listBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "tipo di ricerca";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(641, 366);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(140, 54);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Inserisci";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIL
            // 
            this.numericUpDownIL.DecimalPlaces = 2;
            this.numericUpDownIL.Location = new System.Drawing.Point(139, 5);
            this.numericUpDownIL.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownIL.Name = "numericUpDownIL";
            this.numericUpDownIL.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownIL.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listISBN,
            this.listTitle,
            this.listPublishingHouse,
            this.listLoanable,
            this.listPublishingData,
            this.listLocation,
            this.listPremium,
            this.listVal,
            this.listAuthors,
            this.listGenders});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(311, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(470, 277);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listISBN
            // 
            this.listISBN.Text = "ISBN";
            // 
            // listTitle
            // 
            this.listTitle.Text = "titolo";
            // 
            // listPublishingHouse
            // 
            this.listPublishingHouse.Text = "casa produttrice";
            this.listPublishingHouse.Width = 102;
            // 
            // listLoanable
            // 
            this.listLoanable.Text = "prestabile";
            // 
            // listPublishingData
            // 
            this.listPublishingData.Text = "anno produzione";
            // 
            // listLocation
            // 
            this.listLocation.Text = "locazione";
            // 
            // listPremium
            // 
            this.listPremium.Text = "premium";
            // 
            // listVal
            // 
            this.listVal.Text = "valore";
            // 
            // listAuthors
            // 
            this.listAuthors.Text = "autori";
            // 
            // listGenders
            // 
            this.listGenders.Text = "generi";
            // 
            // delLibro
            // 
            this.delLibro.Location = new System.Drawing.Point(4, 22);
            this.delLibro.Name = "delLibro";
            this.delLibro.Padding = new System.Windows.Forms.Padding(3);
            this.delLibro.Size = new System.Drawing.Size(788, 421);
            this.delLibro.TabIndex = 1;
            this.delLibro.Text = "elimina libro";
            this.delLibro.UseVisualStyleBackColor = true;
            // 
            // modLibro
            // 
            this.modLibro.Location = new System.Drawing.Point(4, 22);
            this.modLibro.Name = "modLibro";
            this.modLibro.Size = new System.Drawing.Size(788, 421);
            this.modLibro.TabIndex = 2;
            this.modLibro.Text = "modifica libro";
            this.modLibro.UseVisualStyleBackColor = true;
            // 
            // contrPrestiti
            // 
            this.contrPrestiti.Location = new System.Drawing.Point(4, 22);
            this.contrPrestiti.Name = "contrPrestiti";
            this.contrPrestiti.Size = new System.Drawing.Size(788, 421);
            this.contrPrestiti.TabIndex = 3;
            this.contrPrestiti.Text = "controllo prestiti";
            this.contrPrestiti.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "valore";
            // 
            // panelVal
            // 
            this.panelVal.Controls.Add(this.label2);
            this.panelVal.Controls.Add(this.numericUpDownIL);
            this.panelVal.Location = new System.Drawing.Point(35, 281);
            this.panelVal.Name = "panelVal";
            this.panelVal.Size = new System.Drawing.Size(239, 29);
            this.panelVal.TabIndex = 23;
            // 
            // panelISBN
            // 
            this.panelISBN.Controls.Add(this.textBox1);
            this.panelISBN.Controls.Add(this.label3);
            this.panelISBN.Location = new System.Drawing.Point(35, 94);
            this.panelISBN.Name = "panelISBN";
            this.panelISBN.Size = new System.Drawing.Size(239, 29);
            this.panelISBN.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(13, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "ISBN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 23;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.textBox2);
            this.panelTitle.Controls.Add(this.label4);
            this.panelTitle.Location = new System.Drawing.Point(35, 125);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(239, 29);
            this.panelTitle.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(13, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "titolo";
            // 
            // panelPublishingHouse
            // 
            this.panelPublishingHouse.Controls.Add(this.textBox3);
            this.panelPublishingHouse.Controls.Add(this.label5);
            this.panelPublishingHouse.Location = new System.Drawing.Point(35, 156);
            this.panelPublishingHouse.Name = "panelPublishingHouse";
            this.panelPublishingHouse.Size = new System.Drawing.Size(239, 29);
            this.panelPublishingHouse.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(13, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "casaProduttrice";
            // 
            // panelLoanable
            // 
            this.panelLoanable.Controls.Add(this.comboBox1);
            this.panelLoanable.Controls.Add(label6);
            this.panelLoanable.Location = new System.Drawing.Point(35, 187);
            this.panelLoanable.Name = "panelLoanable";
            this.panelLoanable.Size = new System.Drawing.Size(239, 29);
            this.panelLoanable.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label6.Location = new System.Drawing.Point(13, 5);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 15);
            label6.TabIndex = 22;
            label6.Text = "prestabile";
            // 
            // panelPublishingData
            // 
            this.panelPublishingData.Controls.Add(this.textBox5);
            this.panelPublishingData.Controls.Add(this.label7);
            this.panelPublishingData.Location = new System.Drawing.Point(35, 218);
            this.panelPublishingData.Name = "panelPublishingData";
            this.panelPublishingData.Size = new System.Drawing.Size(239, 29);
            this.panelPublishingData.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(139, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(90, 20);
            this.textBox5.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(13, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "anno produzione";
            // 
            // panelAuthors
            // 
            this.panelAuthors.Controls.Add(this.textBox9);
            this.panelAuthors.Controls.Add(this.label11);
            this.panelAuthors.Location = new System.Drawing.Point(35, 311);
            this.panelAuthors.Name = "panelAuthors";
            this.panelAuthors.Size = new System.Drawing.Size(239, 29);
            this.panelAuthors.TabIndex = 28;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(139, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(90, 20);
            this.textBox9.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(13, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "autori";
            // 
            // panelGenders
            // 
            this.panelGenders.Controls.Add(this.textBox10);
            this.panelGenders.Controls.Add(this.label12);
            this.panelGenders.Location = new System.Drawing.Point(35, 342);
            this.panelGenders.Name = "panelGenders";
            this.panelGenders.Size = new System.Drawing.Size(239, 29);
            this.panelGenders.TabIndex = 28;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(139, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(90, 20);
            this.textBox10.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(13, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "generi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "vero",
            "falso"});
            this.comboBox1.Location = new System.Drawing.Point(139, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(13, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "premium";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox7);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(0, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 29);
            this.panel6.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(13, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "ISBN";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(139, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(90, 20);
            this.textBox7.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(35, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 29);
            this.panel5.TabIndex = 25;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "vero",
            "falso"});
            this.comboBox2.Location = new System.Drawing.Point(139, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.libro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.libro.ResumeLayout(false);
            this.insLibro.ResumeLayout(false);
            this.insLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIL)).EndInit();
            this.panelVal.ResumeLayout(false);
            this.panelVal.PerformLayout();
            this.panelISBN.ResumeLayout(false);
            this.panelISBN.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPublishingHouse.ResumeLayout(false);
            this.panelPublishingHouse.PerformLayout();
            this.panelLoanable.ResumeLayout(false);
            this.panelLoanable.PerformLayout();
            this.panelPublishingData.ResumeLayout(false);
            this.panelPublishingData.PerformLayout();
            this.panelAuthors.ResumeLayout(false);
            this.panelAuthors.PerformLayout();
            this.panelGenders.ResumeLayout(false);
            this.panelGenders.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl libro;
        private System.Windows.Forms.TabPage insLibro;
        private System.Windows.Forms.TabPage delLibro;
        private System.Windows.Forms.TabPage modLibro;
        private System.Windows.Forms.TabPage contrPrestiti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownIL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ColumnHeader listISBN;
        private System.Windows.Forms.ColumnHeader listTitle;
        private System.Windows.Forms.ColumnHeader listPublishingHouse;
        private System.Windows.Forms.ColumnHeader listLoanable;
        private System.Windows.Forms.ColumnHeader listPublishingData;
        private System.Windows.Forms.ColumnHeader listLocation;
        private System.Windows.Forms.ColumnHeader listPremium;
        private System.Windows.Forms.ColumnHeader listVal;
        private System.Windows.Forms.ColumnHeader listAuthors;
        private System.Windows.Forms.ColumnHeader listGenders;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGenders;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelAuthors;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPublishingData;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelLoanable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelPublishingHouse;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelISBN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}