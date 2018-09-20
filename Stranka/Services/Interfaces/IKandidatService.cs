using System.Collections.Generic;
using Stranka.Services.Entities;

namespace Stranka.Services.Interfaces
{
    public interface IKandidatService
    {
        long AddCandidate(Kandidat kandidat);
        Kandidat GetCandidate(long id);
        List<Kandidat> GetAllCandidates();
        void UpdateCandidate(Kandidat kandidat);
        void DeleteCandidate(long id);
        List<GlasoviKandidat> GetVotesByPoolingStation(long candidateId, long electionsId, long pollingStationId);
        List<GlasoviKandidat> GetAllVotes(long candidateId, long electionsId);
        void UpdateVotesOfCandidate(GlasoviKandidat votes);
    }
}
