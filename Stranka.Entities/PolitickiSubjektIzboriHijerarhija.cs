using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class PolitickiSubjektIzboriHijerarhija
    {
        public long Id { get; set; }
        public long PolitickiSubjektId { get; set; }
        public long IzboriHijerarhijaId { get; set; }
        public int RedniBroj { get; set; }
        public int UkupnoGlasova { get; set; }

        public virtual PolitickiSubjekt PolitickiSubjekt { get; set; }
        public virtual IzboriHijerarhija IzboriHijerarhija { get; set; }
        public virtual List<GlasoviPolitickiSubjektBirackoMjesto> GlasoviPolitickiSubjektiBirackaMjesta { get; set; }
    }
}
