using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class ImenaVlasnika
    {
        public virtual ImenaVlasnikaId Id { get; set; }

         public ImenaVlasnika()
        {
            Id = new ImenaVlasnikaId();
        }

    }
}
