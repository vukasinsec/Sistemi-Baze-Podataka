using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forme
{
    public partial class ModniKreatoriOrganizatoriDodajForm : Form
    {
        OrganizatorBasic organizator;
        public ModniKreatoriOrganizatoriDodajForm()
        {
            InitializeComponent();
        }

        public ModniKreatoriOrganizatoriDodajForm(OrganizatorBasic organizator)
        {
            InitializeComponent();
            this.organizator = organizator;
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            checkBox1.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox changedCheckBox = sender as CheckBox;

            if (changedCheckBox == checkBox1 && checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else if (changedCheckBox == checkBox2 && checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void ModniKreatoriOrganizatoriDodajForm_Load(object sender, EventArgs e)
        {
            popuniModneKuce();
        }

        public void popuniModneKuce()
        {

            listaModnihKucaIzKreatora.Items.Clear();
            List<ModnaKucaPregled> podaci = DTOManager.vratiSveModneKuce();



            foreach (ModnaKucaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.ImeOsnivaca, p.PrezimeOsnivaca, p.Drzava, p.Grad });
                listaModnihKucaIzKreatora.Items.Add(item);

            }



            listaModnihKucaIzKreatora.Refresh();

        }

        private void cmdDodajModnogKreatora_Click(object sender, EventArgs e)
        {
            ModniKreatorBasic kreator = new ModniKreatorBasic();

            kreator.MBR = textBox1.Text;
            kreator.ZemljaPorekla = textBox6.Text;
            kreator.Ime = textBox7.Text;
            kreator.Prezime = textBox8.Text;
            kreator.CenaUsluge = (int)cenaUsluge.Value;

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

            if (listaModnihKucaIzKreatora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Kucu u kojoj radi modni kreator!");
                return;
            }

            string nazivKuce = listaModnihKucaIzKreatora.SelectedItems[0].SubItems[0].Text;
            ModnaKucaBasic o = DTOManager.vratiKucu(nazivKuce);


            kreator.NazivModneKuce = o;
            kreator.OrganizatorID = organizator;

            DTOManager.sacuvajKreatora(kreator);



            MessageBox.Show("Uspesno ste dodali modnog kreatora!");
            this.Close();
        }
    }
}
