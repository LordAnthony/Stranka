using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class BirackoMjesto
    {
        public int Id { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public int LokacijaId { get; set; }
        public bool Aktivno { get; set; }

        public Lokacija Lokacija { get; set; }
        public List<Glasac> Glasaci { get; set; }
        public List<GlasoviKandidatBirackoMjesto> GlasoviKandidatiBirackaMjesta { get; set; }
        public List<GlasoviPolitickiSubjektBirackoMjesto> GlasoviPolitickiSubjektiBirackaMjesta { get; set; }
        public List<IzboriBirackoMjesto> IzboriBirackaMjesta { get; set; }
        public virtual List<RoleNadleznost> UlogeNadleznosti { get; set; }
    }
}
