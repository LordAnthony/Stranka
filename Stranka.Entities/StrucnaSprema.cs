using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class StrucnaSprema
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Napomena { get; set; }

        public virtual List<ClanskaKarta> ClanskeKarte { get; set; }
    }
}
