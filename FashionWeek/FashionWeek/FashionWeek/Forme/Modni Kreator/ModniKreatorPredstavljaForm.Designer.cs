namespace FashionWeek.Forme
{
    partial class ModniKreatorPredstavljaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModniKreatorPredstavljaForm));
            groupBox1 = new GroupBox();
            listaModnihKreatoraPredstavljaju = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihKreatoraPredstavljaju);
            groupBox1.Location = new Point(86, 85);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(583, 405);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Modnih Kreatora";
            // 
            // listaModnihKreatoraPredstavljaju
            // 
            listaModnihKreatoraPredstavljaju.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihKreatoraPredstavljaju.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader11 });
            listaModnihKreatoraPredstavljaju.Dock = DockStyle.Fill;
            listaModnihKreatoraPredstavljaju.FullRowSelect = true;
            listaModnihKreatoraPredstavljaju.GridLines = true;
            listaModnihKreatoraPredstavljaju.Location = new Point(3, 24);
            listaModnihKreatoraPredstavljaju.Margin = new Padding(3, 4, 3, 4);
            listaModnihKreatoraPredstavljaju.Name = "listaModnihKreatoraPredstavljaju";
            listaModnihKreatoraPredstavljaju.Size = new Size(577, 377);
            listaModnihKreatoraPredstavljaju.TabIndex = 4;
            listaModnihKreatoraPredstavljaju.UseCompatibleStateImageBehavior = false;
            listaModnihKreatoraPredstavljaju.View = View.Details;
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
            // ModniKreatorPredstavljaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(722, 615);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModniKreatorPredstavljaForm";
            Text = "ModniKreatorPredstavljaForm";
            Load += ModniKreatorPredstavljaForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaModnihKreatoraPredstavljaju;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader11;
    }
}