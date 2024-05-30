using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class SpecijalniGost
    {
        public virtual int? IDGosta { get; set; }
        public virtual ModniKreator? MBRModniKreator { get; set; }
        public virtual ModnaRevija? IDModneRevije { get; set; }
        


    }
}
