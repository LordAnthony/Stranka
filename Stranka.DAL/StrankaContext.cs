using Microsoft.AspNet.Identity.EntityFramework;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stranka.DAL
{
    public class StrankaContext : IdentityDbContext<User>
    {
        public StrankaContext(): base("StrankaContext")
        {

        }

        public static StrankaContext Create()
        {
            return new StrankaContext();
        }

        public DbSet<AdministrativnaJedinica> AdministrativneJedinice { get; set; }
        public DbSet<BirackoMjesto> BirackaMjesta { get; set; }
        public DbSet<ClanskaKarta> ClanskeKarte { get; set; }
        public DbSet<Glasac> Glasaci { get; set; }
        public DbSet<GlasoviKandidatBirackoMjesto> GlasoviKandidatiBirackaMjesta { get; set; }
        public DbSet<GlasoviPolitickiSubjektBirackoMjesto> GlasoviPolitickiSubjektiBirackaMjesta { get; set; }
        public DbSet<Hijerarhija> Hijerarhije { get; set; }
        public DbSet<Izbori> Izbori { get; set; }
        public DbSet<IzboriBirackoMjesto> IzboriBirackaMjesta { get; set; }
        public DbSet<IzboriHijerarhija> IzboriHijerarhije { get; set; }
        public DbSet<IzbornaJedinica> IzborneJedinice { get; set; }
        public DbSet<IzlaznostGlasaca> IzlaznostiGlasaca { get; set; }
        public DbSet<Kandidat> Kandidati { get; set; }
        public DbSet<KandidatIzboriHijerarhija> KandidatiIzboriHijerarhije { get; set; }
        public DbSet<Kanton> Kantoni { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<Lokacija> Lokacije { get; set; }
        public DbSet<NivoIzbora> NivoiIzbora { get; set; }
        public DbSet<Opcina> Opcine { get; set; }
        public DbSet<PolitickiSubjekt> PolitickiSubjekti { get; set; }
        public DbSet<PolitickiSubjektIzboriHijerarhija> PolitickiSubjektiIzboriHijerarhije { get; set; }
        public DbSet<Role> Uloge { get; set; }
        public DbSet<RoleNadleznost> UlogeNadleznosti { get; set; }
        public DbSet<StrucnaSprema> StrucneSpreme { get; set; }
        public DbSet<User> Korisnici { get; set; }
        public DbSet<VrstaIzbora> VrsteIzbora { get; set; }
    }
}
