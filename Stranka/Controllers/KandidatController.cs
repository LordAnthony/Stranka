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

        [HttpGet("votesByPollingStation")]
        public IActionResult GetByPollingStation([FromQuery] long electionsId, [FromQuery] long categoryId, [FromQuery] long pollingStationId)
        {
            List<GlasoviKandidat> votes = _service.GetVotesByPoolingStation(electionsId, categoryId, pollingStationId);
            return Ok(votes);
        }

        [HttpGet("votesByCandidate")]
        public IActionResult GetByCandidate([FromQuery] long electionsId, [FromQuery] long categoryId, [FromQuery] long candidateId)
        {
            List<GlasoviKandidat> votes = _service.GetVotesByCandidate(electionsId, categoryId, candidateId);
            return Ok(votes);
        }

        [HttpGet("votesById")]
        public IActionResult GetById([FromQuery] long id)
        {
            GlasoviKandidat votes = _service.GetVotesById(id);
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