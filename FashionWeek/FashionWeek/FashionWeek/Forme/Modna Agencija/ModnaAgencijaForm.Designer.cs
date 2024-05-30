namespace FashionWeek.Forme
{
    partial class ModnaAgencijaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModnaAgencijaForm));
            groupBox1 = new GroupBox();
            listaModnihAgencija = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox2 = new GroupBox();
            cmdIzmeniModnuAgenciju = new Button();
            cmdObrisiModnuAgenciju = new Button();
            cmdDodajModnuKucu = new Button();
            btnPrikaziManekene = new Button();
            groupBox3 = new GroupBox();
            btnNaziviZemalja_MsgBox = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihAgencija);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 47);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(419, 343);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Modnih Agencija";
            // 
            // listaModnihAgencija
            // 
            listaModnihAgencija.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihAgencija.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listaModnihAgencija.Dock = DockStyle.Fill;
            listaModnihAgencija.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listaModnihAgencija.FullRowSelect = true;
            listaModnihAgencija.GridLines = true;
            listaModnihAgencija.Location = new Point(3, 24);
            listaModnihAgencija.Margin = new Padding(3, 4, 3, 4);
            listaModnihAgencija.Name = "listaModnihAgencija";
            listaModnihAgencija.Size = new Size(413, 315);
            listaModnihAgencija.TabIndex = 4;
            listaModnihAgencija.UseCompatibleStateImageBehavior = false;
            listaModnihAgencija.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PIB";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum Osnivanja";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Drzava";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Grad";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Internacionalna";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmdIzmeniModnuAgenciju);
            groupBox2.Controls.Add(cmdObrisiModnuAgenciju);
            groupBox2.Controls.Add(cmdDodajModnuKucu);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(494, 72);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(257, 241);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci O Modnim Agencijama";
            // 
            // cmdIzmeniModnuAgenciju
            // 
            cmdIzmeniModnuAgenciju.BackColor = SystemColors.GradientActiveCaption;
            cmdIzmeniModnuAgenciju.Location = new Point(55, 177);
            cmdIzmeniModnuAgenciju.Margin = new Padding(3, 4, 3, 4);
            cmdIzmeniModnuAgenciju.Name = "cmdIzmeniModnuAgenciju";
            cmdIzmeniModnuAgenciju.Size = new Size(167, 45);
            cmdIzmeniModnuAgenciju.TabIndex = 3;
            cmdIzmeniModnuAgenciju.Text = "Izmeni Modnu Agenciju";
            cmdIzmeniModnuAgenciju.UseVisualStyleBackColor = false;
            cmdIzmeniModnuAgenciju.Click += cmdIzmeniModnuAgenciju_Click;
            // 
            // cmdObrisiModnuAgenciju
            // 
            cmdObrisiModnuAgenciju.BackColor = SystemColors.GradientActiveCaption;
            cmdObrisiModnuAgenciju.Location = new Point(55, 108);
            cmdObrisiModnuAgenciju.Margin = new Padding(3, 4, 3, 4);
            cmdObrisiModnuAgenciju.Name = "cmdObrisiModnuAgenciju";
            cmdObrisiModnuAgenciju.Size = new Size(167, 45);
            cmdObrisiModnuAgenciju.TabIndex = 2;
            cmdObrisiModnuAgenciju.Text = "Obrisi Modnu Agenciju";
            cmdObrisiModnuAgenciju.UseVisualStyleBackColor = false;
            cmdObrisiModnuAgenciju.Click += btnObrisiModnuAgenciju;
            // 
            // cmdDodajModnuKucu
            // 
            cmdDodajModnuKucu.BackColor = SystemColors.GradientActiveCaption;
            cmdDodajModnuKucu.Location = new Point(55, 29);
            cmdDodajModnuKucu.Margin = new Padding(3, 4, 3, 4);
            cmdDodajModnuKucu.Name = "cmdDodajModnuKucu";
            cmdDodajModnuKucu.Size = new Size(167, 49);
            cmdDodajModnuKucu.TabIndex = 1;
            cmdDodajModnuKucu.Text = "Dodaj Modnu Agenciju";
            cmdDodajModnuKucu.UseVisualStyleBackColor = false;
            cmdDodajModnuKucu.Click += cmdDodajModnuKucu_Click;
            // 
            // btnPrikaziManekene
            // 
            btnPrikaziManekene.BackColor = SystemColors.GradientActiveCaption;
            btnPrikaziManekene.Location = new Point(55, 41);
            btnPrikaziManekene.Margin = new Padding(3, 4, 3, 4);
            btnPrikaziManekene.Name = "btnPrikaziManekene";
            btnPrikaziManekene.Size = new Size(167, 55);
            btnPrikaziManekene.TabIndex = 10;
            btnPrikaziManekene.Text = "Prikazi Manekene";
            btnPrikaziManekene.UseVisualStyleBackColor = false;
            btnPrikaziManekene.Click += btnPrikaziManekene_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPrikaziManekene);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(494, 359);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(257, 120);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Podaci O Manekenima";
            // 
            // btnNaziviZemalja_MsgBox
            // 
            btnNaziviZemalja_MsgBox.BackColor = SystemColors.GradientActiveCaption;
            btnNaziviZemalja_MsgBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNaziviZemalja_MsgBox.Location = new Point(33, 400);
            btnNaziviZemalja_MsgBox.Margin = new Padding(3, 4, 3, 4);
            btnNaziviZemalja_MsgBox.Name = "btnNaziviZemalja_MsgBox";
            btnNaziviZemalja_MsgBox.Size = new Size(132, 57);
            btnNaziviZemalja_MsgBox.TabIndex = 12;
            btnNaziviZemalja_MsgBox.Text = "Nazivi Zemalja";
            btnNaziviZemalja_MsgBox.UseVisualStyleBackColor = false;
            btnNaziviZemalja_MsgBox.Click += btnNaziviZemalja_MsgBox_Click;
            // 
            // ModnaAgencijaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(831, 541);
            Controls.Add(btnNaziviZemalja_MsgBox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModnaAgencijaForm";
            Text = "ModnaAgencijaForm";
            Load += ModnaAgencija_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaModnihAgencija;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox2;
        private Button cmdIzmeniModnuAgenciju;
        private Button cmdObrisiModnuAgenciju;
        private Button cmdDodajModnuKucu;
        private Button btnPrikaziManekene;
        private GroupBox groupBox3;
        private Button btnNaziviZemalja_MsgBox;
    }
}