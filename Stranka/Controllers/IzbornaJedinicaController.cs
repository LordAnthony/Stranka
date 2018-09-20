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
    public class IzbornaJedinicaController : Controller
    {
        private ConfigurationModel _configuration;

        public IzbornaJedinicaController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            IIzbornaJedinicaService service = new IzbornaJedinicaService(_configuration);
            List<IzbornaJedinica> constituencies = service.GetAllConstituencies();
            return Ok(constituencies);
        }
    }
}