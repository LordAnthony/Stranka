using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class KandidatIzboriHijerarhija
    {
        public int Id { get; set; }
        public int KandidatId { get; set; }
        public int IzboriHijerarhijaId { get; set; }
        public int RedniBroj { get; set; }
        public int UkupnoGlasova { get; set; }

        public virtual Kandidat Kandidat { get; set; }
        public virtual IzboriHijerarhija IzboriHijerarhija { get; set; }
        public virtual List<GlasoviKandidatBirackoMjesto> GlasoviKandidatiBirackaMjesta { get; set; }
    }
}
