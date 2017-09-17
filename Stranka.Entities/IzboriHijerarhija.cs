using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class IzboriHijerarhija
    {
        public int Id { get; set; }
        public int IzboriId { get; set; }
        public int HijerarhijaId { get; set; }

        public virtual Izbori Izbori { get; set; }
        public virtual Hijerarhija Hijerarhija { get; set; }
        public virtual List<KandidatIzboriHijerarhija> KandidatiIzboriHijerarhije { get; set; }
        public virtual List<PolitickiSubjektIzboriHijerarhija> PolitickiSubjektIzboriHijerarhije { get; set; }
    }
}
