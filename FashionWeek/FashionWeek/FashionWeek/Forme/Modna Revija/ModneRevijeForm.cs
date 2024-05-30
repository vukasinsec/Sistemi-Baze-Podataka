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
    public partial class ModneRevijeForm : Form
    {
        OrganizatorBasic organizator;
        public ModneRevijeForm()
        {
            InitializeComponent();
        }

        public ModneRevijeForm(OrganizatorBasic o)
        {
            InitializeComponent();
            organizator = o;
        }

        private void ModneRevijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            //MessageBox.Show(organizator.OrganizatorID.ToString());
            
        }

        public void popuniPodacima()
        {


            listaModnihRevija.Items.Clear();
            List<ModnaRevijaPregled> podaci = DTOManager.vratiModneRevije(organizator.OrganizatorID);



            foreach (ModnaRevijaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IdModneRevije.ToString(), p.RedniBroj.ToString(), p.Naziv, p.Grad, p.DatumOdrzavanja.ToString(), p.VremeOdrzavanja.ToString(), p.ImeJavneLicnosti, p.PrezimeJavneLicnosti, p.ZanimanjeJL });
                listaModnihRevija.Items.Add(item);

            }



            listaModnihRevija.Refresh();
        }

        

        private void cmdObrisiModnuReviju_Click(object sender, EventArgs e)
        {
            if (listaModnihRevija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Reviju koju zelite da obrisete!");
                return;
            }

            int idProdavnice = Int32.Parse(listaModnihRevija.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu modnu reviju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiReviju(idProdavnice);
                MessageBox.Show("Brisanje modne revije je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void cmdDodajModnuReviju_Click(object sender, EventArgs e)
        {
            ModnaRevijaDodajForm formaDodaj = new ModnaRevijaDodajForm(organizator);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void cmdIzmeniModnuReviju_Click(object sender, EventArgs e)
        {
            if (listaModnihRevija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite modnu reviju cije podatke zelite da izmenite!");
                return;
            }

            int idRevije = Int32.Parse(listaModnihRevija.SelectedItems[0].SubItems[0].Text);
            ModnaRevijaBasic mr = DTOManager.vratiReviju(idRevije);

            ModnaRevijaUpdateForm formaUpdate = new ModnaRevijaUpdateForm(mr);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
