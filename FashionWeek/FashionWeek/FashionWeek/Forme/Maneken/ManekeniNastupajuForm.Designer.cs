namespace FashionWeek.Forme
{
    partial class ManekeniNastupajuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManekeniNastupajuForm));
            groupBox1 = new GroupBox();
            listaManekenaNastupaju = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaManekenaNastupaju);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(862, 405);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Manekena";
            // 
            // listaManekenaNastupaju
            // 
            listaManekenaNastupaju.BackColor = SystemColors.GradientInactiveCaption;
            listaManekenaNastupaju.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listaManekenaNastupaju.Dock = DockStyle.Fill;
            listaManekenaNastupaju.FullRowSelect = true;
            listaManekenaNastupaju.GridLines = true;
            listaManekenaNastupaju.Location = new Point(3, 20);
            listaManekenaNastupaju.Margin = new Padding(3, 4, 3, 4);
            listaManekenaNastupaju.Name = "listaManekenaNastupaju";
            listaManekenaNastupaju.Size = new Size(856, 381);
            listaManekenaNastupaju.TabIndex = 4;
            listaManekenaNastupaju.UseCompatibleStateImageBehavior = false;
            listaManekenaNastupaju.View = View.Details;
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
            // columnHeader7
            // 
            columnHeader7.Text = "BojaKose";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Visina";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "BojaOciju";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Tezina";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "KonfekcijskiBroj";
            // 
            // ManekeniNastupajuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(929, 500);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManekeniNastupajuForm";
            Text = "ManekeniNastupajuForm";
            Load += ManekniNastupajuForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaManekenaNastupaju;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}