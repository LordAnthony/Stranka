using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class HijerarhijaService
    {
        private Repository<Hijerarhija> repositoryInstance;

        public HijerarhijaService()
        {
            repositoryInstance = new Repository<Hijerarhija>();
        }

        public async Task<int> Add(Hijerarhija hijerarhija)
        {
            int hijerarhijaId = await repositoryInstance.Create(hijerarhija);
            return hijerarhijaId;
        }

        public async Task<Hijerarhija> Get(int id)
        {
            Hijerarhija hijerarhija = await repositoryInstance.Read(x => x.Id == id);
            return hijerarhija;
        }

        public async Task<List<Hijerarhija>> GetAll()
        {
            List<Hijerarhija> hijerarhije = await repositoryInstance.GetAll();
            return hijerarhije;
        }

        public async Task<int> Update(Hijerarhija hijerarhija)
        {
            int hijerarhijaId = await repositoryInstance.Update(hijerarhija);
            return hijerarhijaId;
        }

        public async Task<int> Delete(Hijerarhija hijerarhija)
        {
            int hijerarhijaId = await repositoryInstance.Delete(hijerarhija);
            return hijerarhijaId;
        }

        public async Task<List<Hijerarhija>> Search(Func<Hijerarhija, bool> searchCriteria)
        {
            List<Hijerarhija> hijerarhije = await repositoryInstance.Search(searchCriteria);
            return hijerarhije;
        }
    }
}