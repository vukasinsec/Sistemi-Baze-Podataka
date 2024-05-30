using FashionWeek.Entiteti;
using FashionWeek.Forme.Modna_Kuca;
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
    public partial class ModnaKucaDodajForm : Form
    {
        OrganizatorBasic organizator;
        public ModnaKucaDodajForm()
        {
            InitializeComponent();
        }

        public ModnaKucaDodajForm(OrganizatorBasic o)
        {
            InitializeComponent();
            this.organizator = o;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModnaKucaBasic k = new ModnaKucaBasic();
            k.Naziv = textBox1.Text;
            k.ImeOsnivaca = textBox2.Text;
            k.PrezimeOsnivaca = textBox5.Text;
            k.Drzava = textBox6.Text;
            k.Grad = textBox7.Text;

            k.OrganizatorID = organizator;
            DTOManager.sacuvajModnuKucu(k);
            MessageBox.Show("Uspesno ste dodali modnu kucu!");

            if (checkBoxVlasnici.Checked == true)
            {
                DodajVlasnikeZaModnuKucuForm form = new DodajVlasnikeZaModnuKucuForm(k);
                form.ShowDialog();
            }


            this.Close();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
