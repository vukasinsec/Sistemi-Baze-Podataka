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
    public partial class ManekeniForm : Form
    {
        ModnaAgencijaBasic agencija;
        public ManekeniForm()
        {
            InitializeComponent();
        }

        public ManekeniForm(ModnaAgencijaBasic ag)
        {
            InitializeComponent();
            agencija = ag;
        }

        private void ManekeniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }


        public void popuniPodacima()
        {
            listaManekena.Items.Clear();
            List<ManekenPregled> podaci = DTOManager.vratiManekene(agencija.PIB);



            foreach (ManekenPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.MBR, p.Pol.ToString(), p.DatumRodjenja.ToString(), p.ZemljaPorekla, p.Ime, p.Prezime, p.BojaKose, p.Visina.ToString(), p.BojaOciju, p.Tezina.ToString(), p.KonfekcijskiBroj });
                listaManekena.Items.Add(item);

            }


            listaManekena.Refresh();
        }

        private void btnDodajManekena_Click(object sender, EventArgs e)
        {

            ManekenDodajForm forma = new ManekenDodajForm(agencija);
            forma.ShowDialog();

            this.popuniPodacima();

        }
    }
}
