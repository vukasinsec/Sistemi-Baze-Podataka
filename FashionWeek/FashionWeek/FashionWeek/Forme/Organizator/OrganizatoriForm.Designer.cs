namespace FashionWeek.Forme
{
    partial class OrganizatoriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizatoriForm));
            groupBox3 = new GroupBox();
            listaOrganizatora = new ListView();
            columnHeader19 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            cmdModneRevije = new Button();
            cmdModneKuce = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listaOrganizatora);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(14, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(259, 344);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista Organizatora";
            // 
            // listaOrganizatora
            // 
            listaOrganizatora.BackColor = SystemColors.GradientInactiveCaption;
            listaOrganizatora.Columns.AddRange(new ColumnHeader[] { columnHeader19, columnHeader7, columnHeader11 });
            listaOrganizatora.Dock = DockStyle.Fill;
            listaOrganizatora.FullRowSelect = true;
            listaOrganizatora.GridLines = true;
            listaOrganizatora.Location = new Point(3, 24);
            listaOrganizatora.Margin = new Padding(3, 4, 3, 4);
            listaOrganizatora.Name = "listaOrganizatora";
            listaOrganizatora.Size = new Size(253, 316);
            listaOrganizatora.TabIndex = 4;
            listaOrganizatora.UseCompatibleStateImageBehavior = false;
            listaOrganizatora.View = View.Details;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Organizator ID";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kolekcija";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Prva Modna Revija";
            // 
            // cmdModneRevije
            // 
            cmdModneRevije.BackColor = SystemColors.GradientActiveCaption;
            cmdModneRevije.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            cmdModneRevije.Location = new Point(386, 105);
            cmdModneRevije.Margin = new Padding(3, 4, 3, 4);
            cmdModneRevije.Name = "cmdModneRevije";
            cmdModneRevije.Size = new Size(152, 44);
            cmdModneRevije.TabIndex = 8;
            cmdModneRevije.Text = "Modne Revije";
            cmdModneRevije.UseVisualStyleBackColor = false;
            cmdModneRevije.Click += cmdModneRevije_Click;
            // 
            // cmdModneKuce
            // 
            cmdModneKuce.BackColor = SystemColors.GradientActiveCaption;
            cmdModneKuce.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            cmdModneKuce.Location = new Point(386, 211);
            cmdModneKuce.Margin = new Padding(3, 4, 3, 4);
            cmdModneKuce.Name = "cmdModneKuce";
            cmdModneKuce.Size = new Size(152, 44);
            cmdModneKuce.TabIndex = 9;
            cmdModneKuce.Text = "Modne Kuce";
            cmdModneKuce.UseVisualStyleBackColor = false;
            cmdModneKuce.Click += cmdModneKuce_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(279, 55);
            label1.Name = "label1";
            label1.Size = new Size(382, 20);
            label1.TabIndex = 10;
            label1.Text = "Selektovanjem organizatora pregledajte modne revije:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(280, 169);
            label2.Name = "label2";
            label2.Size = new Size(376, 20);
            label2.TabIndex = 11;
            label2.Text = "Selektovanjem organizatora pregledajte modne kuce:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(277, 276);
            label3.Name = "label3";
            label3.Size = new Size(402, 20);
            label3.TabIndex = 13;
            label3.Text = "Selektovanjem organizatora pregledajte modne kreatore:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(383, 317);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(152, 44);
            button1.TabIndex = 12;
            button1.Text = "Modni Kreatori";
            button1.UseVisualStyleBackColor = false;
            button1.Click += modniKreatoriPregled;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(50, 378);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(190, 44);
            button2.TabIndex = 14;
            button2.Text = "Dodaj Organizatora";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnDodajOrganizatora;
            // 
            // OrganizatoriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(677, 499);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmdModneKuce);
            Controls.Add(cmdModneRevije);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrganizatoriForm";
            Text = "OrganizatoriForm";
            Load += OrganizatoriFormLoad;
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private ListView listaOrganizatora;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader11;
        private Button cmdModneRevije;
        private Button cmdModneKuce;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}