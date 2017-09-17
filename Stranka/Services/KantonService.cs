using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class KantonService
    {
        private Repository<Kanton> repositoryInstance;

        public KantonService()
        {
            repositoryInstance = new Repository<Kanton>();
        }


        public async Task<int> Add(Kanton kanton)
        {
            int kantonId = await repositoryInstance.Create(kanton);
            return kantonId;
        }

        public async Task<Kanton> Get(int id)
        {
            Kanton kanton = await repositoryInstance.Read(x => x.Id == id);
            return kanton;
        }


        public async Task<List<Kanton>> GetAll()
        {
            List<Kanton> kantoni = await repositoryInstance.GetAll();
            return kantoni;
        }

        public async Task<int> Update(Kanton kanton)
        {
            int kantonId = await repositoryInstance.Update(kanton);
            return kantonId;
        }


        public async Task<int> Delete(Kanton kanton)
        {
            int kantonId = await repositoryInstance.Delete(kanton);
            return kantonId;
        }

        public async Task<List<Kanton>> Search(Func<Kanton, bool> searchCriteria)
        {
            List<Kanton> kantoni = await repositoryInstance.Search(searchCriteria);
            return kantoni;
        }
    }
}