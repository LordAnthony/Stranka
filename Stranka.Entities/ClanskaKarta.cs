using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class ClanskaKarta
    {
        public int Id { get; set; }
        public int GlasacId { get; set; }
        public int? StrucnaSpremaId { get; set; }
        public string Zanimanje { get; set; }
        public DateTime DatumPristupanja { get; set; }

        public virtual Glasac Glasac { get; set; }
        public virtual StrucnaSprema StrucnaSprema { get; set; }
    }
}
