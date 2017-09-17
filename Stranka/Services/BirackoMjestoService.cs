using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class BirackoMjestoService
    {
        private Repository<BirackoMjesto> repositoryInstance;

        public BirackoMjestoService()
        {
            repositoryInstance = new Repository<BirackoMjesto>();
        }

        public async Task<int> Add(BirackoMjesto birackoMjesto)
        {
            int birackoMjestoId = await repositoryInstance.Create(birackoMjesto);
            return birackoMjestoId;
        }

        public async Task<BirackoMjesto> Get(int id)
        {
            BirackoMjesto birackoMjesto = await repositoryInstance.Read(x => x.Id == id);
            return birackoMjesto;
        }

        public async Task<List<BirackoMjesto>> GetAll()
        {
            List<BirackoMjesto> birackaMjesta = await repositoryInstance.GetAll();
            return birackaMjesta;
        }

        public async Task<int> Update(BirackoMjesto clanskaKarta)
        {
            int birackoMjestoId = await repositoryInstance.Update(clanskaKarta);
            return birackoMjestoId;
        }

        public async Task<int> Delete(BirackoMjesto clanskaKarta)
        {
            int birackoMjestoId = await repositoryInstance.Delete(clanskaKarta);
            return birackoMjestoId;
        }

        public async Task<List<BirackoMjesto>> Search(Func<BirackoMjesto, bool> searchCriteria)
        {
            List<BirackoMjesto> birackaMjesta = await repositoryInstance.Search(searchCriteria);
            return birackaMjesta;
        }
    }
}