using FashionWeek.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrganizatori_Click(object sender, EventArgs e)
        {
            OrganizatoriForm forma = new OrganizatoriForm();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModnaAgencijaForm forma = new ModnaAgencijaForm();
            forma.ShowDialog();
        }

        private void btnManekeni_Click(object sender, EventArgs e)
        {
            SviManekeniForm forma = new SviManekeniForm();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SveModneRevijeForm forma = new SveModneRevijeForm();
            forma.ShowDialog();
        }
    }
}
