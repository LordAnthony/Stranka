using System.Collections.Generic;
using Stranka.Services.Entities;

namespace Stranka.Services.Interfaces
{
    public interface IPolitickiSubjektService
    {
        long AddPoliticalSubject(PolitickiSubjekt politickiSubjekt);
        PolitickiSubjekt GetPoliticalSubject(long id);
        List<PolitickiSubjekt> GetAllPoliticalSubjects();
        void UpdatePoliticalSubject(PolitickiSubjekt politickiSubjekt);
        void DeletePoliticalSubject(long id);
        List<GlasoviPolitickiSubjekt> GetVotesByPoolingStation(long politicalSubjectId, long electionsId, long constituencyId, long categoryId, long pollingStationId);
        List<GlasoviPolitickiSubjekt> GetVotesByConstituency(long politicalSubjectId, long electionsId, long constituencyId, long categoryId);
        void UpdateVotesOfPoliticalSubject(GlasoviPolitickiSubjekt votes);
    }
}
