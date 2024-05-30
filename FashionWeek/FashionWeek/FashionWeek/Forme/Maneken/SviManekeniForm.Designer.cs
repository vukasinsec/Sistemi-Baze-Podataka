namespace FashionWeek.Forme
{
    partial class SviManekeniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SviManekeniForm));
            groupBox1 = new GroupBox();
            listaManekena = new ListView();
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
            cmdObrisiManekena = new Button();
            label1 = new Label();
            btnNastupaNaReviji = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(listaManekena);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(90, 34);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(766, 405);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Manekena";
            // 
            // listaManekena
            // 
            listaManekena.BackColor = SystemColors.GradientInactiveCaption;
            listaManekena.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listaManekena.Dock = DockStyle.Fill;
            listaManekena.FullRowSelect = true;
            listaManekena.GridLines = true;
            listaManekena.Location = new Point(3, 24);
            listaManekena.Margin = new Padding(3, 4, 3, 4);
            listaManekena.Name = "listaManekena";
            listaManekena.Size = new Size(760, 377);
            listaManekena.TabIndex = 4;
            listaManekena.UseCompatibleStateImageBehavior = false;
            listaManekena.View = View.Details;
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
            // cmdObrisiManekena
            // 
            cmdObrisiManekena.BackColor = SystemColors.GradientActiveCaption;
            cmdObrisiManekena.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdObrisiManekena.Location = new Point(103, 534);
            cmdObrisiManekena.Margin = new Padding(3, 4, 3, 4);
            cmdObrisiManekena.Name = "cmdObrisiManekena";
            cmdObrisiManekena.Size = new Size(158, 71);
            cmdObrisiManekena.TabIndex = 8;
            cmdObrisiManekena.Text = "Obrisi Manekena";
            cmdObrisiManekena.UseVisualStyleBackColor = false;
            cmdObrisiManekena.Click += cmdObrisiManekena_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 463);
            label1.Name = "label1";
            label1.Size = new Size(266, 64);
            label1.TabIndex = 9;
            label1.Text = "U tabeli su prikazani svi manekeni fashion week-a. Brisanjem manekena iz ove tabele bice trajno izbrisan iz sistema:";
            // 
            // btnNastupaNaReviji
            // 
            btnNastupaNaReviji.BackColor = SystemColors.GradientActiveCaption;
            btnNastupaNaReviji.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNastupaNaReviji.Location = new Point(649, 542);
            btnNastupaNaReviji.Margin = new Padding(3, 4, 3, 4);
            btnNastupaNaReviji.Name = "btnNastupaNaReviji";
            btnNastupaNaReviji.Size = new Size(181, 62);
            btnNastupaNaReviji.TabIndex = 10;
            btnNastupaNaReviji.Text = "Pregledaj Casopise";
            btnNastupaNaReviji.UseVisualStyleBackColor = false;
            btnNastupaNaReviji.Click += btnPregledajCasopise;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(619, 463);
            label2.Name = "label2";
            label2.Size = new Size(237, 64);
            label2.TabIndex = 11;
            label2.Text = "Selektovanjem manekena pregledajte njegove casopise:";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(346, 463);
            label3.Name = "label3";
            label3.Size = new Size(237, 64);
            label3.TabIndex = 12;
            label3.Text = "Selektovanjem manekena pregledajte na kojim revijama nastupa:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(385, 538);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(165, 71);
            button2.TabIndex = 13;
            button2.Text = "Maneken Nastupa Na Reviji";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SviManekeniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 696);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNastupaNaReviji);
            Controls.Add(label1);
            Controls.Add(cmdObrisiManekena);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SviManekeniForm";
            Text = "SviManekeniForm";
            Load += SviManekeniLoad;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaManekena;
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
        private Button cmdObrisiManekena;
        private Label label1;
        private Button btnNastupaNaReviji;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}