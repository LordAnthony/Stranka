using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class IzbornaJedinica
    {
        public int Id { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }

        public virtual List<Hijerarhija> HijerarhijeDijete { get; set; }
        public virtual List<Hijerarhija> HijerarhijeRoditelj { get; set; }
        public virtual List<Lokacija> Lokacije { get; set; }
        public virtual List<RoleNadleznost> UlogeNadleznosti { get; set; }
    }
}
