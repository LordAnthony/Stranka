using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class GlasoviKandidatBirackoMjestoService
    {
        private Repository<GlasoviKandidatBirackoMjesto> repositoryInstance;

        public GlasoviKandidatBirackoMjestoService()
        {
            repositoryInstance = new Repository<GlasoviKandidatBirackoMjesto>();
        }

        public async Task<int> Add(GlasoviKandidatBirackoMjesto glasoviKandidatBirackoMjesto)
        {
            int glasoviKandidatBirackoMjestoId = await repositoryInstance.Create(glasoviKandidatBirackoMjesto);
            return glasoviKandidatBirackoMjestoId;
        }

        public async Task<GlasoviKandidatBirackoMjesto> Get(int id)
        {
            GlasoviKandidatBirackoMjesto glasoviKandidatBirackoMjesto = await repositoryInstance.Read(x => x.Id == id);
            return glasoviKandidatBirackoMjesto;
        }

        public async Task<List<GlasoviKandidatBirackoMjesto>> GetAll()
        {
            List<GlasoviKandidatBirackoMjesto> glasoviKandidatiBirackaMjesta = await repositoryInstance.GetAll();
            return glasoviKandidatiBirackaMjesta;
        }

        public async Task<int> Update(GlasoviKandidatBirackoMjesto glasoviKandidatBirackoMjesto)
        {
            int glasoviKandidatBirackoMjestoId = await repositoryInstance.Update(glasoviKandidatBirackoMjesto);
            return glasoviKandidatBirackoMjestoId;
        }

        public async Task<int> Delete(GlasoviKandidatBirackoMjesto glasoviKandidatBirackoMjesto)
        {
            int glasoviKandidatBirackoMjestoId = await repositoryInstance.Delete(glasoviKandidatBirackoMjesto);
            return glasoviKandidatBirackoMjestoId;
        }

        public async Task<List<GlasoviKandidatBirackoMjesto>> Search(Func<GlasoviKandidatBirackoMjesto, bool> searchCriteria)
        {
            List<GlasoviKandidatBirackoMjesto> glasoviKandidatiBirackaMjesta = await repositoryInstance.Search(searchCriteria);
            return glasoviKandidatiBirackaMjesta;
        }
    }
}