using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FashionWeek.Entiteti
{
    public class ModnaKuca
    {
        public virtual  string Naziv { get; set; }
        public virtual string? ImeOsnivaca { get; set; }
        public virtual string? PrezimeOsnivaca { get; set; }
        public virtual string? Drzava { get; set; }
        public virtual string? Grad { get; set; }
      //  public virtual IList<String> ImenaVlasnika { get; set; }
        public virtual Organizator? OrganizatorID { get; set; }

        public virtual IList<ModniKreator> ModniKreatori { get; set; }

        public virtual IList<ImenaVlasnika> Vlasnici { get; set; }

        public ModnaKuca() { 
        
        ModniKreatori = new List<ModniKreator>();
          Vlasnici= new List<ImenaVlasnika>();
        }  
    }
}
