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
    public partial class ModnaAgencijaUpdateForm : Form
    {

        public ModnaAgencijaBasic agencija;

        public ModnaAgencijaUpdateForm()
        {
            InitializeComponent();
        }

        public ModnaAgencijaUpdateForm(ModnaAgencijaBasic m)
        {
            InitializeComponent();
            this.agencija = m;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene modne agencije?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.agencija.PIB = textBox1.Text;
                agencija.Naziv = textBox2.Text;
                agencija.DatumOsnivanja = dateTimePicker1.Value;
                agencija.Drzava = textBox3.Text;
                agencija.Grad = textBox5.Text;
                if(checkBox1.Checked == true)
                {
                    agencija.PInternacionalna = 1;
                }
                else
                {
                    agencija.PInternacionalna = 0;
                }
               


                DTOManager.azurirajModnuAgenciju(agencija);
                MessageBox.Show("Azuriranje modne agencije je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void ModnaAgencijaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = agencija.PIB;
            textBox2.Text = agencija.Naziv;
            dateTimePicker1.Value = agencija.DatumOsnivanja;
            textBox3.Text = agencija.Drzava;
            textBox5.Text = agencija.Grad;
            if (agencija.PInternacionalna == 1)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
    }
}
