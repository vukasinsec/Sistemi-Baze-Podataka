using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public abstract class Osoba
    {
        
        public virtual string MBR { get; set; }
        public virtual char Pol { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string? ZemljaPorekla { get; set; }
        public virtual string? Ime { get; set; }
        public virtual string? Prezime { get; set; }
       // public virtual string? TipOsobe { get; set; }

       

    }
}
