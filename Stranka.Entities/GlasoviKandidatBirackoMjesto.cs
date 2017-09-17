using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class GlasoviKandidatBirackoMjesto
    {
        public int Id { get; set; }
        public int KandidatIzboriHijerarhijaId { get; set; }
        public int BirackoMjestoId { get; set; }
        public int BrojGlasova { get; set; }

        public virtual KandidatIzboriHijerarhija KandidatIzboriHijerarhija { get; set; }
        public virtual BirackoMjesto BirackoMjesto { get; set; }        
    }
}
