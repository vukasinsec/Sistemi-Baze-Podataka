namespace FashionWeek.Forme.Modna_Agencija
{
    partial class DodajZemljeZaModnuAgenciju
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
            Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajZemljeZaModnuAgenciju));
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Broadway", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(169, 234);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(136, 62);
            button1.TabIndex = 2;
            button1.Text = "Upisi Nazive Zemalja";
            button1.UseVisualStyleBackColor = false;
            button1.Click += brtUpisiZemlje;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GradientInactiveCaption;
            listBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.ForeColor = SystemColors.HotTrack;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Francuska", "Spanija", "Italija", "Nemacka", "Rusija", "Portugalija", "USA", "Engleska", "Bosna", "Hrvatska", "Crna Gora" });
            listBox1.Location = new Point(14, 16);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(149, 244);
            listBox1.TabIndex = 3;
            // 
            // DodajZemljeZaModnuAgenciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(317, 309);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DodajZemljeZaModnuAgenciju";
            Text = "DodajZemljeZaModnuAgenciju";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
    }
}