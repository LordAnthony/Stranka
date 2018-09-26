

namespace Stranka.Services.Entities
{
    public class GlasoviPolitickiSubjekt
    {
        public long id { get; set; }
        public long politickiSubjektId { get; set; }
        public string politickiSubjektSifra { get; set; }
        public string politickiSubjektNaziv{ get; set; }
        public long izboriId { get; set; }    
        public long izbornaJedinicaId { get; set; }
        public long kategorijaId { get; set; }
        public long kategorijaNaziv { get; set; }
        public long birackoMjestoId { get; set; }
        public string birackoMjestoSifra { get; set; }
        public string birackoMjestoNaziv { get; set; }
        public int brojGlasova { get; set; }
    }
}
