using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class Organizator
    {
        public virtual  int OrganizatorID { get; set; }//provera gde treba required!!!!!
        public virtual string? Kolekcija { get; set; }
        public virtual char PrvaModnaRevija { get; set; }

        public virtual IList<ModnaRevija> ModneRevije { get; set; }
        public virtual IList<ModnaKuca> ModneKuce { get; set; }
        public virtual IList<ModniKreator> ModniKreatori { get; set; }


        public Organizator()
        {

            ModneRevije = new List<ModnaRevija>();
            ModneKuce = new List<ModnaKuca>();
            ModniKreatori = new List<ModniKreator>();
        }
    }
}
