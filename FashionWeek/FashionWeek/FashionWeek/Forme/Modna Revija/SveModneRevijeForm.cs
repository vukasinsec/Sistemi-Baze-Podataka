using FashionWeek.Entiteti;
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
    public partial class SveModneRevijeForm : Form
    {
        public SveModneRevijeForm()
        {
            InitializeComponent();
        }

        private void SveModneRevije_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {

            listaModnihRevija.Items.Clear();
            List<ModnaRevijaPregled> podaci = DTOManager.vratiSveModneRevije();



            foreach (ModnaRevijaPregled m in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { m.IdModneRevije.ToString(), m.RedniBroj.ToString(), m.Naziv, m.Grad, m.DatumOdrzavanja.ToString(), m.VremeOdrzavanja.ToString(), m.ImeJavneLicnosti, m.PrezimeJavneLicnosti, m.ZanimanjeJL });
                listaModnihRevija.Items.Add(item);

            }



            listaModnihRevija.Refresh();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaModnihRevija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Reviju!");
                return;
            }

            int idRevije = Int32.Parse(listaModnihRevija.SelectedItems[0].SubItems[0].Text);



            List<ManekenPregled> manekeni = DTOManager.manekeniKojiNastupaju(idRevije);


            ManekeniNastupajuForm forma = new ManekeniNastupajuForm(manekeni);

            forma.ShowDialog();


            this.popuniPodacima();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaModnihRevija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Reviju!");
                return;
            }

            int idRevije = Int32.Parse(listaModnihRevija.SelectedItems[0].SubItems[0].Text);



            List<ModniKreatorPregled> kreatori = DTOManager.kreatoriKojiPredstavljaju(idRevije);


            ModniKreatorPredstavljaForm forma = new ModniKreatorPredstavljaForm(kreatori);

            forma.ShowDialog();


            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaModnihRevija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Reviju!");
                return;
            }

            int idRevije = Int32.Parse(listaModnihRevija.SelectedItems[0].SubItems[0].Text);

            string imeRevije = listaModnihRevija.SelectedItems[0].SubItems[2].Text;

            List<ModniKreatorPregled> kreatori = DTOManager.specijalniGost(idRevije);

            if (kreatori.Count != 0)
            {

                StringBuilder sb = new();
                sb.AppendLine($"Modna revija {imeRevije} ima sledece specijalne goste:\n");

                foreach (ModniKreatorPregled s in kreatori)
                {
                    sb.AppendLine($"{s.Ime} {s.Prezime}");
                }

                MessageBox.Show(sb.ToString());
            }
            else
            {
                StringBuilder sb = new();
                sb.AppendLine($"Modna revija {imeRevije} nema specijalne goste!");

                MessageBox.Show(sb.ToString());
            }
            

            this.popuniPodacima();
        }
    }
}
