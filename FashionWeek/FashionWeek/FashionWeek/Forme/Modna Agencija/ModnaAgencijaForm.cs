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
    public partial class ModnaAgencijaForm : Form
    {
        public ModnaAgencijaForm()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {


            listaModnihAgencija.Items.Clear();
            List<ModnaAgencijaPregled> podaci = DTOManager.vratiModneAgencije();



            foreach (ModnaAgencijaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.PIB, p.Naziv, p.DatumOsnivanja.ToString(), p.Drzava, p.Grad, p.PInternacionalna.ToString() });
                listaModnihAgencija.Items.Add(item);

            }



            listaModnihAgencija.Refresh();
        }

        private void cmdDodajModnuKucu_Click(object sender, EventArgs e)
        {
            ModnaAgencijaDodajForm formaDodaj = new ModnaAgencijaDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void ModnaAgencija_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }



        

        private void btnPrikaziManekene_Click(object sender, EventArgs e)
        {

            if (listaModnihAgencija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite modnu agenciju cije manekene zelite da vidite!");
                return;
            }

            string pib = listaModnihAgencija.SelectedItems[0].SubItems[0].Text;
            ModnaAgencijaBasic o = DTOManager.vratiModnuAgenciju(pib);


            ManekeniForm forma = new ManekeniForm(o);
            forma.ShowDialog();


        }

        private void btnObrisiModnuAgenciju(object sender, EventArgs e)
        {
            if (listaModnihAgencija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Agenciju koju zelite da obrisete!");
                return;
            }

            string nazivAgencije = listaModnihAgencija.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranu modnu agenciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiModnuAgenciju(nazivAgencije);
                MessageBox.Show("Brisanje modne agencije je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void cmdIzmeniModnuAgenciju_Click(object sender, EventArgs e)
        {
            if (listaModnihAgencija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite modnu agenicju cije podatke zelite da izmenite!");
                return;
            }

            string nazivAgencije = listaModnihAgencija.SelectedItems[0].SubItems[0].Text;
            ModnaAgencijaBasic mr = DTOManager.vratiModnuAgenciju(nazivAgencije);

            ModnaAgencijaUpdateForm formaUpdate = new ModnaAgencijaUpdateForm(mr);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnNaziviZemalja_MsgBox_Click(object sender, EventArgs e)
        {
            if (listaModnihAgencija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Agenciju!");
                return;
            }

            string idAgencije = listaModnihAgencija.SelectedItems[0].SubItems[0].Text;

            if (Int32.Parse(listaModnihAgencija.SelectedItems[0].SubItems[5].Text) != 0)
            {

                List<NaziviZemaljaPregled> zemlje = DTOManager.vratiNaziveZemalja(idAgencije);

                if (zemlje.Count != 0)
                {

                    StringBuilder sb = new();
                    sb.AppendLine($"Modna agencija {listaModnihAgencija.SelectedItems[0].SubItems[1].Text} ima sledece zemlje:\n");

                    foreach (NaziviZemaljaPregled s in zemlje)
                    {
                        sb.AppendLine($"{s.Id.Zemlje}");
                    }

                    MessageBox.Show(sb.ToString());
                }
                else
                {
                    StringBuilder sb = new();
                    sb.AppendLine($"Modna agencija {listaModnihAgencija.SelectedItems[0].SubItems[1].Text} nema zemlje!");

                    MessageBox.Show(sb.ToString());
                }
            }
            else
            {
                StringBuilder sb = new();
                sb.AppendLine($"Modna agencija {listaModnihAgencija.SelectedItems[0].SubItems[1].Text} nije internacionalna!");

                MessageBox.Show(sb.ToString());
            }


            this.popuniPodacima();
        }
    }
}
