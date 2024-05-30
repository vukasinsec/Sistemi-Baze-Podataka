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
    public partial class ManekeniNastupajuForm : Form
    {
        List<ManekenPregled> manekeni;

        public ManekeniNastupajuForm()
        {
            InitializeComponent();
        }

        public ManekeniNastupajuForm(List<ManekenPregled> m)
        {
            InitializeComponent();
            manekeni = m;
        }

        private void ManekniNastupajuForm_Load(object sender, EventArgs e)
        {

            popuniPodacima();
        }


        public void popuniPodacima()
        {
            listaManekenaNastupaju.Items.Clear();


            // List<ManekenPregled> podaci = DTOManager.vratiSveManekene();



            foreach (ManekenPregled p in manekeni)
            {
                ListViewItem item = new ListViewItem(new string[] { p.MBR, p.Pol.ToString(), p.DatumRodjenja.ToString(), p.ZemljaPorekla, p.Ime, p.Prezime, p.BojaKose, p.Visina.ToString(), p.BojaOciju, p.Tezina.ToString(), p.KonfekcijskiBroj });
                listaManekenaNastupaju.Items.Add(item);

            }



            listaManekenaNastupaju.Refresh();


        }
    }
}
