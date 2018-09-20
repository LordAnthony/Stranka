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
    public class KandidatController : Controller
    {
        private ConfigurationModel _configuration;
        private IKandidatService _service;

        public KandidatController(IOptions<ConfigurationModel> configuration)
        {
            _configuration = configuration.Value;
            _service = new KandidatService(_configuration);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            List<Kandidat> candidates = _service.GetAllCandidates();
            return Ok(candidates);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Kandidat candidate = _service.GetCandidate(id);
            return Ok(candidate);
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Kandidat candidate)
        {
            long insertedId = _service.AddCandidate(candidate);
            return Ok(insertedId);
        }

        [HttpPut()]
        public IActionResult Put([FromBody] Kandidat candidate)
        {
           _service.UpdateCandidate(candidate);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _service.DeleteCandidate(id);
            return Ok();
        }

        [HttpGet("votesByPollingStations")]
        public IActionResult Get([FromQuery] long candidateId, [FromQuery] long electionsId, [FromQuery] long pollingStationId)
        {
            List<GlasoviKandidat> votes = _service.GetVotesByPoolingStation(candidateId, electionsId, pollingStationId);
            return Ok(votes);
        }

        [HttpGet("allVotes")]
        public IActionResult Get([FromQuery] long candidateId, [FromQuery] long electionsId)
        {
            List<GlasoviKandidat> votes = _service.GetAllVotes(candidateId, electionsId);
            return Ok(votes);
        }

        [HttpPut("votes")]
        public IActionResult Put([FromBody] GlasoviKandidat votes)
        {
            _service.UpdateVotesOfCandidate(votes);
            return Ok();
        }
    }
}