using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FashionWeek.Entiteti.Casopisi;

namespace FashionWeek.Entiteti
{
    public class Casopisi
    {
        public virtual CasopisiId Id { get; set; }

        public Casopisi() {
             Id=new CasopisiId();
         }
        
     
    }
}
