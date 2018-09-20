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
    public class OpcinaController : Controller
    {
        private ConfigurationModel _configuration;

        public OpcinaController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            IOpcinaService service = new OpcinaService(_configuration);
            List<Opcina> municipalities = service.GetAllMunicipalities();
            return Ok(municipalities);
        }
    }
}