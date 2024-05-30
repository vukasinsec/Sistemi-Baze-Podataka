using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class Predstavlja
    {

        public virtual required PredstavljaId Id { get; set; }//kompozitni kljuc onda ovo ispod ne treba???!!!!
      //  public virtual string MBR { get; set; }
       // public virtual int IDModneRevije { get; set; }

      /*  public Predstavlja() { 
        
            Id= new PredstavljaId();
        }*/
    }
}
