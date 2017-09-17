using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class IzboriHijerarhijaService
    {
        private Repository<IzboriHijerarhija> repositoryInstance;

        public IzboriHijerarhijaService()
        {
            repositoryInstance = new Repository<IzboriHijerarhija>();
        }

        public async Task<int> Add(IzboriHijerarhija izboriHijerarhija)
        {
            int izboriHijerarhijaId = await repositoryInstance.Create(izboriHijerarhija);
            return izboriHijerarhijaId;
        }

        public async Task<IzboriHijerarhija> Get(int id)
        {
            IzboriHijerarhija izboriHijerarhija = await repositoryInstance.Read(x => x.Id == id);
            return izboriHijerarhija;
        }

        public async Task<List<IzboriHijerarhija>> GetAll()
        {
            List<IzboriHijerarhija> izboriHijerarhije = await repositoryInstance.GetAll();
            return izboriHijerarhije;
        }

        public async Task<int> Update(IzboriHijerarhija izboriHijerarhija)
        {
            int izboriHijerarhijaId = await repositoryInstance.Update(izboriHijerarhija);
            return izboriHijerarhijaId;
        }

        public async Task<int> Delete(IzboriHijerarhija izboriHijerarhija)
        {
            int izboriHijerarhijaId = await repositoryInstance.Delete(izboriHijerarhija);
            return izboriHijerarhijaId;
        }

        public async Task<List<IzboriHijerarhija>> Search(Func<IzboriHijerarhija, bool> searchCriteria)
        {
            List<IzboriHijerarhija> izboriHijerarhije = await repositoryInstance.Search(searchCriteria);
            return izboriHijerarhije;
        }
    }
}