

namespace Stranka.Services.Common
{
    public class Constants
    {
        public const string CONNECTION_STRING = "Data Source={0};Initial Catalog={1};Integrated Security=True;Connection Timeout=30;MultipleActiveResultSets=True";
        public const string GET_ALL_MUNICIPALITIES = "SelectAllMunicipalities";
        public const string GET_ALL_POLLINGSTATIONS = "SelectAllPollingStations";
        public const string GET_ALL_LOCATIONS = "SelectAllLocations";
        public const string GET_ALL_CANTONS = "SelectAllCantons";
        public const string GET_ALL_CONSTITUENCIES = "SelectAllConstituencies";
        public const string ADD_CANDIDATE = "InsertCandidate";
        public const string GET_CANDIDATE = "SelectCandidate";
        public const string GET_ALL_CANDIDATES = "SelectAllCandidates";
        public const string UPDATE_CANDIDATE = "UpdateCandidate";
        public const string DELETE_CANDIDATE = "DeleteCandidate";
        public const string ADD_POLITICALSUBJECT = "InsertPoliticalSubject";
        public const string GET_POLITICALSUBJECT = "SelectPoliticalSubject";
        public const string GET_ALL_POLITICALSUBJECT = "SelectAllPoliticalSubjects";
        public const string UPDATE_POLITICALSUBJECT = "UpdatePoliticalSubject";
        public const string DELETE_POLITICALSUBJECT = "DeletePoliticalSubject";
        public const string GET_POLITICALSUBJECTS_VOTES_BY_CATEGORY_AND_POLLINGSTATION = "SelectPoliticalSubjectsVotesByCategoryAndPollingStation";
        public const string GET_POLITICALSUBJECT_VOTES_BY_CATEGORY = "SelectPoliticalSubjectVotesByCategory";
        public const string GET_POLITICALSUBJECTS_VOTES_BY_ID = "SelectPoliticalSubjectsVotesById";
        public const string UPDATE_NUMBER_OF_VOTES_POLITICALSUBJECT = "UpdateVotesPoliticalSubject";
        public const string GET_CANDIDATES_VOTES_BY_POLLINGSTATION = "SelectCandidatesVotesByPollingStation";
        public const string GET_CANDIDATE_VOTES = "SelectCandidateVotes";
        public const string GET_CANDIDATES_VOTES_BY_ID = "SelectCandidatesVotesById";
        public const string UPDATE_NUMBER_OF_VOTES_CANDIDATE = "UpdateVotesCandidate";
        public const string GET_ALL_ELECTIONS = "SelectAllElections";
        public const string ADD_ELECTIONS = "InsertElections";
        public const string GET_CATEGORIES_BY_ELECTIONS = "SelectCategoriesByElections";
    }
}
