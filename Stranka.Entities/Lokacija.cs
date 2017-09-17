using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class Lokacija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int IzbornaJedinicaId { get; set; }
        public bool Aktivna { get; set; }

        public virtual IzbornaJedinica IzbornaJedinica { get; set; }
        public virtual List<BirackoMjesto> BirackaMjesta { get; set; }
        public virtual List<RoleNadleznost> UlogeNadleznosti { get; set; }
    }
}
