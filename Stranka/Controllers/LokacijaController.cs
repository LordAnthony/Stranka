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
    public class LokacijaController : Controller
    {
        private ConfigurationModel _configuration;

        public LokacijaController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            ILokacijaService service = new LokacijaService(_configuration);
            List<Lokacija> locations = service.GetAllLocations();
            return Ok(locations);
        }
    }
}