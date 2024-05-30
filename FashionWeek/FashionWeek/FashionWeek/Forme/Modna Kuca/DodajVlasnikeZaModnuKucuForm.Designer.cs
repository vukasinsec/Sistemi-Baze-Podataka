namespace FashionWeek.Forme.Modna_Kuca
{
    partial class DodajVlasnikeZaModnuKucuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajVlasnikeZaModnuKucuForm));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Broadway", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(254, 321);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(116, 58);
            button1.TabIndex = 4;
            button1.Text = "Upisi Vlasnike";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 219);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 5;
            label1.Text = "Vlasnici";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 219);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 29);
            textBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GradientInactiveCaption;
            listBox1.ForeColor = SystemColors.Highlight;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(96, 51);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 104);
            listBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(277, 218);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 8;
            button2.Text = "Dodaj";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DodajVlasnikeZaModnuKucuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(382, 392);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DodajVlasnikeZaModnuKucuForm";
            Text = "DodajVlasnikeZaModnuKucuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button2;
    }
}