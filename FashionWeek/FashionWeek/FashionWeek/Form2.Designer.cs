namespace FashionWeek
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            FashionWeek = new TextBox();
            btnOrganizatori = new Button();
            button1 = new Button();
            btnManekeni = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // FashionWeek
            // 
            FashionWeek.BackColor = SystemColors.ControlLight;
            FashionWeek.Cursor = Cursors.IBeam;
            FashionWeek.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FashionWeek.Location = new Point(185, 113);
            FashionWeek.Name = "FashionWeek";
            FashionWeek.Size = new Size(298, 42);
            FashionWeek.TabIndex = 0;
            FashionWeek.Text = "FASHION WEEK";
            FashionWeek.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOrganizatori
            // 
            btnOrganizatori.BackColor = SystemColors.ControlLight;
            btnOrganizatori.Font = new Font("Broadway", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrganizatori.Location = new Point(432, 778);
            btnOrganizatori.Name = "btnOrganizatori";
            btnOrganizatori.Size = new Size(227, 47);
            btnOrganizatori.TabIndex = 2;
            btnOrganizatori.Text = "ORGANIZATORI";
            btnOrganizatori.UseVisualStyleBackColor = false;
            btnOrganizatori.Click += btnOrganizatori_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Broadway", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(-3, 773);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 3;
            button1.Text = "MODNA AGENCIJE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnManekeni
            // 
            btnManekeni.BackColor = SystemColors.ControlLight;
            btnManekeni.Font = new Font("Broadway", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManekeni.Location = new Point(102, 606);
            btnManekeni.Name = "btnManekeni";
            btnManekeni.Size = new Size(201, 48);
            btnManekeni.TabIndex = 4;
            btnManekeni.Text = "MANEKENI";
            btnManekeni.UseVisualStyleBackColor = false;
            btnManekeni.Click += btnManekeni_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Broadway", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(353, 606);
            button2.Name = "button2";
            button2.Size = new Size(200, 48);
            button2.TabIndex = 5;
            button2.Text = "MODNE REVIJE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(658, 823);
            Controls.Add(button2);
            Controls.Add(btnManekeni);
            Controls.Add(button1);
            Controls.Add(btnOrganizatori);
            Controls.Add(FashionWeek);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Fashion Week";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FashionWeek;
        private Button btnOrganizatori;
        private Button button1;
        private Button btnManekeni;
        private Button button2;
    }
}