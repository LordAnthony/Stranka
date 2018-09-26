using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stranka.Services.Entities
{
    public class PolitickiSubjekt
    {
        public long id { get; set; }
        public string sifra { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string grad { get; set; }
        public string telefon { get; set; }
    }
}
