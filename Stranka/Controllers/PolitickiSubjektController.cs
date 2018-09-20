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
        public IActionResult Get([FromQuery] long politicalSubjectId, [FromQuery] long electionsId, [FromQuery] long constituencyId, [FromQuery] long categoryId, [FromQuery] long pollingStationId)
        {
            List<GlasoviPolitickiSubjekt> votes = _service.GetVotesByPoolingStation(politicalSubjectId, electionsId, constituencyId, categoryId, pollingStationId);
            return Ok(votes);
        }

        [HttpGet("votesByConstituency")]
        public IActionResult Get([FromQuery] long politicalSubjectId, [FromQuery] long electionsId, [FromQuery] long constituencyId, [FromQuery] long categoryId)
        {
            List<GlasoviPolitickiSubjekt> votes = _service.GetVotesByConstituency(politicalSubjectId, electionsId, constituencyId, categoryId);
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