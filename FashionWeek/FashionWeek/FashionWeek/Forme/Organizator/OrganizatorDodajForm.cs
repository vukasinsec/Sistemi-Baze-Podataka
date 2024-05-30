using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FashionWeek.Forme
{
    public partial class OrganizatorDodajForm : Form
    {
        public OrganizatorDodajForm()
        {
            InitializeComponent();
        }

        private void btnDodajOrganizatora(object sender, EventArgs e)
        {
            OrganizatorBasic organizator = new OrganizatorBasic();

            organizator.Kolekcija = textBox1.Text;

            if (checkBox1.Checked == true)
            {
                organizator.PrvaModnaRevija = 'y';
            }
            else if (checkBox2.Checked == true)
            {
                organizator.PrvaModnaRevija = 'n';
            }
            else
            {
                MessageBox.Show("Cekirajte da li je prva modna revija.");
            }


            DTOManager.sacuvajOrganizatora(organizator);



            MessageBox.Show("Uspesno ste dodali organizatora!");
            this.Close();

        }
    }
}
