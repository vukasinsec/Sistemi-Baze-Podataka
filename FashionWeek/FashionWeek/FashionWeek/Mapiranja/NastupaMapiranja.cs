using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja
{
     class NastupaMapiranja : ClassMap<FashionWeek.Entiteti.Nastupa>
    {
        public NastupaMapiranja()
        {
            // Naziv tabele u bazi podataka
            Table("NASTUPA");

            // Primarni ključ koji se generiše korišćenjem trigger-a
            // Id(p => p.IdModneRevije, "IDMODNEREVIJE").GeneratedBy.TriggerIdentity();//assigned za podatak koji neko unosi

            CompositeId(p => p.Id)
               .KeyReference(p => p.ManekenNaReviji, "MANEKENMBR")
               .KeyReference(p => p.NaReviji, "MODNAREVIJA");


        }
    }
}
