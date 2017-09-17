using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class PolitickiSubjektService
    {
        private Repository<PolitickiSubjekt> repositoryInstance;

        public PolitickiSubjektService()
        {
            repositoryInstance = new Repository<PolitickiSubjekt>();
        }

        public async Task<int> Add(PolitickiSubjekt politickiSubjekt)
        {
            int politickiSubjektId = await repositoryInstance.Create(politickiSubjekt);
            return politickiSubjektId;
        }

        public async Task<PolitickiSubjekt> Get(int id)
        {
            PolitickiSubjekt politickiSubjekt = await repositoryInstance.Read(x => x.Id == id);
            return politickiSubjekt;
        }

        public async Task<List<PolitickiSubjekt>> GetAll()
        {
            List<PolitickiSubjekt> politickiSubjekti = await repositoryInstance.GetAll();
            return politickiSubjekti;
        }

        public async Task<int> Update(PolitickiSubjekt politickiSubjekt)
        {
            int politickiSubjektId = await repositoryInstance.Update(politickiSubjekt);
            return politickiSubjektId;
        }

        public async Task<int> Delete(PolitickiSubjekt politickiSubjekt)
        {
            int politickiSubjektId = await repositoryInstance.Delete(politickiSubjekt);
            return politickiSubjektId;
        }

        public async Task<List<PolitickiSubjekt>> Search(Func<PolitickiSubjekt, bool> searchCriteria)
        {
            List<PolitickiSubjekt> politickiSubjekti = await repositoryInstance.Search(searchCriteria);
            return politickiSubjekti;
        }
    }
}