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
        List<GlasoviKandidat> GetVotesByPoolingStation(long electionsId, long categoryId, long pollingStationId);
        List<GlasoviKandidat> GetVotesByCandidate(long electionsId, long categoryId, long candidateId);
        GlasoviKandidat GetVotesById(long id);
        void UpdateVotesOfCandidate(GlasoviKandidat votes);
    }
}
