using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class LokacijaService
    {
        private Repository<Lokacija> repositoryInstance;

        public LokacijaService()
        {
            repositoryInstance = new Repository<Lokacija>();
        }

        public async Task<int> Add(Lokacija lokacija)
        {
            int lokacijaId = await repositoryInstance.Create(lokacija);
            return lokacijaId;
        }

        public async Task<Lokacija> Get(int id)
        {
            Lokacija lokacija = await repositoryInstance.Read(x => x.Id == id);
            return lokacija;
        }

        public async Task<List<Lokacija>> GetAll()
        {
            List<Lokacija> lokacije = await repositoryInstance.GetAll();
            return lokacije;
        }

        public async Task<int> Update(Lokacija lokacija)
        {
            int lokacijaId = await repositoryInstance.Update(lokacija);
            return lokacijaId;
        }

        public async Task<int> Delete(Lokacija lokacija)
        {
            int lokacijaId = await repositoryInstance.Delete(lokacija);
            return lokacijaId;
        }

        public async Task<List<Lokacija>> Search(Func<Lokacija, bool> searchCriteria)
        {
            List<Lokacija> lokacije = await repositoryInstance.Search(searchCriteria);
            return lokacije;
        }
    }
}