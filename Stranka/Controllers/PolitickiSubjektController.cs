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
    public class PolitickiSubjektController : Controller
    {
        private ConfigurationModel _configuration;
        private IPolitickiSubjektService _service;

        public PolitickiSubjektController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
            _service = new PolitickiSubjektService(_configuration);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            List<PolitickiSubjekt> politicalSubjects = _service.GetAllPoliticalSubjects();
            return Ok(politicalSubjects);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            PolitickiSubjekt politicalSubject = _service.GetPoliticalSubject(id);
            return Ok(politicalSubject);
        }

        [HttpPost()]
        public IActionResult Post([FromBody] PolitickiSubjekt politicalSubject)
        {
            long insertedId = _service.AddPoliticalSubject(politicalSubject);
            return Ok(insertedId);
        }

        [HttpPut()]
        public IActionResult Put([FromBody] PolitickiSubjekt politicalSubject)
        {
            _service.UpdatePoliticalSubject(politicalSubject);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _service.DeletePoliticalSubject(id);
            return Ok();
        }

        [HttpGet("votesByPollingStations")]
        public IActionResult GetByPollingStation([FromQuery] long electionsId, [FromQuery] long categoryId, [FromQuery] long pollingStationId)
        {
            List<GlasoviPolitickiSubjekt> votes = _service.GetVotesByPollingStation(electionsId, categoryId, pollingStationId);
            return Ok(votes);
        }

        [HttpGet("votesByPoliticalSubject")]
        public IActionResult GetByPoliticalSubject([FromQuery] long electionsId, [FromQuery] long categoryId, [FromQuery] long politicalSubjectId)
        {
            List<GlasoviPolitickiSubjekt> votes = _service.GetVotesByPoliticalSubject(electionsId, categoryId, politicalSubjectId);
            return Ok(votes);
        }

        [HttpGet("votesById")]
        public IActionResult GetById([FromQuery] long id)
        {
            GlasoviPolitickiSubjekt votes = _service.GetVotesById(id);
            return Ok(votes);
        }

        [HttpPut("votes")]
        public IActionResult Put([FromBody] GlasoviPolitickiSubjekt votes)
        {
            _service.UpdateVotesOfPoliticalSubject(votes);
            return Ok();
        }
    }
}