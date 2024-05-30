using FashionWeek.Forme.Modna_Revija;
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
    public partial class ModnaRevijaDodajForm : Form
    {
        OrganizatorBasic organizator;
        public ModnaRevijaDodajForm()
        {
            InitializeComponent();
        }

        public ModnaRevijaDodajForm(OrganizatorBasic o)
        {
            InitializeComponent();
            organizator = o;
            textBox5.Enabled = false; 
            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }

        private void labelaRedniBroj_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ModnaRevijaBasic m = new ModnaRevijaBasic();
            m.Naziv = textBox1.Text;
            m.Grad = textBox2.Text;
            m.DatumOdrzavanja = dateTimePicker1.Value;
            m.VremeOdrzavanja = (int)numericUpDown1.Value;

            if (checkBox1.Checked)
            {
                m.ImeJavneLicnosti = textBox5.Text;
                m.PrezimeJavneLicnosti = textBox6.Text;
                m.ZanimanjeJL = textBox7.Text;
            }

            if (DTOManager.proveriRedniBroj((int)numericUpDown2.Value))
            {
                StringBuilder sb = new();
                sb.AppendLine($"Redni broj modne revije postoji\n");

                MessageBox.Show(sb.ToString());
            }
            else
            {
                m.RedniBroj = (int)numericUpDown2.Value;



                m.OrganizatorID = organizator;
                DTOManager.sacuvajModnuReviju(m);


               

                MessageBox.Show("Uspesno ste dodali modnu reviju!");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;

            }

        }
    }
}
