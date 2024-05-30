namespace FashionWeek.Forme
{
    partial class ModneRevijeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModneRevijeForm));
            groupBox1 = new GroupBox();
            listaModnihRevija = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            cmdDodajModnuReviju = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            cmdIzmeniModnuReviju = new Button();
            cmdObrisiModnuReviju = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihRevija);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 52);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(567, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Modnih Revija";
            // 
            // listaModnihRevija
            // 
            listaModnihRevija.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihRevija.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader8, columnHeader9, columnHeader10 });
            listaModnihRevija.Dock = DockStyle.Fill;
            listaModnihRevija.FullRowSelect = true;
            listaModnihRevija.GridLines = true;
            listaModnihRevija.Location = new Point(3, 24);
            listaModnihRevija.Margin = new Padding(3, 4, 3, 4);
            listaModnihRevija.Name = "listaModnihRevija";
            listaModnihRevija.Size = new Size(561, 315);
            listaModnihRevija.TabIndex = 4;
            listaModnihRevija.UseCompatibleStateImageBehavior = false;
            listaModnihRevija.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Redni Broj";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Naziv";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Grad";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Datum Odrzavanja";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Vreme Odrzavanja";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ime Javne Licnosti";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Prezime Javne Licnosti";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Zanimanje Javne Licnosti";
            // 
            // cmdDodajModnuReviju
            // 
            cmdDodajModnuReviju.BackColor = SystemColors.GradientActiveCaption;
            cmdDodajModnuReviju.Location = new Point(55, 29);
            cmdDodajModnuReviju.Margin = new Padding(3, 4, 3, 4);
            cmdDodajModnuReviju.Name = "cmdDodajModnuReviju";
            cmdDodajModnuReviju.Size = new Size(157, 49);
            cmdDodajModnuReviju.TabIndex = 1;
            cmdDodajModnuReviju.Text = "Dodaj Modnu Reviju";
            cmdDodajModnuReviju.UseVisualStyleBackColor = false;
            cmdDodajModnuReviju.Click += cmdDodajModnuReviju_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(cmdIzmeniModnuReviju);
            groupBox2.Controls.Add(cmdObrisiModnuReviju);
            groupBox2.Controls.Add(cmdDodajModnuReviju);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(607, 52);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(257, 241);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci O Modnim Revijama";
            // 
            // cmdIzmeniModnuReviju
            // 
            cmdIzmeniModnuReviju.BackColor = SystemColors.GradientActiveCaption;
            cmdIzmeniModnuReviju.Location = new Point(55, 177);
            cmdIzmeniModnuReviju.Margin = new Padding(3, 4, 3, 4);
            cmdIzmeniModnuReviju.Name = "cmdIzmeniModnuReviju";
            cmdIzmeniModnuReviju.Size = new Size(157, 45);
            cmdIzmeniModnuReviju.TabIndex = 3;
            cmdIzmeniModnuReviju.Text = "Izmeni Modnu Reviju";
            cmdIzmeniModnuReviju.UseVisualStyleBackColor = false;
            cmdIzmeniModnuReviju.Click += cmdIzmeniModnuReviju_Click;
            // 
            // cmdObrisiModnuReviju
            // 
            cmdObrisiModnuReviju.BackColor = SystemColors.GradientActiveCaption;
            cmdObrisiModnuReviju.Location = new Point(55, 108);
            cmdObrisiModnuReviju.Margin = new Padding(3, 4, 3, 4);
            cmdObrisiModnuReviju.Name = "cmdObrisiModnuReviju";
            cmdObrisiModnuReviju.Size = new Size(157, 45);
            cmdObrisiModnuReviju.TabIndex = 2;
            cmdObrisiModnuReviju.Text = "Obrisi Modnu Reviju";
            cmdObrisiModnuReviju.UseVisualStyleBackColor = false;
            cmdObrisiModnuReviju.Click += cmdObrisiModnuReviju_Click;
            // 
            // ModneRevijeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(925, 617);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModneRevijeForm";
            Text = "ModneRevijeForm";
            Load += ModneRevijeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaModnihRevija;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button cmdDodajModnuReviju;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private Button cmdIzmeniModnuReviju;
        private Button cmdObrisiModnuReviju;
    }
}