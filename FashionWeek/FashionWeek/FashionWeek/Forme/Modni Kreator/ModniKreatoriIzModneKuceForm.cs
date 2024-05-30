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
    public partial class ModniKreatoriIzModneKuceForm : Form
    {
        ModnaKucaBasic kuca;
        public ModniKreatoriIzModneKuceForm()
        {
            InitializeComponent();
        }

        public ModniKreatoriIzModneKuceForm(ModnaKucaBasic k)
        {
            InitializeComponent();
            kuca = k;
        }

        private void ModniKreatoriIzModneKuceForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {

            listaModnihKreatora.Items.Clear();
            List<ModniKreatorPregled> podaci = DTOManager.vratiModneKreatore(kuca.Naziv);



            foreach (ModniKreatorPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.MBR, p.Pol.ToString(), p.DatumRodjenja.ToString(), p.ZemljaPorekla, p.Ime, p.Prezime, p.CenaUsluge.ToString() });
                listaModnihKreatora.Items.Add(item);

            }



            listaModnihKreatora.Refresh();


        }

        private void cmdDodajModnogKreatora_Click(object sender, EventArgs e)
        {
            ModniKreatoriDodajForm formaDodaj = new ModniKreatoriDodajForm(kuca);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void cmdObrisiModnogKreatora_Click(object sender, EventArgs e)
        {

            if (listaModnihKreatora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnog Kreatora koju zelite da obrisete!");
                return;
            }

            string mbr = listaModnihKreatora.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog modnog Kreatora?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiModnogKreatora(mbr);
                MessageBox.Show("Brisanje modnog kreatora je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }



        }

        private void cmdIzmeniModnogKreatora_Click(object sender, EventArgs e)
        {
            if (listaModnihKreatora.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite modnog kreatora cije podatke zelite da izmenite!");
                return;
            }

            string mbr = listaModnihKreatora.SelectedItems[0].SubItems[0].Text;
            ModniKreatorBasic mr = DTOManager.vratiModnogKreatora(mbr);

            ModniKreatorUpdateForm formaUpdate = new ModniKreatorUpdateForm(mr);
            formaUpdate.ShowDialog();

            this.popuniPodacima();



        }
    }
}
