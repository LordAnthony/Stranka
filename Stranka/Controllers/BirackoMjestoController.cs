using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stranka.Services.Common;
using Stranka.Services.Entities;
using Stranka.Services.Implementations;
using Stranka.Services.Interfaces;

namespace Stranka.Controllers
{
    [Route("api/[controller]")]
    public class BirackoMjestoController : Controller
    {
        private ConfigurationModel _configuration;

        public BirackoMjestoController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            IBirackoMjestoService service = new BirackoMjestoService(_configuration);
            List<BirackoMjesto> pollingStations = service.GetAllPollingStations();
            return Ok(pollingStations);
        }
    }

}