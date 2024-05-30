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

namespace FashionWeek.Forme.Modna_Revija
{
    public partial class RevijeManekenaForm : Form
    {
        List<ModnaRevijaPregled> revije;
        public RevijeManekenaForm()
        {
            InitializeComponent();
        }
        public RevijeManekenaForm(List<ModnaRevijaPregled> r)
        {
            InitializeComponent();
            revije = r;
        }


        public void popuniPodacima()
        {
            listaModnihRevija.Items.Clear();


            // List<ManekenPregled> podaci = DTOManager.vratiSveManekene();



            foreach (ModnaRevijaPregled p in revije)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    p.IdModneRevije.ToString(),p.RedniBroj.ToString(),p.Naziv,p.Grad,p.DatumOdrzavanja.ToString(),p.ImeJavneLicnosti.ToString(),p.PrezimeJavneLicnosti,p.ZanimanjeJL
                });
                listaModnihRevija.Items.Add(item);

            }



            listaModnihRevija.Refresh();


        }

        private void RevijeManekenaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
