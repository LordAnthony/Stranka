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
        List<GlasoviPolitickiSubjekt> GetVotesByPollingStation(long electionsId, long categoryId, long pollingStationId);
        List<GlasoviPolitickiSubjekt> GetVotesByPoliticalSubject(long electionsId, long categoryId, long politicalSubjectId);
        GlasoviPolitickiSubjekt GetVotesById(long id);
        void UpdateVotesOfPoliticalSubject(GlasoviPolitickiSubjekt votes);
    }
}
