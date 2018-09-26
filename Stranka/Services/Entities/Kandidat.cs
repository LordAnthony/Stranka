using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stranka.Services.Entities
{
    public class Kandidat
    {
        public long id { get; set; }
        public string imePrezime { get; set; }
        public string jmbg { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
    }
}
