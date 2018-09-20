

namespace Stranka.Services.Entities
{
    public class GlasoviPolitickiSubjekt
    {
        public long Id { get; set; }
        public long PolitickiSubjektId { get; set; }
        public string PolitickiSubjektSifra { get; set; }
        public string PolitickiSubjektNaziv{ get; set; }
        public long IzboriId { get; set; }    
        public long IzbornaJedinicaId { get; set; }
        public long KategorijaId { get; set; }
        public long KategorijaNaziv { get; set; }
        public long BirackoMjestoId { get; set; }
        public string BirackoMjestoSifra { get; set; }
        public string BirackoMjestoNaziv { get; set; }
        public int BrojGlasova { get; set; }
    }
}
