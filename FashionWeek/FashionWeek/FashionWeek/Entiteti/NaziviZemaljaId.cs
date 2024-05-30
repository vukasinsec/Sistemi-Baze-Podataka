using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class NaziviZemaljaId
    {
        public virtual ModnaAgencija? Agencija { get; set; }
        public virtual string? Zemlje { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != typeof(NastupaId))
            {
                return false;
            }

            NaziviZemaljaId compare = (NaziviZemaljaId)obj;

            return Agencija.PIB == compare.Agencija.PIB &&
                  this.Zemlje == compare.Zemlje;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
