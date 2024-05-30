using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class ImenaVlasnikaId
    {
        

        public virtual  ModnaKuca ModnaKuca { get; set; }
        public virtual  string ImenaVlasnika { get; set; }
        //public ModnaKucaBasic Kuca { get; }
       // public string? V { get; }

        //public ImenaVlasnikaId(ModnaKucaBasic kuca, string? v)
        //{
        //    Kuca = kuca;
        //    ImenaVlasnika = v;
       // }

        


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

            ImenaVlasnikaId compare = (ImenaVlasnikaId)obj;

            return ModnaKuca.Naziv == compare.ModnaKuca.Naziv &&
                  this.ImenaVlasnika == compare.ImenaVlasnika;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
