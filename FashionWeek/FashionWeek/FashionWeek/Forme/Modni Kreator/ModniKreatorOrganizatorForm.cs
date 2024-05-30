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
    public partial class ModniKreatorOrganizatorForm : Form
    {
        OrganizatorBasic organizator;
        public ModniKreatorOrganizatorForm()
        {
            InitializeComponent();
        }

        public ModniKreatorOrganizatorForm(OrganizatorBasic k)
        {
            InitializeComponent();
            organizator = k;
        }

        private void ModniKreatorOrganizatorForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            if(listaModnihKreatoraOrganizatora.Items.Count == 1)
            {
                groupBox2.Visible = false;
            }
        }

        public void popuniPodacima()
        {

            listaModnihKreatoraOrganizatora.Items.Clear();
            List<ModniKreatorPregled> podaci = DTOManager.vratiModneKreatoreIzOrganizatora(organizator.OrganizatorID);



            foreach (ModniKreatorPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.MBR, p.Pol.ToString(), p.DatumRodjenja.ToString(), p.ZemljaPorekla, p.Ime, p.Prezime, p.CenaUsluge.ToString() });
                listaModnihKreatoraOrganizatora.Items.Add(item);

            }



            listaModnihKreatoraOrganizatora.Refresh();


        }

        private void cmdDodajModnogKreatora_Click(object sender, EventArgs e)
        {
            ModniKreatoriOrganizatoriDodajForm formaDodaj = new ModniKreatoriOrganizatoriDodajForm(organizator);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }
    }
}
