using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class PredstavljaId
    {
        public virtual required ModniKreator MKPredstavlja { get; set; }
        public virtual required ModnaRevija NaModnojReviji { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != typeof(PredstavljaId))
            {
                return false;
            }

            PredstavljaId compare = (PredstavljaId)obj;

            return MKPredstavlja.MBR == compare.MKPredstavlja.MBR &&
                   NaModnojReviji.Naziv == compare.NaModnojReviji.Naziv;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
