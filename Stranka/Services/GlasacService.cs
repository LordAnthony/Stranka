using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class GlasacService
    {
        private Repository<Glasac> repositoryInstance;

        public GlasacService()
        {
            repositoryInstance = new Repository<Glasac>();
        }


        public async Task<int> Add(Glasac glasac)
        {
            int glasacId = await repositoryInstance.Create(glasac);
            return glasacId;
        }

        public async Task<Glasac> Get(int id)
        {
            Glasac glasac = await repositoryInstance.Read(x => x.Id == id);
            return glasac;
        }


        public async Task<List<Glasac>> GetAll()
        {
            List<Glasac> glasaci = await repositoryInstance.GetAll();
            return glasaci;
        }

        public async Task<int> Update(Glasac glasac)
        {
            int glasacId = await repositoryInstance.Update(glasac);
            return glasacId;
        }


        public async Task<int> Delete(Glasac glasac)
        {
            int glasacId = await repositoryInstance.Delete(glasac);
            return glasacId;
        }

        public async Task<List<Glasac>> Search(Func<Glasac, bool> searchCriteria)
        {
            List<Glasac> glasaci = await repositoryInstance.Search(searchCriteria);
            return glasaci;
        }
    }
}