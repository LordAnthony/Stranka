using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class KategorijaService
    {
        private Repository<Kategorija> repositoryInstance;

        public KategorijaService()
        {
            repositoryInstance = new Repository<Kategorija>();
        }


        public async Task<int> Add(Kategorija kategorija)
        {
            int kategorijaId = await repositoryInstance.Create(kategorija);
            return kategorijaId;
        }

        public async Task<Kategorija> Get(int id)
        {
            Kategorija kategorija = await repositoryInstance.Read(x => x.Id == id);
            return kategorija;
        }


        public async Task<List<Kategorija>> GetAll()
        {
            List<Kategorija> kategorije = await repositoryInstance.GetAll();
            return kategorije;
        }

        public async Task<int> Update(Kategorija kategorija)
        {
            int kategorijaId = await repositoryInstance.Update(kategorija);
            return kategorijaId;
        }


        public async Task<int> Delete(Kategorija kategorija)
        {
            int kategorijaId = await repositoryInstance.Delete(kategorija);
            return kategorijaId;
        }

        public async Task<List<Kategorija>> Search(Func<Kategorija, bool> searchCriteria)
        {
            List<Kategorija> kategorije = await repositoryInstance.Search(searchCriteria);
            return kategorije;
        }
    }
}