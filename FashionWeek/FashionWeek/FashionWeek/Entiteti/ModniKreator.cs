using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FashionWeek.Entiteti
{
    public class ModniKreator:Osoba
    {
      //  public virtual string MBR { get; set; }
        public virtual int CenaUsluge { get; set; }

        public virtual Organizator? OrganizatorID { get; set; }
        public virtual ModnaKuca NazivModneKuce { get; set; }

        public virtual IList<SpecijalniGost>? GostNaModnojReviji { get; set; } = [];

          public virtual IList<ModnaRevija> ModneRevijeMK { get; set; }

         public virtual IList<Predstavlja> PredstavljaMK { get; set; }
        public ModniKreator() {
        
           ModneRevijeMK = new List<ModnaRevija>();
           PredstavljaMK = new List<Predstavlja>();


        }


    }
}
