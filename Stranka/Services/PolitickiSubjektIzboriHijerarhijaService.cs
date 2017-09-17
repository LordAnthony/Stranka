using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class PolitickiSubjektIzboriHijerarhijaService
    {
        private Repository<PolitickiSubjektIzboriHijerarhija> repositoryInstance;

        public PolitickiSubjektIzboriHijerarhijaService()
        {
            repositoryInstance = new Repository<PolitickiSubjektIzboriHijerarhija>();
        }

        public async Task<int> Add(PolitickiSubjektIzboriHijerarhija politickiSubjektIzboriHijerarhija)
        {
            int politickiSubjektIzboriHijerarhijaId = await repositoryInstance.Create(politickiSubjektIzboriHijerarhija);
            return politickiSubjektIzboriHijerarhijaId;
        }

        public async Task<PolitickiSubjektIzboriHijerarhija> Get(int id)
        {
            PolitickiSubjektIzboriHijerarhija politickiSubjektIzboriHijerarhija = await repositoryInstance.Read(x => x.Id == id);
            return politickiSubjektIzboriHijerarhija;
        }

        public async Task<List<PolitickiSubjektIzboriHijerarhija>> GetAll()
        {
            List<PolitickiSubjektIzboriHijerarhija> politickiSubjektiIzboriHijerarhije = await repositoryInstance.GetAll();
            return politickiSubjektiIzboriHijerarhije;
        }

        public async Task<int> Update(PolitickiSubjektIzboriHijerarhija politickiSubjektIzboriHijerarhija)
        {
            int politickiSubjektIzboriHijerarhijaId = await repositoryInstance.Update(politickiSubjektIzboriHijerarhija);
            return politickiSubjektIzboriHijerarhijaId;
        }

        public async Task<int> Delete(PolitickiSubjektIzboriHijerarhija politickiSubjektIzboriHijerarhija)
        {
            int politickiSubjektIzboriHijerarhijaId = await repositoryInstance.Delete(politickiSubjektIzboriHijerarhija);
            return politickiSubjektIzboriHijerarhijaId;
        }

        public async Task<List<PolitickiSubjektIzboriHijerarhija>> Search(Func<PolitickiSubjektIzboriHijerarhija, bool> searchCriteria)
        {
            List<PolitickiSubjektIzboriHijerarhija> politickiSubjektiIzboriHijerarhije = await repositoryInstance.Search(searchCriteria);
            return politickiSubjektiIzboriHijerarhije;
        }
    }
}