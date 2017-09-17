using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class VrstaIzboraService
    {
        private Repository<VrstaIzbora> repositoryInstance;

        public VrstaIzboraService()
        {
            repositoryInstance = new Repository<VrstaIzbora>();
        }

        public async Task<int> Add(VrstaIzbora vrstaIzbora)
        {
            int vrstaIzboraId = await repositoryInstance.Create(vrstaIzbora);
            return vrstaIzboraId;
        }

        public async Task<VrstaIzbora> Get(int id)
        {
            VrstaIzbora vrstaIzbora = await repositoryInstance.Read(x => x.Id == id);
            return vrstaIzbora;
        }

        public async Task<List<VrstaIzbora>> GetAll()
        {
            List<VrstaIzbora> vrsteIzbora = await repositoryInstance.GetAll();
            return vrsteIzbora;
        }

        public async Task<int> Update(VrstaIzbora vrstaIzbora)
        {
            int vrstaIzboraId = await repositoryInstance.Update(vrstaIzbora);
            return vrstaIzboraId;
        }

        public async Task<int> Delete(VrstaIzbora vrstaIzbora)
        {
            int vrstaIzboraId = await repositoryInstance.Delete(vrstaIzbora);
            return vrstaIzboraId;
        }

        public async Task<List<VrstaIzbora>> Search(Func<VrstaIzbora, bool> searchCriteria)
        {
            List<VrstaIzbora> vrsteIzbora = await repositoryInstance.Search(searchCriteria);
            return vrsteIzbora;
        }
    }
}