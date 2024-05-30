namespace FashionWeek.Forme
{
    partial class ModniKreatorOrganizatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModniKreatorOrganizatorForm));
            groupBox2 = new GroupBox();
            cmdDodajModnuReviju = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            listaModnihKreatoraOrganizatora = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(cmdDodajModnuReviju);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(72, 167);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(257, 101);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci O Modnim Kreatorima";
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
            // button1
            // 
            button1.Location = new Point(715, 333);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(9, 11);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaModnihKreatoraOrganizatora);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 47);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(542, 92);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modni Kreator";
            // 
            // listaModnihKreatoraOrganizatora
            // 
            listaModnihKreatoraOrganizatora.BackColor = SystemColors.GradientInactiveCaption;
            listaModnihKreatoraOrganizatora.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader11 });
            listaModnihKreatoraOrganizatora.Dock = DockStyle.Fill;
            listaModnihKreatoraOrganizatora.FullRowSelect = true;
            listaModnihKreatoraOrganizatora.GridLines = true;
            listaModnihKreatoraOrganizatora.Location = new Point(3, 25);
            listaModnihKreatoraOrganizatora.Margin = new Padding(3, 5, 3, 5);
            listaModnihKreatoraOrganizatora.Name = "listaModnihKreatoraOrganizatora";
            listaModnihKreatoraOrganizatora.Size = new Size(536, 62);
            listaModnihKreatoraOrganizatora.TabIndex = 4;
            listaModnihKreatoraOrganizatora.UseCompatibleStateImageBehavior = false;
            listaModnihKreatoraOrganizatora.View = View.Details;
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
            // ModniKreatorOrganizatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(606, 292);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModniKreatorOrganizatorForm";
            Text = "ModniKreatorOrganizatorForm";
            Load += ModniKreatorOrganizatorForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button cmdDodajModnuReviju;
        private Button button1;
        private GroupBox groupBox1;
        private ListView listaModnihKreatoraOrganizatora;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader11;
    }
}