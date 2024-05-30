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
    public partial class ModnaRevijaUpdateForm : Form
    {
        public ModnaRevijaBasic revija;
        public ModnaRevijaUpdateForm()
        {
            InitializeComponent();
        }

        public ModnaRevijaUpdateForm(ModnaRevijaBasic r)
        {
            InitializeComponent();
            this.revija = r;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene modne revije?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.revija.Naziv = textBox1.Text;
                this.revija.Grad = textBox2.Text;
                this.revija.DatumOdrzavanja = dateTimePicker1.Value;
                this.revija.VremeOdrzavanja = (int)numericUpDown1.Value;
                this.revija.ImeJavneLicnosti = textBox5.Text;
                this.revija.PrezimeJavneLicnosti = textBox6.Text;
                this.revija.ZanimanjeJL = textBox7.Text;
                this.revija.RedniBroj = (int)numericUpDown2.Value;

                if (!checkBox1.Checked)
                {
                    this.revija.ImeJavneLicnosti = null;
                    this.revija.PrezimeJavneLicnosti = null;
                    this.revija.ZanimanjeJL = null;
                   
                }

                try
                {
                    DTOManager.azurirajModnuReviju(this.revija);
                    MessageBox.Show("Azuriranje modne kuce je uspesno izvrseno!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            else
            {

            }
        }

        private void ModnaRevijaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE MODNE REVIJE {revija.Naziv.ToUpper()}";
        }

        public void popuniPodacima()
        {
            

            textBox1.Text = revija.Naziv;
            textBox2.Text = revija.Grad;
            dateTimePicker1.Value = revija.DatumOdrzavanja;
            numericUpDown1.Value = revija.VremeOdrzavanja;
            textBox5.Text = revija.ImeJavneLicnosti;
            textBox6.Text = revija.PrezimeJavneLicnosti;
            textBox7.Text = revija.ZanimanjeJL;
            numericUpDown2.Value = revija.RedniBroj;
            if (textBox5.Text.Length > 0)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
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
