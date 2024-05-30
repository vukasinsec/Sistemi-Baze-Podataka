using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class Nastupa
    {
        public virtual NastupaId Id { get; set; }
       

        public Nastupa()
        {

            Id = new NastupaId();
        }
    }
}
