using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class AdministrativnaJedinicaService
    {
        private Repository<AdministrativnaJedinica> repositoryInstance;

        public AdministrativnaJedinicaService()
        {
            repositoryInstance = new Repository<AdministrativnaJedinica>();
        }

        public async Task<int> Add(AdministrativnaJedinica administrativnaJedinica)
        {
            int administrativnaJedinicaId = await repositoryInstance.Create(administrativnaJedinica);
            return administrativnaJedinicaId;
        }

        public async Task<AdministrativnaJedinica> Get(int id)
        {
            AdministrativnaJedinica administrativnaJedinica = await repositoryInstance.Read(x => x.Id == id);
            return administrativnaJedinica;
        }

        public async Task<List<AdministrativnaJedinica>> GetAll()
        {
            List<AdministrativnaJedinica> administrativneJedinice = await repositoryInstance.GetAll();
            return administrativneJedinice;
        }

        public async Task<int> Update(AdministrativnaJedinica administrativnaJedinica)
        {
            int administrativnaJedinicaId = await repositoryInstance.Update(administrativnaJedinica);
            return administrativnaJedinicaId;
        }

        public async Task<int> Delete(AdministrativnaJedinica administrativnaJedinica)
        {
            int administrativnaJedinicaId = await repositoryInstance.Delete(administrativnaJedinica);
            return administrativnaJedinicaId;
        }

        public async Task<List<AdministrativnaJedinica>> Search(Func<AdministrativnaJedinica, bool> searchCriteria)
        {
            List<AdministrativnaJedinica> administrativneJedinice = await repositoryInstance.Search(searchCriteria);
            return administrativneJedinice;
        }
    }
}