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
    public partial class ModniKreatorUpdateForm : Form
    {
        ModniKreatorBasic kreator = new ModniKreatorBasic();
        public ModniKreatorUpdateForm()
        {
            InitializeComponent();
        }
        public ModniKreatorUpdateForm(ModniKreatorBasic k)
        {
            InitializeComponent();
            kreator = k;
        }

        private void ModniKreatorUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = kreator.MBR;
            textBox6.Text = kreator.ZemljaPorekla;
            textBox7.Text = kreator.Ime;
            textBox8.Text = kreator.Prezime;

            cenaUsluge.Value = (int)kreator.CenaUsluge;

            if (kreator.Pol == 'M')
            {
                checkBox1.Checked = true;
            }
            else if (kreator.Pol == 'Z')
            {
                checkBox2.Checked = true;
            }
            else
            {
                MessageBox.Show("Cekirajte Pol.");
            }



            dateTimePicker1.Value = kreator.DatumRodjenja;
        }

        private void cmdIzmeniModnogKreatora_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene modne revije?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {


                kreator.MBR = textBox1.Text;
                kreator.ZemljaPorekla = textBox6.Text;
                kreator.Ime = textBox7.Text;
                kreator.Prezime = textBox8.Text;
                kreator.CenaUsluge = (int)cenaUsluge.Value;

                kreator.DatumRodjenja = dateTimePicker1.Value;

                if (checkBox1.Checked == true)
                {
                    kreator.Pol = 'M';
                }
                else if (checkBox2.Checked == true)
                {
                    kreator.Pol = 'Z';
                }
                else
                {
                    MessageBox.Show("Cekirajte Pol.");
                }

                DTOManager.azurirajModnogKreatora(this.kreator);
                MessageBox.Show("Azuriranje modnog kreatora je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
