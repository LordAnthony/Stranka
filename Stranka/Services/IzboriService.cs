using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class IzboriService
    {
        private Repository<Izbori> repositoryInstance;

        public IzboriService()
        {
            repositoryInstance = new Repository<Izbori>();
        }

        public async Task<int> Add(Izbori izbori)
        {
            int izboriId = await repositoryInstance.Create(izbori);
            return izboriId;
        }

        public async Task<Izbori> Get(int id)
        {
            Izbori izbori = await repositoryInstance.Read(x => x.Id == id);
            return izbori;
        }

        public async Task<List<Izbori>> GetAll()
        {
            List<Izbori> izbori = await repositoryInstance.GetAll();
            return izbori;
        }

        public async Task<int> Update(Izbori izbori)
        {
            int izboriId = await repositoryInstance.Update(izbori);
            return izboriId;
        }

        public async Task<int> Delete(Izbori izbori)
        {
            int izboriId = await repositoryInstance.Delete(izbori);
            return izboriId;
        }

        public async Task<List<Izbori>> Search(Func<Izbori, bool> searchCriteria)
        {
            List<Izbori> izbori = await repositoryInstance.Search(searchCriteria);
            return izbori;
        }
    }
}