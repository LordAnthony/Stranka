

namespace Stranka.Services.Entities
{
    public class GlasoviKandidat
    {
        public long Id { get; set; }
        public long KandidatId { get; set; }
        public string KandidatImePrezime { get; set; }
        public long IzboriId { get; set; }    
        public long BirackoMjestoId { get; set; }
        public string BirackoMjestoSifra { get; set; }
        public string BirackoMjestoNaziv { get; set; }
        public int BrojGlasova { get; set; }
    }
}
