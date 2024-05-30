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
    public partial class ModniKreatorPredstavljaForm : Form
    {
        List<ModniKreatorPregled> kreatori;
        public ModniKreatorPredstavljaForm()
        {
            InitializeComponent();
        }

        public ModniKreatorPredstavljaForm(List<ModniKreatorPregled> k)
        {
            InitializeComponent();
            kreatori = k;
        }

        private void ModniKreatorPredstavljaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }


        public void popuniPodacima()
        {

            listaModnihKreatoraPredstavljaju.Items.Clear();



            foreach (ModniKreatorPregled p in kreatori)
            {
                ListViewItem item = new ListViewItem(new string[] { p.MBR, p.Pol.ToString(), p.DatumRodjenja.ToString(), p.ZemljaPorekla, p.Ime, p.Prezime, p.CenaUsluge.ToString() });
                listaModnihKreatoraPredstavljaju.Items.Add(item);

            }



            listaModnihKreatoraPredstavljaju.Refresh();


        }
    }
}
