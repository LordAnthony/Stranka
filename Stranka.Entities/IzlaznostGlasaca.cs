using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class IzlaznostGlasaca
    {
        public int Id { get; set; }
        public int IzboriBirackoMjestoId { get; set; }
        public int GlasacId { get; set; }
        public bool? Glasao { get; set; }

        public virtual IzboriBirackoMjesto IzboriBirackoMjesto { get; set; }
        public virtual Glasac Glasac { get; set; }        
    }
}
