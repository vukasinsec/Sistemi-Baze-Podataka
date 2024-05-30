using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class NaziviZemalja
    {
        public virtual NaziviZemaljaId Id { get; set; }

        public NaziviZemalja()
        {

            Id = new NaziviZemaljaId();
        }


    }
}
