using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class KandidatIzboriHijerarhijaService
    {
        private Repository<KandidatIzboriHijerarhija> repositoryInstance;

        public KandidatIzboriHijerarhijaService()
        {
            repositoryInstance = new Repository<KandidatIzboriHijerarhija>();
        }

        public async Task<int> Add(KandidatIzboriHijerarhija kandidatIzboriHijerarhija)
        {
            int kandidatIzboriHijerarhijaId = await repositoryInstance.Create(kandidatIzboriHijerarhija);
            return kandidatIzboriHijerarhijaId;
        }

        public async Task<KandidatIzboriHijerarhija> Get(int id)
        {
            KandidatIzboriHijerarhija kandidatIzboriHijerarhija = await repositoryInstance.Read(x => x.Id == id);
            return kandidatIzboriHijerarhija;
        }

        public async Task<List<KandidatIzboriHijerarhija>> GetAll()
        {
            List<KandidatIzboriHijerarhija> kandidatiIzboriHijerarhije = await repositoryInstance.GetAll();
            return kandidatiIzboriHijerarhije;
        }

        public async Task<int> Update(KandidatIzboriHijerarhija kandidatIzboriHijerarhija)
        {
            int kandidatIzboriHijerarhijaId = await repositoryInstance.Update(kandidatIzboriHijerarhija);
            return kandidatIzboriHijerarhijaId;
        }

        public async Task<int> Delete(KandidatIzboriHijerarhija kandidatIzboriHijerarhija)
        {
            int kandidatIzboriHijerarhijaId = await repositoryInstance.Delete(kandidatIzboriHijerarhija);
            return kandidatIzboriHijerarhijaId;
        }

        public async Task<List<KandidatIzboriHijerarhija>> Search(Func<KandidatIzboriHijerarhija, bool> searchCriteria)
        {
            List<KandidatIzboriHijerarhija> kandidatiIzboriHijerarhije = await repositoryInstance.Search(searchCriteria);
            return kandidatiIzboriHijerarhije;
        }
    }
}