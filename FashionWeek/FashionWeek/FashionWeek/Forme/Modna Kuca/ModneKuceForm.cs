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
    public partial class ModneKuceForm : Form
    {
        OrganizatorBasic organizator;

        public ModneKuceForm()
        {
            InitializeComponent();
        }
        public ModneKuceForm(OrganizatorBasic o)
        {
            InitializeComponent();
            organizator = o;
        }


        public void popuniPodacima()
        {


            listaModnihKuca.Items.Clear();
            List<ModnaKucaPregled> podaci = DTOManager.vratiModneKuce(organizator.OrganizatorID);



            foreach (ModnaKucaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.ImeOsnivaca, p.PrezimeOsnivaca, p.Drzava, p.Grad });
                listaModnihKuca.Items.Add(item);

            }



            listaModnihKuca.Refresh();
        }

        private void cmdDodajModnuKucu_Click(object sender, EventArgs e)
        {
            ModnaKucaDodajForm formaDodaj = new ModnaKucaDodajForm(organizator);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void ModneKuceForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void cmdObrisiModnuKucu_Click(object sender, EventArgs e)
        {
            if (listaModnihKuca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Kucu koju zelite da obrisete!");
                return;
            }

            string nazivKuce = listaModnihKuca.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranu modnu kucu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiModnuKucu(nazivKuce);
                MessageBox.Show("Brisanje modne revije je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void cmdIzmeniModnuKucu_Click(object sender, EventArgs e)
        {
            if (listaModnihKuca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite modnu reviju cije podatke zelite da izmenite!");
                return;
            }

            string nazivKuce = listaModnihKuca.SelectedItems[0].SubItems[0].Text;
            ModnaKucaBasic mr = DTOManager.vratiKucu(nazivKuce);

            ModnaKucaUpdateForm formaUpdate = new ModnaKucaUpdateForm(mr);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listaModnihKuca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite modnu kucu cije modne kreatore zelite da vidite!");
                return;
            }

            string nazivModneKuce = listaModnihKuca.SelectedItems[0].SubItems[0].Text;
            ModnaKucaBasic o = DTOManager.vratiKucu(nazivModneKuce);

            ModniKreatoriIzModneKuceForm forma = new ModniKreatoriIzModneKuceForm(o);
            forma.ShowDialog();



        }

        private void btnImenaVlasnika_click(object sender, EventArgs e)
        {

            if (listaModnihKuca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Modnu Agenciju!");
                return;
            }

            string nazivKuce = listaModnihKuca.SelectedItems[0].SubItems[0].Text;

            
            

            List<ImenaVlasnikaPregled> vlasnici = DTOManager.vratiVlasnike(nazivKuce);

                if (vlasnici.Count != 0)
                {

                    StringBuilder sb = new();
                    sb.AppendLine($"Modna kuca {listaModnihKuca.SelectedItems[0].SubItems[0].Text} ima sledece vlasnike:\n");

                    foreach (ImenaVlasnikaPregled s in vlasnici)
                    {
                        sb.AppendLine($"{s.Id.ImenaVlasnika.ToString()}");
                    }

                    MessageBox.Show(sb.ToString());
                }
                else
                {
                    StringBuilder sb = new();
                    sb.AppendLine($"Modna kuca {listaModnihKuca.SelectedItems[0].SubItems[0].Text} nema vlasnike!");

                    MessageBox.Show(sb.ToString());
                }
            
            
            this.popuniPodacima();


        }
    }
}
