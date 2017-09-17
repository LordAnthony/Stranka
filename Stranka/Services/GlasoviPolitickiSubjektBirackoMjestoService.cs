using Stranka.DAL;
using Stranka.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Stranka.Services
{
    public class GlasoviPolitickiSubjektBirackoMjestoService
    {
        private Repository<GlasoviPolitickiSubjektBirackoMjesto> repositoryInstance;

        public GlasoviPolitickiSubjektBirackoMjestoService()
        {
            repositoryInstance = new Repository<GlasoviPolitickiSubjektBirackoMjesto>();
        }


        public async Task<int> Add(GlasoviPolitickiSubjektBirackoMjesto glasoviPolitickiSubjektBirackoMjesto)
        {
            int glasoviPolitickiSubjektBirackoMjestoId = await repositoryInstance.Create(glasoviPolitickiSubjektBirackoMjesto);
            return glasoviPolitickiSubjektBirackoMjestoId;
        }

        public async Task<GlasoviPolitickiSubjektBirackoMjesto> Get(int id)
        {
            GlasoviPolitickiSubjektBirackoMjesto glasoviPolitickiSubjektBirackoMjesto = await repositoryInstance.Read(x => x.Id == id);
            return glasoviPolitickiSubjektBirackoMjesto;
        }

        public async Task<List<GlasoviPolitickiSubjektBirackoMjesto>> GetAll()
        {
            List<GlasoviPolitickiSubjektBirackoMjesto> glasoviPolitickiSubjektiBirackaMjesta = await repositoryInstance.GetAll();
            return glasoviPolitickiSubjektiBirackaMjesta;
        }

        public async Task<int> Update(GlasoviPolitickiSubjektBirackoMjesto glasoviPolitickiSubjektBirackoMjesto)
        {
            int glasoviPolitickiSubjektBirackoMjestoId = await repositoryInstance.Update(glasoviPolitickiSubjektBirackoMjesto);
            return glasoviPolitickiSubjektBirackoMjestoId;
        }

        public async Task<int> Delete(GlasoviPolitickiSubjektBirackoMjesto glasoviPolitickiSubjektBirackoMjesto)
        {
            int glasoviPolitickiSubjektBirackoMjestoId = await repositoryInstance.Delete(glasoviPolitickiSubjektBirackoMjesto);
            return glasoviPolitickiSubjektBirackoMjestoId;
        }

        public async Task<List<GlasoviPolitickiSubjektBirackoMjesto>> Search(Func<GlasoviPolitickiSubjektBirackoMjesto, bool> searchCriteria)
        {
            List<GlasoviPolitickiSubjektBirackoMjesto> glasoviPolitickiSubjektiBirackaMjesta = await repositoryInstance.Search(searchCriteria);
            return glasoviPolitickiSubjektiBirackaMjesta;
        }
    }
}