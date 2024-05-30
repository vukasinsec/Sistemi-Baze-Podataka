using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class ModnaAgencija
    {
        public virtual  string PIB { get; set; }
        public virtual string? Naziv { get; set; }
        public virtual DateTime DatumOsnivanja { get; set; }
        public virtual string? Drzava { get; set; }
        public virtual string? Grad { get; set; }
      
       public virtual int PInternacionalna { get; set; }

        //  public virtual string Tip {  get; set; }
        public virtual IList<NaziviZemalja> NaziviZemalja { get; set; }

        public virtual IList<Maneken>? Manekeni { get; set; }

        public ModnaAgencija()
        {

            Manekeni = new List<Maneken>();
            NaziviZemalja=new List<NaziviZemalja>();
        }
    }


 /*   public class InternacionalnaAgencija:ModnaAgencija
    {
        public IList<NaziviZemalja> NaziviZemalja { get; set; }

        public InternacionalnaAgencija()
        {
            NaziviZemalja=new List<NaziviZemalja>();
        }
    }

    public class DomacaAgencija:ModnaAgencija 
    { 
    
    
    
    }
 */
}
