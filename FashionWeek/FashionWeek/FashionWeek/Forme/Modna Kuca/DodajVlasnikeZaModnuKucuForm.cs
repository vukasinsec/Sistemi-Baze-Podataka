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

namespace FashionWeek.Forme.Modna_Kuca
{
    public partial class DodajVlasnikeZaModnuKucuForm : Form
    {
        ModnaKucaBasic kuca;
        public DodajVlasnikeZaModnuKucuForm()
        {
            InitializeComponent();
        }

        public DodajVlasnikeZaModnuKucuForm(ModnaKucaBasic k)
        {
            InitializeComponent();
            kuca = k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImenaVlasnikaBasic vlasnik = new ImenaVlasnikaBasic();

            string listaVlasnika = ""; 

            foreach (var selectedItem in listBox1.Items)
            {
                listaVlasnika += selectedItem.ToString() + " ";
            }

            
            listaVlasnika = listaVlasnika.Trim();

            vlasnik.Id = new ImenaVlasnikaIdBasic(kuca, listaVlasnika);

            DTOManager.sacuvajVlasnika(vlasnik);

            MessageBox.Show("Uspesno ste dodali vlasnike!");
            this.Close();
        }

            private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);

                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Unesite neku vrednost.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
