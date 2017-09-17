using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class Hijerarhija
    {
        public int Id { get; set; }
        public int IzbornaJedinicaDijeteId { get; set; }
        public int IzbornaJedinicaRoditeljId { get; set; }
        public int KategorijaId { get; set; }

        public virtual IzbornaJedinica IzbornaJedinicaDijete { get; set; }
        public virtual IzbornaJedinica IzbornaJedinicaRoditelj { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public virtual List<IzboriHijerarhija> IzboriHijerarhije { get; set; }
    }
}
