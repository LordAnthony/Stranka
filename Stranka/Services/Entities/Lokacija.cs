using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stranka.Services.Entities
{
    public class Lokacija
    {
        public long id { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public long izbornaJedinicaId { get; set; }
        public string izbornaJedinicaNaziv { get; set; }
    }
}
