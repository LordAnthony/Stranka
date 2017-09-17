using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class ClanskaKartaService
    {
        private Repository<ClanskaKarta> repositoryInstance;

        public ClanskaKartaService()
        {
            repositoryInstance = new Repository<ClanskaKarta>();
        }

        public async Task<int> Add(ClanskaKarta clanskaKarta)
        {
            int clanskaKartaId = await repositoryInstance.Create(clanskaKarta);
            return clanskaKartaId;
        }

        public async Task<ClanskaKarta> Get(int id)
        {
            ClanskaKarta clanskaKarta = await repositoryInstance.Read(x => x.Id == id);
            return clanskaKarta;
        }

        public async Task<List<ClanskaKarta>> GetAll()
        {
            List<ClanskaKarta> clanskeKarte = await repositoryInstance.GetAll();
            return clanskeKarte;
        }

        public async Task<int> Update(ClanskaKarta clanskaKarta)
        {
            int clanskaKartaId = await repositoryInstance.Update(clanskaKarta);
            return clanskaKartaId;
        }

        public async Task<int> Delete(ClanskaKarta clanskaKarta)
        {
            int clanskaKartaId = await repositoryInstance.Delete(clanskaKarta);
            return clanskaKartaId;
        }

        public async Task<List<ClanskaKarta>> Search(Func<ClanskaKarta, bool> searchCriteria)
        {
            List<ClanskaKarta> clanskeKarte = await repositoryInstance.Search(searchCriteria);
            return clanskeKarte;
        }
    }
}