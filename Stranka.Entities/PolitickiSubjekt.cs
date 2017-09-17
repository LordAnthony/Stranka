using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.Entities
{
    public class PolitickiSubjekt
    {
        public int Id { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string Telefon { get; set; }

        public virtual List<PolitickiSubjektIzboriHijerarhija> PolitickiSubjektiIzboriHijerarhije { get; set; }
    }
}
