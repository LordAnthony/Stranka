using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int NivoIzboraId { get; set; }

        public virtual NivoIzbora NivoIzbora { get; set; }
        public virtual List<Hijerarhija> Hijerarhije { get; set; }
    }
}
