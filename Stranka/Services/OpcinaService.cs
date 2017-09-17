using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class OpcinaService
    {
        private Repository<Opcina> repositoryInstance;

        public OpcinaService()
        {
            repositoryInstance = new Repository<Opcina>();
        }

        public async Task<int> Add(Opcina opcina)
        {
            int opcinaId = await repositoryInstance.Create(opcina);
            return opcinaId;
        }

        public async Task<Opcina> Get(int id)
        {
            Opcina opcina = await repositoryInstance.Read(x => x.Id == id);
            return opcina;
        }

        public async Task<List<Opcina>> GetAll()
        {
            List<Opcina> opcine = await repositoryInstance.GetAll();
            return opcine;
        }

        public async Task<int> Update(Opcina opcina)
        {
            int opcinaId = await repositoryInstance.Update(opcina);
            return opcinaId;
        }

        public async Task<int> Delete(Opcina opcina)
        {
            int opcinaId = await repositoryInstance.Delete(opcina);
            return opcinaId;
        }

        public async Task<List<Opcina>> Search(Func<Opcina, bool> searchCriteria)
        {
            List<Opcina> opcine = await repositoryInstance.Search(searchCriteria);
            return opcine;
        }
    }
}