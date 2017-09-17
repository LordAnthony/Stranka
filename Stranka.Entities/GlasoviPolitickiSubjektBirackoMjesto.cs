using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class GlasoviPolitickiSubjektBirackoMjesto
    {
        public int Id { get; set; }
        public int PolitickiSubjektIzboriHijerarhijaId { get; set; }
        public int BirackoMjestoId { get; set; }
        public int BrojGlasova { get; set; }

        public virtual PolitickiSubjektIzboriHijerarhija PolitickiSubjektIzboriHijerarhija { get; set; }
        public virtual BirackoMjesto BirackoMjesto { get; set; }     
    }
}
