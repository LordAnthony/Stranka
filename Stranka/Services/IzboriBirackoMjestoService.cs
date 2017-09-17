using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class IzboriBirackoMjestoService
    {
        private Repository<IzboriBirackoMjesto> repositoryInstance;

        public IzboriBirackoMjestoService()
        {
            repositoryInstance = new Repository<IzboriBirackoMjesto>();
        }

        public async Task<int> Add(IzboriBirackoMjesto izboriBirackoMjesto)
        {
            int izboriBirackoMjestoId = await repositoryInstance.Create(izboriBirackoMjesto);
            return izboriBirackoMjestoId;
        }

        public async Task<IzboriBirackoMjesto> Get(int id)
        {
            IzboriBirackoMjesto izboriBirackoMjesto = await repositoryInstance.Read(x => x.Id == id);
            return izboriBirackoMjesto;
        }

        public async Task<List<IzboriBirackoMjesto>> GetAll()
        {
            List<IzboriBirackoMjesto> izboriBirackaMjesta = await repositoryInstance.GetAll();
            return izboriBirackaMjesta;
        }

        public async Task<int> Update(IzboriBirackoMjesto izboriBirackoMjesto)
        {
            int izboriBirackoMjestoId = await repositoryInstance.Update(izboriBirackoMjesto);
            return izboriBirackoMjestoId;
        }

        public async Task<int> Delete(IzboriBirackoMjesto izboriBirackoMjesto)
        {
            int izboriBirackoMjestoId = await repositoryInstance.Delete(izboriBirackoMjesto);
            return izboriBirackoMjestoId;
        }

        public async Task<List<IzboriBirackoMjesto>> Search(Func<IzboriBirackoMjesto, bool> searchCriteria)
        {
            List<IzboriBirackoMjesto> izboriBirackaMjesta = await repositoryInstance.Search(searchCriteria);
            return izboriBirackaMjesta;
        }
    }
}