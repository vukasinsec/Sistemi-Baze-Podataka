namespace FashionWeek.Forme
{
    partial class ModniKreatoriIzModneKuceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModniKreatoriIzModneKuceForm));
            groupBox1 = new GroupBox();
            listaModnihKreatora = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            button1 = new Button();
            groupBox2 = new GroupBox();
            cmdIzmeniModnuReviju = new Button();
            cmdObrisiModnuReviju = new Button();
            cmdDodajModnuReviju = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihKreatora);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 29);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(542, 384);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Modnih Kreatora";
            // 
            // listaModnihKreatora
            // 
            listaModnihKreatora.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihKreatora.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader11 });
            listaModnihKreatora.Dock = DockStyle.Fill;
            listaModnihKreatora.FullRowSelect = true;
            listaModnihKreatora.GridLines = true;
            listaModnihKreatora.Location = new Point(3, 25);
            listaModnihKreatora.Margin = new Padding(3, 5, 3, 5);
            listaModnihKreatora.Name = "listaModnihKreatora";
            listaModnihKreatora.Size = new Size(536, 354);
            listaModnihKreatora.TabIndex = 4;
            listaModnihKreatora.UseCompatibleStateImageBehavior = false;
            listaModnihKreatora.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MBR";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Pol";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DatumRodjenja";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ZemljaPorekla";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ime";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Prezime";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Cena Usluge";
            // 
            // button1
            // 
            button1.Location = new Point(714, 316);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(9, 11);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(cmdIzmeniModnuReviju);
            groupBox2.Controls.Add(cmdObrisiModnuReviju);
            groupBox2.Controls.Add(cmdDodajModnuReviju);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(618, 85);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(257, 256);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci O Modnim Kreatorima";
            // 
            // cmdIzmeniModnuReviju
            // 
            cmdIzmeniModnuReviju.BackColor = SystemColors.GradientActiveCaption;
            cmdIzmeniModnuReviju.Location = new Point(55, 177);
            cmdIzmeniModnuReviju.Margin = new Padding(3, 4, 3, 4);
            cmdIzmeniModnuReviju.Name = "cmdIzmeniModnuReviju";
            cmdIzmeniModnuReviju.Size = new Size(157, 64);
            cmdIzmeniModnuReviju.TabIndex = 3;
            cmdIzmeniModnuReviju.Text = "Izmeni Modnog Kreatora";
            cmdIzmeniModnuReviju.UseVisualStyleBackColor = false;
            cmdIzmeniModnuReviju.Click += cmdIzmeniModnogKreatora_Click;
            // 
            // cmdObrisiModnuReviju
            // 
            cmdObrisiModnuReviju.BackColor = SystemColors.GradientActiveCaption;
            cmdObrisiModnuReviju.Location = new Point(55, 105);
            cmdObrisiModnuReviju.Margin = new Padding(3, 4, 3, 4);
            cmdObrisiModnuReviju.Name = "cmdObrisiModnuReviju";
            cmdObrisiModnuReviju.Size = new Size(157, 52);
            cmdObrisiModnuReviju.TabIndex = 2;
            cmdObrisiModnuReviju.Text = "Obrisi Modnog Kreatora";
            cmdObrisiModnuReviju.UseVisualStyleBackColor = false;
            cmdObrisiModnuReviju.Click += cmdObrisiModnogKreatora_Click;
            // 
            // cmdDodajModnuReviju
            // 
            cmdDodajModnuReviju.BackColor = SystemColors.GradientActiveCaption;
            cmdDodajModnuReviju.Location = new Point(55, 29);
            cmdDodajModnuReviju.Margin = new Padding(3, 4, 3, 4);
            cmdDodajModnuReviju.Name = "cmdDodajModnuReviju";
            cmdDodajModnuReviju.Size = new Size(157, 55);
            cmdDodajModnuReviju.TabIndex = 1;
            cmdDodajModnuReviju.Text = "Dodaj Modnog Kreatora";
            cmdDodajModnuReviju.UseVisualStyleBackColor = false;
            cmdDodajModnuReviju.Click += cmdDodajModnogKreatora_Click;
            // 
            // ModniKreatoriIzModneKuceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 460);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModniKreatoriIzModneKuceForm";
            Text = "ModniKreatoriIzModneKuceForm";
            Load += ModniKreatoriIzModneKuceForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaModnihKreatora;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader11;
        private Button button1;
        private GroupBox groupBox2;
        private Button cmdIzmeniModnuReviju;
        private Button cmdObrisiModnuReviju;
        private Button cmdDodajModnuReviju;
    }
}