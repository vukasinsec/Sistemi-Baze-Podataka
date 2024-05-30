namespace FashionWeek.Forme.Maneken
{
    partial class DodajCasopiseZaManekenaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajCasopiseZaManekenaForm));
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GradientInactiveCaption;
            listBox1.ForeColor = SystemColors.Highlight;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Model Mania", "Runway Royalty", "Glamour Gazette", "Vogue Vibes", "Catwalk Chronicles", "Fashion Finesse", "Style ", "Spotlight", "Model Muse", "Couture Chronicles", "Elite Elegance", "Chic Gazette", "Runway Reflections", "Glam Gazette", "Model Moments", "Haute Highlights", "Fashion Forward", "Model ", "Magic", "Trend Tales", "Pose Perfection", "Style Stories" });
            listBox1.Location = new Point(135, 30);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(240, 444);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Britannic Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(377, 416);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 58);
            button1.TabIndex = 4;
            button1.Text = "Upisi Casopise";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DodajCasopiseZaManekenaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(496, 497);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DodajCasopiseZaManekenaForm";
            Text = "DodajCasopiseZaManekenaForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
    }
}