namespace FashionWeek.Forme
{
    partial class ModnaAgencijaDodajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModnaAgencijaDodajForm));
            button1 = new Button();
            labelaNaziv = new Label();
            labelaGrad = new Label();
            labelaDatumOdrzavanja = new Label();
            labelaVremeOdrzavanja = new Label();
            labelaImeJavneLicnosti = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(108, 353);
            button1.Name = "button1";
            button1.Size = new Size(176, 52);
            button1.TabIndex = 1;
            button1.Text = "Dodaj Modnu Agenciju";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelaNaziv
            // 
            labelaNaziv.AutoSize = true;
            labelaNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaNaziv.Location = new Point(31, 45);
            labelaNaziv.Name = "labelaNaziv";
            labelaNaziv.Size = new Size(27, 15);
            labelaNaziv.TabIndex = 0;
            labelaNaziv.Text = "PIB";
            // 
            // labelaGrad
            // 
            labelaGrad.AutoSize = true;
            labelaGrad.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaGrad.Location = new Point(31, 87);
            labelaGrad.Name = "labelaGrad";
            labelaGrad.Size = new Size(40, 15);
            labelaGrad.TabIndex = 1;
            labelaGrad.Text = "Naziv";
            // 
            // labelaDatumOdrzavanja
            // 
            labelaDatumOdrzavanja.AutoSize = true;
            labelaDatumOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaDatumOdrzavanja.Location = new Point(31, 124);
            labelaDatumOdrzavanja.Name = "labelaDatumOdrzavanja";
            labelaDatumOdrzavanja.Size = new Size(104, 15);
            labelaDatumOdrzavanja.TabIndex = 2;
            labelaDatumOdrzavanja.Text = "Datum Osnivanja";
            // 
            // labelaVremeOdrzavanja
            // 
            labelaVremeOdrzavanja.AutoSize = true;
            labelaVremeOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaVremeOdrzavanja.Location = new Point(31, 164);
            labelaVremeOdrzavanja.Name = "labelaVremeOdrzavanja";
            labelaVremeOdrzavanja.Size = new Size(47, 15);
            labelaVremeOdrzavanja.TabIndex = 3;
            labelaVremeOdrzavanja.Text = "Drzava";
            // 
            // labelaImeJavneLicnosti
            // 
            labelaImeJavneLicnosti.AutoSize = true;
            labelaImeJavneLicnosti.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaImeJavneLicnosti.Location = new Point(31, 202);
            labelaImeJavneLicnosti.Name = "labelaImeJavneLicnosti";
            labelaImeJavneLicnosti.Size = new Size(35, 15);
            labelaImeJavneLicnosti.TabIndex = 4;
            labelaImeJavneLicnosti.Text = "Grad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 202);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelaImeJavneLicnosti);
            groupBox1.Controls.Add(labelaVremeOdrzavanja);
            groupBox1.Controls.Add(labelaDatumOdrzavanja);
            groupBox1.Controls.Add(labelaGrad);
            groupBox1.Controls.Add(labelaNaziv);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 291);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni Podaci o Modnoj Agenciji";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            checkBox1.Location = new Point(31, 245);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Internacionalna";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkbox_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // ModnaAgencijaDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(417, 435);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "ModnaAgencijaDodajForm";
            Text = "ModnaAgencijaDodajForm";
            Load += ModnaAgencijaDodajForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label labelaNaziv;
        private Label labelaGrad;
        private Label labelaDatumOdrzavanja;
        private Label labelaVremeOdrzavanja;
        private Label labelaImeJavneLicnosti;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private CheckBox checkBox1;
    }
}