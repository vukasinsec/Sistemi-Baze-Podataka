namespace FashionWeek.Forme
{
    partial class ModneKuceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModneKuceForm));
            groupBox2 = new GroupBox();
            cmdIzmeniModnuKucu = new Button();
            cmdObrisiModnuKucu = new Button();
            cmdDodajModnuKucu = new Button();
            groupBox1 = new GroupBox();
            listaModnihKuca = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            groupBox3 = new GroupBox();
            button2 = new Button();
            groupBox4 = new GroupBox();
            button1 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(cmdIzmeniModnuKucu);
            groupBox2.Controls.Add(cmdObrisiModnuKucu);
            groupBox2.Controls.Add(cmdDodajModnuKucu);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(531, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 181);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci O Modnim Kucama";
            // 
            // cmdIzmeniModnuKucu
            // 
            cmdIzmeniModnuKucu.BackColor = SystemColors.GradientActiveCaption;
            cmdIzmeniModnuKucu.Location = new Point(48, 133);
            cmdIzmeniModnuKucu.Name = "cmdIzmeniModnuKucu";
            cmdIzmeniModnuKucu.Size = new Size(137, 34);
            cmdIzmeniModnuKucu.TabIndex = 3;
            cmdIzmeniModnuKucu.Text = "Izmeni Modnu Kucu";
            cmdIzmeniModnuKucu.UseVisualStyleBackColor = false;
            cmdIzmeniModnuKucu.Click += cmdIzmeniModnuKucu_Click;
            // 
            // cmdObrisiModnuKucu
            // 
            cmdObrisiModnuKucu.BackColor = SystemColors.GradientActiveCaption;
            cmdObrisiModnuKucu.Location = new Point(48, 81);
            cmdObrisiModnuKucu.Name = "cmdObrisiModnuKucu";
            cmdObrisiModnuKucu.Size = new Size(137, 34);
            cmdObrisiModnuKucu.TabIndex = 2;
            cmdObrisiModnuKucu.Text = "Obrisi Modnu Kucu";
            cmdObrisiModnuKucu.UseVisualStyleBackColor = false;
            cmdObrisiModnuKucu.Click += cmdObrisiModnuKucu_Click;
            // 
            // cmdDodajModnuKucu
            // 
            cmdDodajModnuKucu.BackColor = SystemColors.GradientActiveCaption;
            cmdDodajModnuKucu.Location = new Point(48, 22);
            cmdDodajModnuKucu.Name = "cmdDodajModnuKucu";
            cmdDodajModnuKucu.Size = new Size(137, 37);
            cmdDodajModnuKucu.TabIndex = 1;
            cmdDodajModnuKucu.Text = "Dodaj Modnu Kucu";
            cmdDodajModnuKucu.UseVisualStyleBackColor = false;
            cmdDodajModnuKucu.Click += cmdDodajModnuKucu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihKuca);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 257);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Modnih Kuca";
            // 
            // listaModnihKuca
            // 
            listaModnihKuca.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihKuca.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listaModnihKuca.Dock = DockStyle.Fill;
            listaModnihKuca.FullRowSelect = true;
            listaModnihKuca.GridLines = true;
            listaModnihKuca.Location = new Point(3, 19);
            listaModnihKuca.Name = "listaModnihKuca";
            listaModnihKuca.Size = new Size(490, 235);
            listaModnihKuca.TabIndex = 4;
            listaModnihKuca.UseCompatibleStateImageBehavior = false;
            listaModnihKuca.View = View.Details;
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
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(button2);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(56, 333);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(195, 92);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modni Kreatori";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(27, 22);
            button2.Name = "button2";
            button2.Size = new Size(149, 49);
            button2.TabIndex = 3;
            button2.Text = "Podaci o Modnim Kreatorima";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientInactiveCaption;
            groupBox4.Controls.Add(button1);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(547, 262);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(195, 92);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Imena Vlasnika";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(27, 22);
            button1.Name = "button1";
            button1.Size = new Size(149, 49);
            button1.TabIndex = 3;
            button1.Text = "Imena Vlasnika Modnih Kuca";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnImenaVlasnika_click;
            // 
            // ModneKuceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ModneKuceForm";
            Text = "ModneKuceForm";
            Load += ModneKuceForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button cmdIzmeniModnuKucu;
        private Button cmdObrisiModnuKucu;
        private Button cmdDodajModnuKucu;
        private GroupBox groupBox1;
        private ListView listaModnihKuca;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private GroupBox groupBox3;
        private Button button2;
        private GroupBox groupBox4;
        private Button button1;
    }
}