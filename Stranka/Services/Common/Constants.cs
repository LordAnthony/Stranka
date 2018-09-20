

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

        public const string GET_VOTES_OF_POLITICALSUBJECT_BY_POLLINGSTATION_AND_CATEGORY = "SelectVotesOfPoliticalSubjectByPoolingStationAndCategory";

        public const string GET_VOTES_OF_POLITICALSUBJECT_BY_CONSTITUENCY_AND_CATEGORY = "SelectVotesOfPoliticalSubjectByConstituencyAndCategory";

        public const string UPDATE_NUMBER_OF_VOTES_POLITICALSUBJECT = "UpdateVotesPoliticalSubject";

        public const string GET_VOTES_OF_CANDIDATE_BY_POLLINGSTATION = "SelectVotesOfCandidateByPoolingStation";

        public const string GET_VOTES_OF_CANDIDATE = "SelectVotesOfCandidate";

        public const string UPDATE_NUMBER_OF_VOTES_CANDIDATE = "UpdateVotesCandidate";

        public const string GET_ALL_ELECTIONS = "SelectAllElections";

        public const string ADD_ELECTIONS = "InsertElections";

    }
}
