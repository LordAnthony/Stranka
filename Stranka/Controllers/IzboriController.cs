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
    public class IzboriController : Controller
    {
        private ConfigurationModel _configuration;
        private IIzboriService _service;

        public IzboriController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
            _service = new IzboriService(_configuration);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            List<Izbori> candidates = _service.GetAllElections();
            return Ok(candidates);
        }


        [HttpPost()]
        public IActionResult Post([FromBody] Izbori elections)
        {
            long insertedId = _service.AddElections(elections);
            return Ok(insertedId);
        }
    }
}