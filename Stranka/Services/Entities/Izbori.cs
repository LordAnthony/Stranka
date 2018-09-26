using System;
using System.Collections.Generic;
using System.Linq;

namespace Stranka.Services.Entities
{
    public class Izbori
    {
        public long id { get; set; }
        public long vrstaIzboraId { get; set; }
        public string vrstaIzboraNaziv { get; set; }
        public long nivoIzboraId { get; set; }
        public string nivoIzboraNaziv { get; set; }
        public DateTime datumOdrzavanja { get; set; }
    }
}
