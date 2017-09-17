using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class IzbornaJedinicaService
    {
        private Repository<IzbornaJedinica> repositoryInstance;

        public IzbornaJedinicaService()
        {
            repositoryInstance = new Repository<IzbornaJedinica>();
        }

        public async Task<int> Add(IzbornaJedinica izbornaJedinica)
        {
            int izbornaJedinicaId = await repositoryInstance.Create(izbornaJedinica);
            return izbornaJedinicaId;
        }

        public async Task<IzbornaJedinica> Get(int id)
        {
            IzbornaJedinica izbornaJedinica = await repositoryInstance.Read(x => x.Id == id);
            return izbornaJedinica;
        }

        public async Task<List<IzbornaJedinica>> GetAll()
        {
            List<IzbornaJedinica> izborneJedinice = await repositoryInstance.GetAll();
            return izborneJedinice;
        }

        public async Task<int> Update(IzbornaJedinica izbornaJedinica)
        {
            int izbornaJedinicaId = await repositoryInstance.Update(izbornaJedinica);
            return izbornaJedinicaId;
        }

        public async Task<int> Delete(IzbornaJedinica izbornaJedinica)
        {
            int izbornaJedinicaId = await repositoryInstance.Delete(izbornaJedinica);
            return izbornaJedinicaId;
        }

        public async Task<List<IzbornaJedinica>> Search(Func<IzbornaJedinica, bool> searchCriteria)
        {
            List<IzbornaJedinica> izborneJedinice = await repositoryInstance.Search(searchCriteria);
            return izborneJedinice;
        }
    }
}