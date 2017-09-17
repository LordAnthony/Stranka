using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class StrucnaSpremaService
    {
        private Repository<StrucnaSprema> repositoryInstance;

        public StrucnaSpremaService()
        {
            repositoryInstance = new Repository<StrucnaSprema>();
        }

        public async Task<int> Add(StrucnaSprema strucnaSprema)
        {
            int strucnaSpremaId = await repositoryInstance.Create(strucnaSprema);
            return strucnaSpremaId;
        }

        public async Task<StrucnaSprema> Get(int id)
        {
            StrucnaSprema strucnaSprema = await repositoryInstance.Read(x => x.Id == id);
            return strucnaSprema;
        }

        public async Task<List<StrucnaSprema>> GetAll()
        {
            List<StrucnaSprema> strucneSpreme = await repositoryInstance.GetAll();
            return strucneSpreme;
        }

        public async Task<int> Update(StrucnaSprema strucnaSprema)
        {
            int strucnaSpremaId = await repositoryInstance.Update(strucnaSprema);
            return strucnaSpremaId;
        }

        public async Task<int> Delete(StrucnaSprema strucnaSprema)
        {
            int strucnaSpremaId = await repositoryInstance.Delete(strucnaSprema);
            return strucnaSpremaId;
        }

        public async Task<List<StrucnaSprema>> Search(Func<StrucnaSprema, bool> searchCriteria)
        {
            List<StrucnaSprema> strucneSpreme = await repositoryInstance.Search(searchCriteria);
            return strucneSpreme;
        }
    }
}