using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public  class CasopisiId
    {
        public  virtual    Maneken Maneken { get; set; }
        public  virtual   string NaziviCasopisa { get; set; }

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

            CasopisiId compare = (CasopisiId)obj;

            return Maneken.MBR == compare.Maneken.MBR &&
                  this. NaziviCasopisa == compare.NaziviCasopisa;
        }

        public override int GetHashCode()
        {
            return this.Maneken.MBR.GetHashCode();
        }
    }
}
