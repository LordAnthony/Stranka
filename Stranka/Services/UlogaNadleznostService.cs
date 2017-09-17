using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class UlogaNadleznostService
    {
        private Repository<RoleNadleznost> repositoryInstance;

        public UlogaNadleznostService()
        {
            repositoryInstance = new Repository<RoleNadleznost>();
        }

        public async Task<int> Add(RoleNadleznost ulogaNadleznost)
        {
            int ulogaNadleznostId = await repositoryInstance.Create(ulogaNadleznost);
            return ulogaNadleznostId;
        }

        public async Task<RoleNadleznost> Get(int id)
        {
            RoleNadleznost ulogaNadleznost = await repositoryInstance.Read(x => x.Id == id);
            return ulogaNadleznost;
        }

        public async Task<List<RoleNadleznost>> GetAll()
        {
            List<RoleNadleznost> ulogeNadleznosti = await repositoryInstance.GetAll();
            return ulogeNadleznosti;
        }

        public async Task<int> Update(RoleNadleznost ulogaNadleznost)
        {
            int ulogaNadleznostId = await repositoryInstance.Update(ulogaNadleznost);
            return ulogaNadleznostId;
        }

        public async Task<int> Delete(RoleNadleznost ulogaNadleznost)
        {
            int ulogaNadleznostId = await repositoryInstance.Delete(ulogaNadleznost);
            return ulogaNadleznostId;
        }

        public async Task<List<RoleNadleznost>> Search(Func<RoleNadleznost, bool> searchCriteria)
        {
            List<RoleNadleznost> ulogeNadleznosti = await repositoryInstance.Search(searchCriteria);
            return ulogeNadleznosti;
        }
    }
}