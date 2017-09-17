using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class IzlaznostGlasacaService
    {
        private Repository<IzlaznostGlasaca> repositoryInstance;

        public IzlaznostGlasacaService()
        {
            repositoryInstance = new Repository<IzlaznostGlasaca>();
        }

        public async Task<int> Add(IzlaznostGlasaca izlaznostGlasaca)
        {
            int izlaznostGlasacaId = await repositoryInstance.Create(izlaznostGlasaca);
            return izlaznostGlasacaId;
        }

        public async Task<IzlaznostGlasaca> Get(int id)
        {
            IzlaznostGlasaca izlaznostGlasaca = await repositoryInstance.Read(x => x.Id == id);
            return izlaznostGlasaca;
        }

        public async Task<List<IzlaznostGlasaca>> GetAll()
        {
            List<IzlaznostGlasaca> izlaznostiGlasaca = await repositoryInstance.GetAll();
            return izlaznostiGlasaca;
        }

        public async Task<int> Update(IzlaznostGlasaca izlaznostGlasaca)
        {
            int izlaznostGlasacaId = await repositoryInstance.Update(izlaznostGlasaca);
            return izlaznostGlasacaId;
        }

        public async Task<int> Delete(IzlaznostGlasaca izlaznostGlasaca)
        {
            int izlaznostGlasacaId = await repositoryInstance.Delete(izlaznostGlasaca);
            return izlaznostGlasacaId;
        }

        public async Task<List<IzlaznostGlasaca>> Search(Func<IzlaznostGlasaca, bool> searchCriteria)
        {
            List<IzlaznostGlasaca> izlaznostiGlasaca = await repositoryInstance.Search(searchCriteria);
            return izlaznostiGlasaca;
        }
    }
}