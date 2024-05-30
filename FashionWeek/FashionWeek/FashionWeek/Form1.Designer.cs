namespace FashionWeek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdModnaAgencija = new Button();
            cmdDodajModnuAgenciju = new Button();
            cmdDodajManekena = new Button();
            cmdOneToManyMA = new Button();
            cmdManyToOneMA = new Button();
            cmdUcitajModnuKucu = new Button();
            cmdDodajModnuKucu = new Button();
            cmdDodajModnogKreatora = new Button();
            cmdUcitajManekena = new Button();
            cmdManekenNastupa = new Button();
            cmdKucaKreator = new Button();
            cmdSpecijalniGostVeza = new Button();
            cmdModniKreatorPredstavlja = new Button();
            cmdManekenCasopisi = new Button();
            cmdKucaVlasnici = new Button();
            cmdCasopisManeken = new Button();
            orgRevija = new Button();
            cmdRevOrganizator = new Button();
            cmdDodajReviju = new Button();
            cmdProba1 = new Button();
            cmdProba2 = new Button();
            cmdProba3 = new Button();
            cmdProba4 = new Button();
            cmdGrupisi = new Button();
            cmdProba5 = new Button();
            cmdObrisi = new Button();
            cmdUcitajReviju = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmdModnaAgencija
            // 
            cmdModnaAgencija.Location = new Point(27, 24);
            cmdModnaAgencija.Name = "cmdModnaAgencija";
            cmdModnaAgencija.Size = new Size(143, 48);
            cmdModnaAgencija.TabIndex = 0;
            cmdModnaAgencija.Text = "Ucitaj Modnu Agenciju";
            cmdModnaAgencija.UseVisualStyleBackColor = true;
            cmdModnaAgencija.Click += cmdModnaAgencija_Click;
            // 
            // cmdDodajModnuAgenciju
            // 
            cmdDodajModnuAgenciju.Location = new Point(27, 78);
            cmdDodajModnuAgenciju.Name = "cmdDodajModnuAgenciju";
            cmdDodajModnuAgenciju.Size = new Size(143, 48);
            cmdDodajModnuAgenciju.TabIndex = 1;
            cmdDodajModnuAgenciju.Text = "Dodaj Modnu Agenciju";
            cmdDodajModnuAgenciju.UseVisualStyleBackColor = true;
            cmdDodajModnuAgenciju.Click += cmdDodajModnuAgenciju_Click;
            // 
            // cmdDodajManekena
            // 
            cmdDodajManekena.Location = new Point(27, 132);
            cmdDodajManekena.Name = "cmdDodajManekena";
            cmdDodajManekena.Size = new Size(143, 27);
            cmdDodajManekena.TabIndex = 2;
            cmdDodajManekena.Text = "Dodaj Manekena";
            cmdDodajManekena.UseVisualStyleBackColor = true;
            cmdDodajManekena.Click += cmdDodajManekena_Click;
            // 
            // cmdOneToManyMA
            // 
            cmdOneToManyMA.Location = new Point(27, 177);
            cmdOneToManyMA.Name = "cmdOneToManyMA";
            cmdOneToManyMA.Size = new Size(143, 48);
            cmdOneToManyMA.TabIndex = 3;
            cmdOneToManyMA.Text = "OneToMany-AgencijaManeken";
            cmdOneToManyMA.UseVisualStyleBackColor = true;
            cmdOneToManyMA.Click += cmdOneToManyMA_Click;
            // 
            // cmdManyToOneMA
            // 
            cmdManyToOneMA.Location = new Point(27, 238);
            cmdManyToOneMA.Name = "cmdManyToOneMA";
            cmdManyToOneMA.Size = new Size(143, 48);
            cmdManyToOneMA.TabIndex = 4;
            cmdManyToOneMA.Text = "ManyToOne-AgencijaManeken";
            cmdManyToOneMA.UseVisualStyleBackColor = true;
            cmdManyToOneMA.Click += cmdManyToOneMA_Click;
            // 
            // cmdUcitajModnuKucu
            // 
            cmdUcitajModnuKucu.Location = new Point(27, 302);
            cmdUcitajModnuKucu.Name = "cmdUcitajModnuKucu";
            cmdUcitajModnuKucu.Size = new Size(143, 48);
            cmdUcitajModnuKucu.TabIndex = 5;
            cmdUcitajModnuKucu.Text = "Ucitaj Modnu Kucu";
            cmdUcitajModnuKucu.UseVisualStyleBackColor = true;
            cmdUcitajModnuKucu.Click += cmdUcitajModnuKucu_Click;
            // 
            // cmdDodajModnuKucu
            // 
            cmdDodajModnuKucu.Location = new Point(27, 356);
            cmdDodajModnuKucu.Name = "cmdDodajModnuKucu";
            cmdDodajModnuKucu.Size = new Size(143, 48);
            cmdDodajModnuKucu.TabIndex = 6;
            cmdDodajModnuKucu.Text = "Dodaj Modnu Kucu";
            cmdDodajModnuKucu.UseVisualStyleBackColor = true;
            cmdDodajModnuKucu.Click += cmdDodajModnuKucu_Click;
            // 
            // cmdDodajModnogKreatora
            // 
            cmdDodajModnogKreatora.Location = new Point(27, 410);
            cmdDodajModnogKreatora.Name = "cmdDodajModnogKreatora";
            cmdDodajModnogKreatora.Size = new Size(143, 42);
            cmdDodajModnogKreatora.TabIndex = 7;
            cmdDodajModnogKreatora.Text = "Dodaj Modnog Kreatora";
            cmdDodajModnogKreatora.UseVisualStyleBackColor = true;
            cmdDodajModnogKreatora.Click += cmdDodajModnogKreatora_Click;
            // 
            // cmdUcitajManekena
            // 
            cmdUcitajManekena.Location = new Point(175, 24);
            cmdUcitajManekena.Name = "cmdUcitajManekena";
            cmdUcitajManekena.Size = new Size(139, 30);
            cmdUcitajManekena.TabIndex = 8;
            cmdUcitajManekena.Text = "Ucitaj Manekena";
            cmdUcitajManekena.UseVisualStyleBackColor = true;
            cmdUcitajManekena.Click += cmdUcitajManekena_Click;
            // 
            // cmdManekenNastupa
            // 
            cmdManekenNastupa.Location = new Point(175, 60);
            cmdManekenNastupa.Name = "cmdManekenNastupa";
            cmdManekenNastupa.Size = new Size(139, 30);
            cmdManekenNastupa.TabIndex = 9;
            cmdManekenNastupa.Text = "ManekenNastupa";
            cmdManekenNastupa.UseVisualStyleBackColor = true;
            cmdManekenNastupa.Click += cmdManekenNastupa_Click;
            // 
            // cmdKucaKreator
            // 
            cmdKucaKreator.Location = new Point(175, 96);
            cmdKucaKreator.Name = "cmdKucaKreator";
            cmdKucaKreator.Size = new Size(139, 30);
            cmdKucaKreator.TabIndex = 10;
            cmdKucaKreator.Text = "ModnaKucaModniKreator";
            cmdKucaKreator.UseVisualStyleBackColor = true;
            cmdKucaKreator.Click += cmdKucaKreator_Click;
            // 
            // cmdSpecijalniGostVeza
            // 
            cmdSpecijalniGostVeza.Location = new Point(175, 140);
            cmdSpecijalniGostVeza.Name = "cmdSpecijalniGostVeza";
            cmdSpecijalniGostVeza.Size = new Size(139, 30);
            cmdSpecijalniGostVeza.TabIndex = 11;
            cmdSpecijalniGostVeza.Text = "SpecijalniGostVeza";
            cmdSpecijalniGostVeza.UseVisualStyleBackColor = true;
            cmdSpecijalniGostVeza.Click += cmdSpecijalniGostVeza_Click;
            // 
            // cmdModniKreatorPredstavlja
            // 
            cmdModniKreatorPredstavlja.Location = new Point(175, 186);
            cmdModniKreatorPredstavlja.Name = "cmdModniKreatorPredstavlja";
            cmdModniKreatorPredstavlja.Size = new Size(139, 30);
            cmdModniKreatorPredstavlja.TabIndex = 12;
            cmdModniKreatorPredstavlja.Text = "ModniKreatorPredstavlja";
            cmdModniKreatorPredstavlja.UseVisualStyleBackColor = true;
            cmdModniKreatorPredstavlja.Click += cmdModniKreatorPredstavlja_Click;
            // 
            // cmdManekenCasopisi
            // 
            cmdManekenCasopisi.Location = new Point(175, 222);
            cmdManekenCasopisi.Name = "cmdManekenCasopisi";
            cmdManekenCasopisi.Size = new Size(143, 31);
            cmdManekenCasopisi.TabIndex = 13;
            cmdManekenCasopisi.Text = "ManekenCasopisi";
            cmdManekenCasopisi.UseVisualStyleBackColor = true;
            cmdManekenCasopisi.Click += cmdManekenCasopisi_Click;
            // 
            // cmdKucaVlasnici
            // 
            cmdKucaVlasnici.Location = new Point(183, 291);
            cmdKucaVlasnici.Name = "cmdKucaVlasnici";
            cmdKucaVlasnici.Size = new Size(143, 31);
            cmdKucaVlasnici.TabIndex = 14;
            cmdKucaVlasnici.Text = "KucaVlasnici";
            cmdKucaVlasnici.UseVisualStyleBackColor = true;
            cmdKucaVlasnici.Click += cmdKucaVlasnici_Click;
            // 
            // cmdCasopisManeken
            // 
            cmdCasopisManeken.Location = new Point(183, 255);
            cmdCasopisManeken.Name = "cmdCasopisManeken";
            cmdCasopisManeken.Size = new Size(143, 31);
            cmdCasopisManeken.TabIndex = 15;
            cmdCasopisManeken.Text = "CasopisManeken";
            cmdCasopisManeken.UseVisualStyleBackColor = true;
            cmdCasopisManeken.Click += cmdCasopisManeken_Click;
            // 
            // orgRevija
            // 
            orgRevija.Location = new Point(183, 328);
            orgRevija.Name = "orgRevija";
            orgRevija.Size = new Size(143, 48);
            orgRevija.TabIndex = 16;
            orgRevija.Text = "OneToMany-OrgRevija";
            orgRevija.UseVisualStyleBackColor = true;
            orgRevija.Click += orgRevija_Click;
            // 
            // cmdRevOrganizator
            // 
            cmdRevOrganizator.Location = new Point(319, 24);
            cmdRevOrganizator.Name = "cmdRevOrganizator";
            cmdRevOrganizator.Size = new Size(143, 38);
            cmdRevOrganizator.TabIndex = 17;
            cmdRevOrganizator.Text = "ManyToOne-orgRevije";
            cmdRevOrganizator.UseVisualStyleBackColor = true;
            cmdRevOrganizator.Click += cmdRevOrganizator_Click;
            // 
            // cmdDodajReviju
            // 
            cmdDodajReviju.Location = new Point(319, 78);
            cmdDodajReviju.Name = "cmdDodajReviju";
            cmdDodajReviju.Size = new Size(143, 27);
            cmdDodajReviju.TabIndex = 18;
            cmdDodajReviju.Text = "Dodaj reviju";
            cmdDodajReviju.UseVisualStyleBackColor = true;
            cmdDodajReviju.Click += cmdDodajReviju_Click;
            // 
            // cmdProba1
            // 
            cmdProba1.Location = new Point(319, 111);
            cmdProba1.Name = "cmdProba1";
            cmdProba1.Size = new Size(143, 27);
            cmdProba1.TabIndex = 19;
            cmdProba1.Text = "Proba1";
            cmdProba1.UseVisualStyleBackColor = true;
            cmdProba1.Click += cmdProba1_Click;
            // 
            // cmdProba2
            // 
            cmdProba2.Location = new Point(319, 144);
            cmdProba2.Name = "cmdProba2";
            cmdProba2.Size = new Size(143, 27);
            cmdProba2.TabIndex = 20;
            cmdProba2.Text = "Proba2";
            cmdProba2.UseVisualStyleBackColor = true;
            cmdProba2.Click += cmdProba2_Click;
            // 
            // cmdProba3
            // 
            cmdProba3.Location = new Point(319, 177);
            cmdProba3.Name = "cmdProba3";
            cmdProba3.Size = new Size(143, 27);
            cmdProba3.TabIndex = 21;
            cmdProba3.Text = "Proba3";
            cmdProba3.UseVisualStyleBackColor = true;
            cmdProba3.Click += cmdProba3_Click;
            // 
            // cmdProba4
            // 
            cmdProba4.Location = new Point(319, 210);
            cmdProba4.Name = "cmdProba4";
            cmdProba4.Size = new Size(143, 27);
            cmdProba4.TabIndex = 22;
            cmdProba4.Text = "Proba4";
            cmdProba4.UseVisualStyleBackColor = true;
            cmdProba4.Click += cmdProba4_Click;
            // 
            // cmdGrupisi
            // 
            cmdGrupisi.Location = new Point(319, 243);
            cmdGrupisi.Name = "cmdGrupisi";
            cmdGrupisi.Size = new Size(143, 27);
            cmdGrupisi.TabIndex = 23;
            cmdGrupisi.Text = "Grupisi";
            cmdGrupisi.UseVisualStyleBackColor = true;
            cmdGrupisi.Click += cmdGrupisi_Click;
            // 
            // cmdProba5
            // 
            cmdProba5.Location = new Point(319, 276);
            cmdProba5.Name = "cmdProba5";
            cmdProba5.Size = new Size(143, 27);
            cmdProba5.TabIndex = 24;
            cmdProba5.Text = "Proba5";
            cmdProba5.UseVisualStyleBackColor = true;
            cmdProba5.Click += cmdProba5_Click;
            // 
            // cmdObrisi
            // 
            cmdObrisi.Location = new Point(331, 312);
            cmdObrisi.Name = "cmdObrisi";
            cmdObrisi.Size = new Size(143, 27);
            cmdObrisi.TabIndex = 25;
            cmdObrisi.Text = "Obrisi";
            cmdObrisi.UseVisualStyleBackColor = true;
            cmdObrisi.Click += cmdObrisi_Click;
            // 
            // cmdUcitajReviju
            // 
            cmdUcitajReviju.Location = new Point(346, 345);
            cmdUcitajReviju.Name = "cmdUcitajReviju";
            cmdUcitajReviju.Size = new Size(143, 27);
            cmdUcitajReviju.TabIndex = 26;
            cmdUcitajReviju.Text = "UcitajReviju";
            cmdUcitajReviju.UseVisualStyleBackColor = true;
            cmdUcitajReviju.Click += cmdUcitajReviju_Click;
            // 
            // button1
            // 
            button1.Location = new Point(581, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(cmdUcitajReviju);
            Controls.Add(cmdObrisi);
            Controls.Add(cmdProba5);
            Controls.Add(cmdGrupisi);
            Controls.Add(cmdProba4);
            Controls.Add(cmdProba3);
            Controls.Add(cmdProba2);
            Controls.Add(cmdProba1);
            Controls.Add(cmdDodajReviju);
            Controls.Add(cmdRevOrganizator);
            Controls.Add(orgRevija);
            Controls.Add(cmdCasopisManeken);
            Controls.Add(cmdKucaVlasnici);
            Controls.Add(cmdManekenCasopisi);
            Controls.Add(cmdModniKreatorPredstavlja);
            Controls.Add(cmdSpecijalniGostVeza);
            Controls.Add(cmdKucaKreator);
            Controls.Add(cmdManekenNastupa);
            Controls.Add(cmdUcitajManekena);
            Controls.Add(cmdDodajModnogKreatora);
            Controls.Add(cmdDodajModnuKucu);
            Controls.Add(cmdUcitajModnuKucu);
            Controls.Add(cmdManyToOneMA);
            Controls.Add(cmdOneToManyMA);
            Controls.Add(cmdDodajManekena);
            Controls.Add(cmdDodajModnuAgenciju);
            Controls.Add(cmdModnaAgencija);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdModnaAgencija;
        private Button cmdDodajModnuAgenciju;
        private Button cmdDodajManekena;
        private Button cmdOneToManyMA;
        private Button cmdManyToOneMA;
        private Button cmdUcitajModnuKucu;
        private Button cmdDodajModnuKucu;
        private Button cmdDodajModnogKreatora;
        private Button cmdUcitajManekena;
        private Button cmdManekenNastupa;
        private Button cmdKucaKreator;
        private Button cmdSpecijalniGostVeza;
        private Button cmdModniKreatorPredstavlja;
        private Button cmdManekenCasopisi;
        private Button cmdKucaVlasnici;
        private Button cmdCasopisManeken;
        private Button orgRevija;
        private Button cmdRevOrganizator;
        private Button cmdDodajReviju;
        private Button cmdProba1;
        private Button cmdProba2;
        private Button cmdProba3;
        private Button cmdProba4;
        private Button cmdGrupisi;
        private Button cmdProba5;
        private Button cmdObrisi;
        private Button cmdUcitajReviju;
        private Button button1;
    }
}
