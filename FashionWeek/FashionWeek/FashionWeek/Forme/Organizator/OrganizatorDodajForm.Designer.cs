namespace FashionWeek.Forme
{
    partial class OrganizatorDodajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizatorDodajForm));
            button1 = new Button();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            labelaGrad = new Label();
            labelaNaziv = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(129, 280);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(189, 53);
            button1.TabIndex = 3;
            button1.Text = "Dodaj Organizatora";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDodajOrganizatora;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelaGrad);
            groupBox1.Controls.Add(labelaNaziv);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 40);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(389, 184);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni Podaci o Organizatorima";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(254, 111);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(43, 24);
            checkBox2.TabIndex = 34;
            checkBox2.Text = "N";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(205, 111);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(40, 24);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Y";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 56);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 8;
            // 
            // labelaGrad
            // 
            labelaGrad.AutoSize = true;
            labelaGrad.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaGrad.Location = new Point(35, 116);
            labelaGrad.Name = "labelaGrad";
            labelaGrad.Size = new Size(142, 20);
            labelaGrad.TabIndex = 1;
            labelaGrad.Text = "Prva Modna Revija";
            // 
            // labelaNaziv
            // 
            labelaNaziv.AutoSize = true;
            labelaNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            labelaNaziv.Location = new Point(35, 60);
            labelaNaziv.Name = "labelaNaziv";
            labelaNaziv.Size = new Size(74, 20);
            labelaNaziv.TabIndex = 0;
            labelaNaziv.Text = "Kolekcija";
            // 
            // OrganizatorDodajForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(451, 368);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrganizatorDodajForm";
            Text = "OrganizatorDodajForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label labelaGrad;
        private Label labelaNaziv;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}