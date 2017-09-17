using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class UlogaService
    {
        private Repository<Role> repositoryInstance;

        public UlogaService()
        {
            repositoryInstance = new Repository<Role>();
        }

        public async Task<int> Add(Role uloga)
        {
            int ulogaId = await repositoryInstance.Create(uloga);
            return ulogaId;
        }

        public async Task<Role> Get(string id)
        {
            Role uloga = await repositoryInstance.Read(x => x.Id == id);
            return uloga;
        }

        public async Task<List<Role>> GetAll()
        {
            List<Role> uloge = await repositoryInstance.GetAll();
            return uloge;
        }

        public async Task<int> Update(Role uloga)
        {
            int ulogaId = await repositoryInstance.Update(uloga);
            return ulogaId;
        }

        public async Task<int> Delete(Role uloga)
        {
            int ulogaId = await repositoryInstance.Delete(uloga);
            return ulogaId;
        }

        public async Task<List<Role>> Search(Func<Role, bool> searchCriteria)
        {
            List<Role> uloge = await repositoryInstance.Search(searchCriteria);
            return uloge;
        }
    }
}