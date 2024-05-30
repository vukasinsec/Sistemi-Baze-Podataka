namespace FashionWeek.Forme
{
    partial class ModnaKucaDodajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModnaKucaDodajForm));
            button1 = new Button();
            groupBox1 = new GroupBox();
            checkBoxVlasnici = new CheckBox();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelaImeJavneLicnosti = new Label();
            labelaVremeOdrzavanja = new Label();
            labelaDatumOdrzavanja = new Label();
            labelaGrad = new Label();
            labelaNaziv = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(128, 365);
            button1.Name = "button1";
            button1.Size = new Size(165, 40);
            button1.TabIndex = 1;
            button1.Text = "Dodaj Modnu Kucu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(checkBoxVlasnici);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelaImeJavneLicnosti);
            groupBox1.Controls.Add(labelaVremeOdrzavanja);
            groupBox1.Controls.Add(labelaDatumOdrzavanja);
            groupBox1.Controls.Add(labelaGrad);
            groupBox1.Controls.Add(labelaNaziv);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(68, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 290);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni Podaci o Modnoj Kuci";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkBoxVlasnici
            // 
            checkBoxVlasnici.AutoSize = true;
            checkBoxVlasnici.Location = new Point(128, 248);
            checkBoxVlasnici.Name = "checkBoxVlasnici";
            checkBoxVlasnici.Size = new Size(107, 19);
            checkBoxVlasnici.TabIndex = 41;
            checkBoxVlasnici.Text = "Dodaj Vlasnike";
            checkBoxVlasnici.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 227);
            label2.Name = "label2";
            label2.Size = new Size(207, 51);
            label2.TabIndex = 40;
            label2.Text = "Cekirajte ako zelite da dodate vlasnike:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(94, 190);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(94, 157);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 13;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(154, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // labelaImeJavneLicnosti
            // 
            labelaImeJavneLicnosti.AutoSize = true;
            labelaImeJavneLicnosti.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaImeJavneLicnosti.Location = new Point(31, 195);
            labelaImeJavneLicnosti.Name = "labelaImeJavneLicnosti";
            labelaImeJavneLicnosti.Size = new Size(35, 15);
            labelaImeJavneLicnosti.TabIndex = 4;
            labelaImeJavneLicnosti.Text = "Grad";
            // 
            // labelaVremeOdrzavanja
            // 
            labelaVremeOdrzavanja.AutoSize = true;
            labelaVremeOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaVremeOdrzavanja.Location = new Point(31, 162);
            labelaVremeOdrzavanja.Name = "labelaVremeOdrzavanja";
            labelaVremeOdrzavanja.Size = new Size(47, 15);
            labelaVremeOdrzavanja.TabIndex = 3;
            labelaVremeOdrzavanja.Text = "Drzava";
            // 
            // labelaDatumOdrzavanja
            // 
            labelaDatumOdrzavanja.AutoSize = true;
            labelaDatumOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaDatumOdrzavanja.Location = new Point(31, 106);
            labelaDatumOdrzavanja.Name = "labelaDatumOdrzavanja";
            labelaDatumOdrzavanja.Size = new Size(107, 15);
            labelaDatumOdrzavanja.TabIndex = 2;
            labelaDatumOdrzavanja.Text = "Prezime Osnivaca";
            // 
            // labelaGrad
            // 
            labelaGrad.AutoSize = true;
            labelaGrad.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaGrad.Location = new Point(31, 80);
            labelaGrad.Name = "labelaGrad";
            labelaGrad.Size = new Size(82, 15);
            labelaGrad.TabIndex = 1;
            labelaGrad.Text = "Ime Osnivaca";
            // 
            // labelaNaziv
            // 
            labelaNaziv.AutoSize = true;
            labelaNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaNaziv.Location = new Point(60, 34);
            labelaNaziv.Name = "labelaNaziv";
            labelaNaziv.Size = new Size(40, 15);
            labelaNaziv.TabIndex = 0;
            labelaNaziv.Text = "Naziv";
            // 
            // ModnaKucaDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(429, 444);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "ModnaKucaDodajForm";
            Text = "ModnaKucaDodajForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelaImeJavneLicnosti;
        private Label labelaVremeOdrzavanja;
        private Label labelaDatumOdrzavanja;
        private Label labelaGrad;
        private Label labelaNaziv;
        private CheckBox checkBoxVlasnici;
        private Label label2;
    }
}