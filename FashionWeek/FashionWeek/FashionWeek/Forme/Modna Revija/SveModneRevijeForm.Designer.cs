namespace FashionWeek.Forme
{
    partial class SveModneRevijeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SveModneRevijeForm));
            groupBox1 = new GroupBox();
            listaModnihRevija = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihRevija);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 328);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Modnih Revija";
            // 
            // listaModnihRevija
            // 
            listaModnihRevija.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihRevija.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listaModnihRevija.Dock = DockStyle.Fill;
            listaModnihRevija.FullRowSelect = true;
            listaModnihRevija.GridLines = true;
            listaModnihRevija.Location = new Point(3, 19);
            listaModnihRevija.Name = "listaModnihRevija";
            listaModnihRevija.Size = new Size(597, 306);
            listaModnihRevija.TabIndex = 4;
            listaModnihRevija.UseCompatibleStateImageBehavior = false;
            listaModnihRevija.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
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
            // columnHeader7
            // 
            columnHeader7.Text = "Ime Javne Licnosti";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Prezime Javne Licnosti";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Zanimanje Javne Licnosti";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            button1.Location = new Point(25, 370);
            button1.Name = "button1";
            button1.Size = new Size(155, 57);
            button1.TabIndex = 9;
            button1.Text = "Maneken Nastupa Na Selektovanoj Modnoj Reviji";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            button2.Location = new Point(248, 370);
            button2.Name = "button2";
            button2.Size = new Size(155, 57);
            button2.TabIndex = 10;
            button2.Text = "Modni Kreatori Predstavljaju";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            button3.Location = new Point(468, 370);
            button3.Name = "button3";
            button3.Size = new Size(155, 57);
            button3.TabIndex = 11;
            button3.Text = "Specijalni Gosti Na Modnoj Reviji";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SveModneRevijeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(648, 456);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "SveModneRevijeForm";
            Text = "SveModneRevijeForm";
            Load += SveModneRevije_Load;
            groupBox1.ResumeLayout(false);
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
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}