using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stranka.Services.Entities
{
    public class Kandidat
    {
        public long Id { get; set; }
        public string ImePrezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    }
}
