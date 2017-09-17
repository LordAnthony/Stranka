using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class Izbori
    {
        public int Id { get; set; }
        public int VrstaIzboraId { get; set; }
        public int NivoIzboraId { get; set; }
        public DateTime DatumOdrzavanja { get; set; }

        public virtual VrstaIzbora VrstaIzbora { get; set; }
        public virtual NivoIzbora NivoIzbora { get; set; }
        public virtual List<IzboriBirackoMjesto> IzboriBirackaMjesta { get; set; }
        public virtual List<IzboriHijerarhija> IzboriHijerarhije { get; set; }
    }
}
