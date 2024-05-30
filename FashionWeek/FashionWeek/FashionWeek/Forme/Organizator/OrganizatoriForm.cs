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
    public partial class OrganizatoriForm : Form
    {
        public OrganizatoriForm()
        {
            InitializeComponent();
        }

        private void OrganizatoriFormLoad(object sender, EventArgs e)
        {
            popuniOrganizatore();
        }

        public void popuniOrganizatore()
        {
            listaOrganizatora.Items.Clear();
            List<OrganizatorPregled> podaci = DTOManager.vratiSveOrganizatore();



            foreach (OrganizatorPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.OrganizatorID.ToString(), p.Kolekcija, p.PrvaModnaRevija.ToString() });
                listaOrganizatora.Items.Add(item);

            }



            listaOrganizatora.Refresh();
        }

        private void cmdModneRevije_Click(object sender, EventArgs e)
        {
            if (listaOrganizatora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite organizatora cije modne revije zelite da vidite!");
                return;
            }

            int idOrganizatora = Int32.Parse(listaOrganizatora.SelectedItems[0].SubItems[0].Text);
            OrganizatorBasic o = DTOManager.vratiOrganizatora(idOrganizatora);

            ModneRevijeForm forma = new ModneRevijeForm(o);
            forma.ShowDialog();
        }

        private void cmdModneKuce_Click(object sender, EventArgs e)
        {
            if (listaOrganizatora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite organizatora cije modne kuce zelite da vidite!");
                return;
            }

            int idOrganizatora = Int32.Parse(listaOrganizatora.SelectedItems[0].SubItems[0].Text);

            // DTOManager.proveriOrganizatora(idOrganizatora);

            OrganizatorBasic o = DTOManager.vratiOrganizatora(idOrganizatora);

            ModneKuceForm forma = new ModneKuceForm(o);
            forma.ShowDialog();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modniKreatoriPregled(object sender, EventArgs e)
        {
            if (listaOrganizatora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite organizatora cije modne kreatore zelite da vidite!");
                return;
            }

            int idOrganizatora = Int32.Parse(listaOrganizatora.SelectedItems[0].SubItems[0].Text);
            OrganizatorBasic o = DTOManager.vratiOrganizatora(idOrganizatora);

            ModniKreatorOrganizatorForm forma = new ModniKreatorOrganizatorForm(o);
            forma.ShowDialog();


        }

        private void btnDodajOrganizatora(object sender, EventArgs e)
        {
            OrganizatorDodajForm formaDodaj = new OrganizatorDodajForm();
            formaDodaj.ShowDialog();
            this.popuniOrganizatore();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
