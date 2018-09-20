using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stranka.Services.Entities
{
    public class Lokacija
    {
        public long Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public long IzbornaJedinicaId { get; set; }
        public string IzbornaJedinicaNaziv { get; set; }
    }
}
