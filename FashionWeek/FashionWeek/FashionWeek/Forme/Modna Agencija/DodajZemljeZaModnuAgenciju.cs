using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FashionWeek.Forme.Modna_Agencija
{
    public partial class DodajZemljeZaModnuAgenciju : Form
    {
        ModnaAgencijaBasic agencija;
        public DodajZemljeZaModnuAgenciju()
        {
            InitializeComponent();
        }
        public DodajZemljeZaModnuAgenciju(ModnaAgencijaBasic ag)
        {
            InitializeComponent();
            agencija = ag;
        }

        private void brtUpisiZemlje(object sender, EventArgs e)
        {
            

            foreach (var selectedItem in listBox1.SelectedItems)
            {
                NaziviZemaljaBasic zemlja = new NaziviZemaljaBasic();


                zemlja.Id = new NaziviZemaljaIdBasic(agencija, selectedItem.ToString());

                DTOManager.sacuvajZemlje(zemlja);
            }


            MessageBox.Show("Uspesno ste dodali zemlje!");
            this.Close();



        }
    }
}
