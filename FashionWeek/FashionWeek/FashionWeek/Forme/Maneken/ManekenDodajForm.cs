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
    public partial class ManekenDodajForm : Form
    {
        ModnaAgencijaBasic agencija;
        public ManekenDodajForm()
        {
            InitializeComponent();
        }

        public ManekenDodajForm(ModnaAgencijaBasic ag)
        {
            InitializeComponent();
            agencija = ag;
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            checkBox1.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox changedCheckBox = sender as CheckBox;

            if (changedCheckBox == checkBox1 && checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else if (changedCheckBox == checkBox2 && checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdDodajManekena_Click(object sender, EventArgs e)
        {
            ManekenBasic maneken = new ManekenBasic();

            maneken.MBR = textBox1.Text;
            maneken.ZemljaPorekla = textBox6.Text;
            maneken.Ime = textBox7.Text;
            maneken.Prezime = textBox8.Text;
            maneken.BojaKose = textBox12.Text;
            maneken.BojaOciju = textBox11.Text;

            if (checkBox1.Checked == true)
            {
                maneken.Pol = 'M';
            }
            else if(checkBox2.Checked == true)
            {
                maneken.Pol = 'Z';
            }
            else
            {
                MessageBox.Show("Cekirajte Pol.");
            }


            maneken.DatumRodjenja = dateTimePicker1.Value;

            maneken.Visina = (int)numbericVisina.Value;
            maneken.Tezina = (float)tezinaNumeric.Value;

            if(comboBox1.SelectedIndex == 0)
            {
                maneken.KonfekcijskiBroj = "XS";
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                maneken.KonfekcijskiBroj = "S";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                maneken.KonfekcijskiBroj = "M";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                maneken.KonfekcijskiBroj = "L";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                maneken.KonfekcijskiBroj = "XL";
            }
            else
            {
                MessageBox.Show("Izaberite konfekcijski broj.");
            }

            maneken.PIBModneAgencije = agencija;

            DTOManager.sacuvajManekena(maneken);

     
            
            


            if(checkBoxCasopisi.Checked == true)
            {
                Maneken.DodajCasopiseZaManekenaForm form = new Maneken.DodajCasopiseZaManekenaForm(maneken);
                form.ShowDialog();
            }

            MessageBox.Show("Uspesno ste dodali manekena!");
            this.Close();



        }
    }
}
