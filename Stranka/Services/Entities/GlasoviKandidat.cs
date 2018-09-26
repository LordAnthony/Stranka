

namespace Stranka.Services.Entities
{
    public class GlasoviKandidat
    {
        public long id { get; set; }
        public long kandidatId { get; set; }
        public string kandidatImePrezime { get; set; }
        public long izboriId { get; set; }    
        public long birackoMjestoId { get; set; }
        public string birackoMjestoSifra { get; set; }
        public string birackoMjestoNaziv { get; set; }
        public int brojGlasova { get; set; }
    }
}
