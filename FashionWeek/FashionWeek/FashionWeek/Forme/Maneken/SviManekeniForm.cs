using FashionWeek.Forme.Modna_Revija;
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
    public partial class SviManekeniForm : Form
    {
        public SviManekeniForm()
        {
            InitializeComponent();
        }

        private void SviManekeniLoad(object sender, EventArgs e)
        {
            popuniManekene();
        }

        public void popuniManekene()
        {

            listaManekena.Items.Clear();
            List<ManekenPregled> podaci = DTOManager.vratiSveManekene();



            foreach (ManekenPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.MBR, p.Pol.ToString(), p.DatumRodjenja.ToString(), p.ZemljaPorekla, p.Ime, p.Prezime, p.BojaKose, p.Visina.ToString(), p.BojaOciju, p.Tezina.ToString(), p.KonfekcijskiBroj });
                listaManekena.Items.Add(item);

            }



            listaManekena.Refresh();
        }

        private void cmdObrisiManekena_Click(object sender, EventArgs e)
        {
            if (listaManekena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite manekena kog zelite da obrisete!");
                return;
            }

            string mbr = listaManekena.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog manekena?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiManekena(mbr);
                MessageBox.Show("Brisanje manekena je uspesno obavljeno!");
                this.popuniManekene();
            }
            else
            {

            }


        }

        private void btnPregledajCasopise(object sender, EventArgs e)
        {

            if (listaManekena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Manekena!");
                return;
            }

            string mbrManekena = listaManekena.SelectedItems[0].SubItems[0].Text;

            List<CasopisiPregled> casopisi = DTOManager.vratiCasopise(mbrManekena);

            StringBuilder sb = new StringBuilder();

            if (casopisi.Count != 0)
            {
                sb.AppendLine($"Maneken {listaManekena.SelectedItems[0].SubItems[4].Text} ima sledece casopise:\n");

                foreach (CasopisiPregled s in casopisi)
                {
                    sb.AppendLine($"- {s.Id.NaziviCasopisa}");
                }
            }
            else
            {
                sb.AppendLine($"Maneken {listaManekena.SelectedItems[0].SubItems[4].Text} nema casopise!");
            }

            MessageBox.Show(sb.ToString(), "Informacije o Casopisima", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.popuniManekene();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaManekena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Manekena da bi pogledali na kojoj reviji nastupa!");
                return;
            }

            string mbr = listaManekena.SelectedItems[0].SubItems[0].Text;



            List<ModnaRevijaPregled> manekeni = DTOManager.revijeNaKojimaNastupaManeken(mbr);


            RevijeManekenaForm forma = new RevijeManekenaForm(manekeni);

            forma.ShowDialog();


            this.popuniManekene();

        }
    }
}
