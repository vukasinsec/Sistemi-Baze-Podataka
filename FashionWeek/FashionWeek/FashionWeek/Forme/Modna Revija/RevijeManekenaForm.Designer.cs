namespace FashionWeek.Forme.Modna_Revija
{
    partial class RevijeManekenaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevijeManekenaForm));
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihRevija);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(43, 58);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(689, 437);
            groupBox1.TabIndex = 9;
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
            listaModnihRevija.Location = new Point(3, 24);
            listaModnihRevija.Margin = new Padding(3, 4, 3, 4);
            listaModnihRevija.Name = "listaModnihRevija";
            listaModnihRevija.Size = new Size(683, 409);
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
            // RevijeManekenaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(776, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RevijeManekenaForm";
            Text = "RevijeManekenaForm";
            Load += RevijeManekenaForm_Load;
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
    }
}