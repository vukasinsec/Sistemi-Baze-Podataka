using FluentNHibernate.Automapping.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class Maneken:Osoba
    {
      //  public virtual string MBR { get; set; }//fk
        public virtual string BojaKose { get; set; }
        public virtual int Visina { get; set; }
        public virtual string BojaOciju { get; set; }
        public virtual float Tezina { get; set; }
        public virtual string KonfekcijskiBroj { get; set; }
        public virtual ModnaAgencija PIBModneAgencije { get; set; }//fk

        public virtual IList<ModnaRevija> ModneRevijeManekeni { get; set; }
        public virtual IList<Nastupa> NastupaManeken { get; set; }

        public virtual IList<Casopisi> UcasopisimaManeken { get; set; }

        public Maneken()
        {
            ModneRevijeManekeni = new List<ModnaRevija>();
            NastupaManeken = new List<Nastupa>();
            UcasopisimaManeken = new List<Casopisi>();
        }

    }
}
