using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stranka.Services.Entities
{
    public class BirackoMjesto
    {
        public long Id { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public long LokacijaId { get; set; }
        public string LokacijaNaziv { get; set; }
    }
}
