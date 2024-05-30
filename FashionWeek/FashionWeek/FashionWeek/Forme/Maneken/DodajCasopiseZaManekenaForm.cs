using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forme.Maneken
{
    
    public partial class DodajCasopiseZaManekenaForm : Form
    {

        ManekenBasic maneken;
        public DodajCasopiseZaManekenaForm()
        {
            InitializeComponent();
        }
        public DodajCasopiseZaManekenaForm(ManekenBasic m)
        {
            InitializeComponent();
            maneken = m;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in listBox1.SelectedItems)
            {
                CasopisiBasic zemlja = new CasopisiBasic();


                zemlja.Id = new CasopisiIdBasic(maneken, selectedItem.ToString());

                DTOManager.sacuvajManekena(zemlja);
            }


            MessageBox.Show("Uspesno ste dodali casopise!");
            this.Close();
        }
    }
}
