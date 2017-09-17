using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class KandidatService
    {
        private Repository<Kandidat> repositoryInstance;

        public KandidatService()
        {
            repositoryInstance = new Repository<Kandidat>();
        }


        public async Task<int> Add(Kandidat kandidat)
        {
            int kandidatId = await repositoryInstance.Create(kandidat);
            return kandidatId;
        }

        public async Task<Kandidat> Get(int id)
        {
            Kandidat kandidat = await repositoryInstance.Read(x => x.Id == id);
            return kandidat;
        }


        public async Task<List<Kandidat>> GetAll()
        {
            List<Kandidat> kandidati = await repositoryInstance.GetAll();
            return kandidati;
        }

        public async Task<int> Update(Kandidat kandidat)
        {
            int kandidatId = await repositoryInstance.Update(kandidat);
            return kandidatId;
        }


        public async Task<int> Delete(Kandidat kandidat)
        {
            int kandidatId = await repositoryInstance.Delete(kandidat);
            return kandidatId;
        }

        public async Task<List<Kandidat>> Search(Func<Kandidat, bool> searchCriteria)
        {
            List<Kandidat> kandidati = await repositoryInstance.Search(searchCriteria);
            return kandidati;
        }
    }
}