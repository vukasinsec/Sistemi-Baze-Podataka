namespace FashionWeek.Forme
{
    partial class ModniKreatoriOrganizatoriDodajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModniKreatoriOrganizatoriDodajForm));
            cmdDodajModnogKreatora = new Button();
            groupBox1 = new GroupBox();
            cenaUsluge = new NumericUpDown();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox8 = new TextBox();
            label3 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            labelaImeJavneLicnosti = new Label();
            labelaVremeOdrzavanja = new Label();
            labelaDatumOdrzavanja = new Label();
            labelaGrad = new Label();
            labelaNaziv = new Label();
            groupBox2 = new GroupBox();
            listaModnihKucaIzKreatora = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cenaUsluge).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmdDodajModnogKreatora
            // 
            cmdDodajModnogKreatora.BackColor = SystemColors.GradientActiveCaption;
            cmdDodajModnogKreatora.Font = new Font("Broadway", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdDodajModnogKreatora.Location = new Point(159, 488);
            cmdDodajModnogKreatora.Margin = new Padding(3, 4, 3, 4);
            cmdDodajModnogKreatora.Name = "cmdDodajModnogKreatora";
            cmdDodajModnogKreatora.Size = new Size(189, 53);
            cmdDodajModnogKreatora.TabIndex = 7;
            cmdDodajModnogKreatora.Text = "Dodaj Modnog Kreatora";
            cmdDodajModnogKreatora.UseVisualStyleBackColor = false;
            cmdDodajModnogKreatora.Click += cmdDodajModnogKreatora_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(cenaUsluge);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelaImeJavneLicnosti);
            groupBox1.Controls.Add(labelaVremeOdrzavanja);
            groupBox1.Controls.Add(labelaDatumOdrzavanja);
            groupBox1.Controls.Add(labelaGrad);
            groupBox1.Controls.Add(labelaNaziv);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 36);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(450, 420);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni Podaci O Modnim Kreatorima";
            // 
            // cenaUsluge
            // 
            cenaUsluge.Location = new Point(134, 371);
            cenaUsluge.Margin = new Padding(3, 5, 3, 5);
            cenaUsluge.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            cenaUsluge.Name = "cenaUsluge";
            cenaUsluge.Size = new Size(157, 27);
            cenaUsluge.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(35, 373);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 34;
            label1.Text = "Cena Usluge";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 151);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 33;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(159, 111);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(40, 24);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Z";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(110, 111);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(45, 24);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "M";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(134, 312);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(114, 27);
            textBox8.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(35, 323);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 15;
            label3.Text = "Prezime";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(134, 261);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(114, 27);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(165, 205);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 56);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 8;
            // 
            // labelaImeJavneLicnosti
            // 
            labelaImeJavneLicnosti.AutoSize = true;
            labelaImeJavneLicnosti.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaImeJavneLicnosti.Location = new Point(35, 265);
            labelaImeJavneLicnosti.Name = "labelaImeJavneLicnosti";
            labelaImeJavneLicnosti.Size = new Size(36, 20);
            labelaImeJavneLicnosti.TabIndex = 4;
            labelaImeJavneLicnosti.Text = "Ime";
            // 
            // labelaVremeOdrzavanja
            // 
            labelaVremeOdrzavanja.AutoSize = true;
            labelaVremeOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaVremeOdrzavanja.Location = new Point(35, 212);
            labelaVremeOdrzavanja.Name = "labelaVremeOdrzavanja";
            labelaVremeOdrzavanja.Size = new Size(116, 20);
            labelaVremeOdrzavanja.TabIndex = 3;
            labelaVremeOdrzavanja.Text = "Zemlja Porekla";
            // 
            // labelaDatumOdrzavanja
            // 
            labelaDatumOdrzavanja.AutoSize = true;
            labelaDatumOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaDatumOdrzavanja.Location = new Point(35, 157);
            labelaDatumOdrzavanja.Name = "labelaDatumOdrzavanja";
            labelaDatumOdrzavanja.Size = new Size(124, 20);
            labelaDatumOdrzavanja.TabIndex = 2;
            labelaDatumOdrzavanja.Text = "Datum Rodjenja";
            // 
            // labelaGrad
            // 
            labelaGrad.AutoSize = true;
            labelaGrad.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaGrad.Location = new Point(35, 111);
            labelaGrad.Name = "labelaGrad";
            labelaGrad.Size = new Size(32, 20);
            labelaGrad.TabIndex = 1;
            labelaGrad.Text = "Pol";
            // 
            // labelaNaziv
            // 
            labelaNaziv.AutoSize = true;
            labelaNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaNaziv.Location = new Point(35, 60);
            labelaNaziv.Name = "labelaNaziv";
            labelaNaziv.Size = new Size(42, 20);
            labelaNaziv.TabIndex = 0;
            labelaNaziv.Text = "MBR";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listaModnihKucaIzKreatora);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(509, 87);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(567, 343);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista Modnih Kuca";
            // 
            // listaModnihKucaIzKreatora
            // 
            listaModnihKucaIzKreatora.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihKucaIzKreatora.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listaModnihKucaIzKreatora.Dock = DockStyle.Fill;
            listaModnihKucaIzKreatora.FullRowSelect = true;
            listaModnihKucaIzKreatora.GridLines = true;
            listaModnihKucaIzKreatora.Location = new Point(3, 24);
            listaModnihKucaIzKreatora.Margin = new Padding(3, 4, 3, 4);
            listaModnihKucaIzKreatora.Name = "listaModnihKucaIzKreatora";
            listaModnihKucaIzKreatora.Size = new Size(561, 315);
            listaModnihKucaIzKreatora.TabIndex = 4;
            listaModnihKucaIzKreatora.UseCompatibleStateImageBehavior = false;
            listaModnihKucaIzKreatora.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Naziv";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Ime Osnivaca";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Prezime Osnivaca";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Drzava";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Grad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(509, 36);
            label2.Name = "label2";
            label2.Size = new Size(352, 20);
            label2.TabIndex = 12;
            label2.Text = "Selektujte Modnu Kucu u kojoj radi modni kreator:";
            // 
            // ModniKreatoriOrganizatoriDodajForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1141, 629);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(cmdDodajModnogKreatora);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModniKreatoriOrganizatoriDodajForm";
            Text = "ModniKreatoriOrganizatoriDodajForm";
            Load += ModniKreatoriOrganizatoriDodajForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cenaUsluge).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdDodajModnogKreatora;
        private GroupBox groupBox1;
        private NumericUpDown cenaUsluge;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox8;
        private Label label3;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label labelaImeJavneLicnosti;
        private Label labelaVremeOdrzavanja;
        private Label labelaDatumOdrzavanja;
        private Label labelaGrad;
        private Label labelaNaziv;
        private GroupBox groupBox2;
        private ListView listaModnihKucaIzKreatora;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label label2;
    }
}