using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja
{
     class ImenaVlasnikaMapiranja : ClassMap<FashionWeek.Entiteti.ImenaVlasnika>
    {
        public ImenaVlasnikaMapiranja()
        {
            // Naziv tabele u bazi podataka
            Table("IMENAVLASNIKA");

            CompositeId(x => x.Id)
                     .KeyReference(x => x.ModnaKuca, "MODNAKUCA")
                        .KeyProperty(x => x.ImenaVlasnika, "IMENAVLASNIKA");
           
           



        }
    }
}
