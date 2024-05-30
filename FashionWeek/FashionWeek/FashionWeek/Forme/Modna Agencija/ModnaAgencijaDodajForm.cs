using FashionWeek.Forme.Modna_Agencija;
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
    public partial class ModnaAgencijaDodajForm : Form
    {
        public ModnaAgencijaDodajForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModnaAgencijaBasic ag = new ModnaAgencijaBasic();

            ag.PIB = textBox1.Text;
            ag.Naziv = textBox2.Text;
            ag.DatumOsnivanja = dateTimePicker1.Value;
            ag.Drzava = textBox3.Text;
            ag.Grad = textBox5.Text;

            if (checkBox1.Checked == true)
            {
                ag.PInternacionalna = 1;
            }
            else
            {
                ag.PInternacionalna = 0;
            }



            DTOManager.sacuvajModnuAgenciju(ag);

            MessageBox.Show("Uspesno ste dodali modnu agenciju!");

            

            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Sada, dodajte nazive zemalja!");
                DodajZemljeZaModnuAgenciju forma = new DodajZemljeZaModnuAgenciju(ag);
                forma.ShowDialog();

            }


            this.Close();
        }

            private void ModnaAgencijaDodajForm_Load(object sender, EventArgs e)
        {
           
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //button2.Visible = checkBox1.Checked;
            //listBox1.Visible = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
