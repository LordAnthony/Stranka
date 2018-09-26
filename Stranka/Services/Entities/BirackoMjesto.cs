using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stranka.Services.Entities
{
    public class BirackoMjesto
    {
        public long id { get; set; }
        public string sifra { get; set; }
        public string naziv { get; set; }
        public long lokacijaId { get; set; }
        public string lokacijaNaziv { get; set; }
    }
}
