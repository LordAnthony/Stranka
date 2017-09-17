using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class Glasac
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public int BirackoMjestoId { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Napomena { get; set; }
        public byte[] Slika { get; set; }
        public bool Clan { get; set; }
        public bool Aktivan { get; set; }

        public virtual BirackoMjesto BirackoMjesto { get; set; }
        public virtual ClanskaKarta ClanskaKarta { get; set; }
        public virtual List<IzlaznostGlasaca> IzlaznostiGlasaca { get; set; }
    }
}
