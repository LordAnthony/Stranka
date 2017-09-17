using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class IzboriBirackoMjesto
    {
        public int Id { get; set; }
        public int IzboriId { get; set; }
        public int BirackoMjestoId { get; set; }
        public int? BrojGlasaca { get; set; }
        public int? IzasloGlasaca { get; set; }
        public string Napomena { get; set; }

        public virtual Izbori Izbori { get; set; }
        public virtual BirackoMjesto BirackoMjesto { get; set; }          
        public virtual List<IzlaznostGlasaca> IzlaznostiGlasaca { get; set; }
    }
}
