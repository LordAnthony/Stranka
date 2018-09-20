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
    public class KantonController : Controller
    {
        private ConfigurationModel _configuration;

        public KantonController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            IKantonService service = new KantonService(_configuration);
            List<Kanton> cantons = service.GetAllCantons();
            return Ok(cantons);
        }
    }
}