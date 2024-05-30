namespace FashionWeek.Forme
{
    partial class ManekenDodajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManekenDodajForm));
            cmdDodajManekena = new Button();
            groupBox1 = new GroupBox();
            checkBoxCasopisi = new CheckBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            numbericVisina = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label8 = new Label();
            textBox11 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox12 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label3 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            labelaImeJavneLicnosti = new Label();
            labelaVremeOdrzavanja = new Label();
            labelaDatumOdrzavanja = new Label();
            labelaGrad = new Label();
            labelaNaziv = new Label();
            tezinaNumeric = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numbericVisina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tezinaNumeric).BeginInit();
            SuspendLayout();
            // 
            // cmdDodajManekena
            // 
            cmdDodajManekena.BackColor = SystemColors.GradientActiveCaption;
            cmdDodajManekena.Font = new Font("Broadway", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdDodajManekena.Location = new Point(302, 343);
            cmdDodajManekena.Name = "cmdDodajManekena";
            cmdDodajManekena.Size = new Size(165, 40);
            cmdDodajManekena.TabIndex = 3;
            cmdDodajManekena.Text = "Dodaj Manekena";
            cmdDodajManekena.UseVisualStyleBackColor = false;
            cmdDodajManekena.Click += cmdDodajManekena_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(checkBoxCasopisi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(tezinaNumeric);
            groupBox1.Controls.Add(numbericVisina);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelaImeJavneLicnosti);
            groupBox1.Controls.Add(labelaVremeOdrzavanja);
            groupBox1.Controls.Add(labelaDatumOdrzavanja);
            groupBox1.Controls.Add(labelaGrad);
            groupBox1.Controls.Add(labelaNaziv);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(41, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 300);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni Podaci O Manekenima";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkBoxCasopisi
            // 
            checkBoxCasopisi.AutoSize = true;
            checkBoxCasopisi.Location = new Point(548, 250);
            checkBoxCasopisi.Name = "checkBoxCasopisi";
            checkBoxCasopisi.Size = new Size(108, 19);
            checkBoxCasopisi.TabIndex = 39;
            checkBoxCasopisi.Text = "Dodaj Casopise";
            checkBoxCasopisi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(357, 238);
            label2.Name = "label2";
            label2.Size = new Size(207, 35);
            label2.TabIndex = 38;
            label2.Text = "Cekirajte ako zelite da dodate casopise:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL" });
            comboBox1.Location = new Point(505, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 37;
            // 
            // numbericVisina
            // 
            numbericVisina.Location = new Point(464, 40);
            numbericVisina.Margin = new Padding(3, 4, 3, 4);
            numbericVisina.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numbericVisina.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            numbericVisina.Name = "numbericVisina";
            numbericVisina.Size = new Size(137, 23);
            numbericVisina.TabIndex = 34;
            numbericVisina.Value = new decimal(new int[] { 170, 0, 0, 0 });
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(144, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(139, 83);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(33, 19);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Z";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(96, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(37, 19);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "M";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(367, 45);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 29;
            label8.Text = "Visina";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(464, 113);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(367, 195);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 25;
            label4.Text = "Konfekcijski Broj";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(367, 156);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 24;
            label5.Text = "Tezina";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(367, 119);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 23;
            label6.Text = "BojaOciju";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(464, 77);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(367, 80);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 21;
            label7.Text = "Boja Kose";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(117, 250);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(31, 258);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 15;
            label3.Text = "Prezime";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(117, 212);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(144, 170);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 8;
            // 
            // labelaImeJavneLicnosti
            // 
            labelaImeJavneLicnosti.AutoSize = true;
            labelaImeJavneLicnosti.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaImeJavneLicnosti.Location = new Point(31, 215);
            labelaImeJavneLicnosti.Name = "labelaImeJavneLicnosti";
            labelaImeJavneLicnosti.Size = new Size(28, 15);
            labelaImeJavneLicnosti.TabIndex = 4;
            labelaImeJavneLicnosti.Text = "Ime";
            // 
            // labelaVremeOdrzavanja
            // 
            labelaVremeOdrzavanja.AutoSize = true;
            labelaVremeOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaVremeOdrzavanja.Location = new Point(31, 175);
            labelaVremeOdrzavanja.Name = "labelaVremeOdrzavanja";
            labelaVremeOdrzavanja.Size = new Size(92, 15);
            labelaVremeOdrzavanja.TabIndex = 3;
            labelaVremeOdrzavanja.Text = "Zemlja Porekla";
            // 
            // labelaDatumOdrzavanja
            // 
            labelaDatumOdrzavanja.AutoSize = true;
            labelaDatumOdrzavanja.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaDatumOdrzavanja.Location = new Point(31, 134);
            labelaDatumOdrzavanja.Name = "labelaDatumOdrzavanja";
            labelaDatumOdrzavanja.Size = new Size(97, 15);
            labelaDatumOdrzavanja.TabIndex = 2;
            labelaDatumOdrzavanja.Text = "Datum Rodjenja";
            // 
            // labelaGrad
            // 
            labelaGrad.AutoSize = true;
            labelaGrad.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaGrad.Location = new Point(31, 83);
            labelaGrad.Name = "labelaGrad";
            labelaGrad.Size = new Size(26, 15);
            labelaGrad.TabIndex = 1;
            labelaGrad.Text = "Pol";
            // 
            // labelaNaziv
            // 
            labelaNaziv.AutoSize = true;
            labelaNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaNaziv.Location = new Point(31, 45);
            labelaNaziv.Name = "labelaNaziv";
            labelaNaziv.Size = new Size(33, 15);
            labelaNaziv.TabIndex = 0;
            labelaNaziv.Text = "MBR";
            // 
            // tezinaNumeric
            // 
            tezinaNumeric.DecimalPlaces = 1;
            tezinaNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tezinaNumeric.Location = new Point(453, 154);
            tezinaNumeric.Margin = new Padding(3, 4, 3, 4);
            tezinaNumeric.Name = "tezinaNumeric";
            tezinaNumeric.Size = new Size(137, 23);
            tezinaNumeric.TabIndex = 35;
            // 
            // ManekenDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(787, 437);
            Controls.Add(cmdDodajManekena);
            Controls.Add(groupBox1);
            Name = "ManekenDodajForm";
            Text = "ManekenDodajForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numbericVisina).EndInit();
            ((System.ComponentModel.ISupportInitialize)tezinaNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cmdDodajManekena;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label labelaImeJavneLicnosti;
        private Label labelaVremeOdrzavanja;
        private Label labelaDatumOdrzavanja;
        private Label labelaGrad;
        private Label labelaNaziv;
        private TextBox textBox8;
        private Label label3;
        private Label label8;
        private TextBox textBox11;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox12;
        private Label label7;
        private NumericUpDown numbericVisina;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private CheckBox checkBoxCasopisi;
        private Label label2;
        private NumericUpDown tezinaNumeric;
    }
}