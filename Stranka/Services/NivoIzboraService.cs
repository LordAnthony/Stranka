using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class NivoIzboraService
    {
        private Repository<NivoIzbora> repositoryInstance;

        public NivoIzboraService()
        {
            repositoryInstance = new Repository<NivoIzbora>();
        }

        public async Task<int> Add(NivoIzbora nivoIzbora)
        {
            int nivoIzboraId = await repositoryInstance.Create(nivoIzbora);
            return nivoIzboraId;
        }

        public async Task<NivoIzbora> Get(int id)
        {
            NivoIzbora nivoIzbora = await repositoryInstance.Read(x => x.Id == id);
            return nivoIzbora;
        }

        public async Task<List<NivoIzbora>> GetAll()
        {
            List<NivoIzbora> nivoiIzbora = await repositoryInstance.GetAll();
            return nivoiIzbora;
        }

        public async Task<int> Update(NivoIzbora nivoIzbora)
        {
            int nivoIzboraId = await repositoryInstance.Update(nivoIzbora);
            return nivoIzboraId;
        }

        public async Task<int> Delete(NivoIzbora nivoIzbora)
        {
            int nivoIzboraId = await repositoryInstance.Delete(nivoIzbora);
            return nivoIzboraId;
        }

        public async Task<List<NivoIzbora>> Search(Func<NivoIzbora, bool> searchCriteria)
        {
            List<NivoIzbora> nivoiIzbora = await repositoryInstance.Search(searchCriteria);
            return nivoiIzbora;
        }
    }
}