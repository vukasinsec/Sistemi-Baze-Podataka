using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class ModnaRevija
    {
        public  virtual int IdModneRevije { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual string? Naziv { get; set; }
        public virtual string? Grad { get; set; }
        public virtual DateTime DatumOdrzavanja { get; set; }
        public virtual int VremeOdrzavanja { get; set; }
        public virtual Organizator OrganizatorID { get; set; }
        public virtual string? ImeJavneLicnosti { get; set; }
        public virtual string? PrezimeJavneLicnosti { get; set; }
        public virtual string? ZanimanjeJL { get; set; }


        public virtual IList<Maneken> Manekeni { get; set; }
         public virtual IList<ModniKreator> ModniKreatori { get; set; }

         public virtual IList<Predstavlja> PredstavljajuMK { get; set; }

        public virtual IList<Nastupa> NastupajuManekeni { get; set; } = [];
        public virtual IList<SpecijalniGost>? GostiNaModnojReviji { get; set; } = [];
        public ModnaRevija()
        {
            Manekeni = new List<Maneken>();
            ModniKreatori = new List<ModniKreator>();
            PredstavljajuMK = new List<Predstavlja>();
           // NastupajuManekeni = new List<NastupaId>();
        }
    }
}
