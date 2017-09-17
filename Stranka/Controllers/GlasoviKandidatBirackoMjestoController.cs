using Stranka.Entities;
using Stranka.Services;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Stranka.Controllers
{
    [Authorize]
    public class GlasoviKandidatBirackoMjestoController : ApiController
    {
        GlasoviKandidatBirackoMjestoService service = new GlasoviKandidatBirackoMjestoService();

        // GET api/vrstaizbora
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var result = await service.GetAll();
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // GET api/vrstaizbora/5
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                var result = await service.Get(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST api/vrstaizbora
        public async Task<IHttpActionResult> Post([FromBody]GlasoviKandidatBirackoMjesto glasoviKandidatBirackoMjesto)
        {
            try
            {
                var result = await service.Add(glasoviKandidatBirackoMjesto);
                if (result != 0)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // PUT api/vrstaizbora/5
        public async Task<IHttpActionResult> Put([FromBody]GlasoviKandidatBirackoMjesto glasoviKandidatBirackoMjesto)
        {
            try
            {
                var result = await service.Update(glasoviKandidatBirackoMjesto);
                if (result != 0)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // DELETE api/vrstaizbora/5
        public async Task<IHttpActionResult> Delete([FromBody]GlasoviKandidatBirackoMjesto glasoviKandidatBirackoMjesto)
        {
            try
            {
                var result = await service.Delete(glasoviKandidatBirackoMjesto);
                if (result != 0)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
