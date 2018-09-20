using System;
using System.Collections.Generic;
using System.Linq;

namespace Stranka.Services.Entities
{
    public class Izbori
    {
        public long Id { get; set; }
        public long VrstaIzboraId { get; set; }
        public string VrstaIzboraNaziv { get; set; }
        public long NivoIzboraId { get; set; }
        public string NivoIzboraNaziv { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
    }
}
