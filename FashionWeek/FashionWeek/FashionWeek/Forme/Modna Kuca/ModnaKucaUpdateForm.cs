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

    public partial class ModnaKucaUpdateForm : Form
    {

        public ModnaKucaBasic kuca;

        public ModnaKucaUpdateForm()
        {
            InitializeComponent();
        }

        public ModnaKucaUpdateForm(ModnaKucaBasic k)
        {
            InitializeComponent();
            this.kuca = k;
        }

        private void ModnaKucaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = kuca.Naziv;
            textBox2.Text = kuca.ImeOsnivaca;
            textBox5.Text = kuca.PrezimeOsnivaca;
            textBox6.Text = kuca.Drzava;
            textBox7.Text = kuca.Grad;
        }

        private void izmeniModnuKucu_Click_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da izvrsite izmene modne kuce?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.kuca.Naziv = textBox1.Text;
                this.kuca.ImeOsnivaca = textBox2.Text;
                this.kuca.PrezimeOsnivaca = textBox5.Text;
                this.kuca.Drzava = textBox6.Text;
                this.kuca.Grad = textBox7.Text;

                DTOManager.azurirajModnuKucu(this.kuca);
                MessageBox.Show("Azuriranje modne kuce je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }

        }
    }
}
