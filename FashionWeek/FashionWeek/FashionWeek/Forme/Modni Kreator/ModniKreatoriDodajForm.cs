using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FashionWeek.Forme
{
    public partial class ModniKreatoriDodajForm : Form
    {
        ModnaKucaBasic kuca;
        public ModniKreatoriDodajForm()
        {
            InitializeComponent();
        }
        public ModniKreatoriDodajForm(ModnaKucaBasic k)
        {
            InitializeComponent();
            kuca = k;
        }



        private void cmdDodajModnogKreatora_Click(object sender, EventArgs e)
        {

            ModniKreatorBasic kreator = new ModniKreatorBasic();

            kreator.MBR = textBox1.Text;
            kreator.ZemljaPorekla = textBox6.Text;
            kreator.Ime = textBox7.Text;
            kreator.Prezime = textBox8.Text;
            kreator.CenaUsluge =  (int)cenaUsluge.Value;

            if (checkBox1.Checked == true)
            {
                kreator.Pol = 'M';
            }
            else if (checkBox2.Checked == true)
            {
                kreator.Pol = 'Z';
            }
            else
            {
                MessageBox.Show("Cekirajte Pol.");
            }


            kreator.DatumRodjenja = dateTimePicker1.Value;

           

            kreator.NazivModneKuce = kuca;

            DTOManager.sacuvajKreatora(kreator);



            MessageBox.Show("Uspesno ste dodali modnog kreatora!");
            this.Close();


        }
    }
}
