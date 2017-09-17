using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class RoleNadleznost
    {
        public int Id { get; set; }
        public int UlogaId { get; set; }
        public int? IzbornaJedinicaId { get; set; }
        public int? LokacijaId { get; set; }
        public int? BirackoMjestoId { get; set; }

        public virtual Role Uloga { get; set; }
        public virtual IzbornaJedinica IzbornaJedinica { get; set; }
        public virtual Lokacija Lokacija { get; set; }
        public virtual BirackoMjesto BirackoMjesto { get; set; }
    }
}
