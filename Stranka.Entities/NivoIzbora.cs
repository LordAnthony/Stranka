using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class NivoIzbora
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual List<Izbori> Izbori { get; set; }
        public virtual List<Kategorija> Kategorije { get; set; }
    }
}
