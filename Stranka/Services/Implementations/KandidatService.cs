using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Stranka.Services.Common;
using Stranka.Services.Entities;
using Stranka.Services.Interfaces;

namespace Stranka.Services.Implementations
{
    public class KandidatService : IKandidatService
    {
        private ConfigurationModel _configuration;

        public KandidatService(ConfigurationModel configuration)
        {
            _configuration = configuration;
        }


        public long AddCandidate(Kandidat kandidat)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@ImePrezime", kandidat.imePrezime, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@JMBG", kandidat.jmbg, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Adresa", kandidat.adresa, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Telefon", kandidat.telefon, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Email", kandidat.email, SqlDbType.Text, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.ADD_CANDIDATE, parameters);
                        long insertedId = DataReaderConverter.ToBigInt(dataReader);
                        dataReader.Close();
                        transaction.Commit();
                        return insertedId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Kandidat GetCandidate(long id)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@Id", id, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_CANDIDATE, parameters);
                        Kandidat candidate = DataReaderConverter.ToObject<Kandidat>(dataReader);
                        dataReader.Close();
                        return candidate;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Kandidat> GetAllCandidates()
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_ALL_CANDIDATES);
                        List<Kandidat> candidates = DataReaderConverter.ToList<Kandidat>(dataReader);
                        dataReader.Close();
                        return candidates;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCandidate(Kandidat kandidat)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@Id", kandidat.id, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@ImePrezime", kandidat.imePrezime, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@JMBG", kandidat.jmbg, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Adresa", kandidat.adresa, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Telefon", kandidat.telefon, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Email", kandidat.email, SqlDbType.Text, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.UPDATE_CANDIDATE, parameters);
                        dataReader.Close();
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCandidate(long id)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@Id", id, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.DELETE_CANDIDATE, parameters);
                        dataReader.Close();
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GlasoviKandidat> GetVotesByPoolingStation(long electionsId, long categoryId, long pollingStationId)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@IzboriId", electionsId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@KategorijaId", categoryId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@BirackoMjestoId", pollingStationId, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_CANDIDATES_VOTES_BY_POLLINGSTATION, parameters);
                        List<GlasoviKandidat> votes = DataReaderConverter.ToList<GlasoviKandidat>(dataReader);
                        dataReader.Close();
                        transaction.Commit();
                        return votes;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GlasoviKandidat> GetVotesByCandidate(long electionsId, long categoryId, long candidateId)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@IzboriId", electionsId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@KategorijaId", categoryId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@KandidatId", candidateId, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_CANDIDATE_VOTES, parameters);
                        List<GlasoviKandidat> votes = DataReaderConverter.ToList<GlasoviKandidat>(dataReader);
                        dataReader.Close();
                        transaction.Commit();
                        return votes;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public GlasoviKandidat GetVotesById(long id)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@Id", id, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_CANDIDATES_VOTES_BY_ID, parameters);
                        List<GlasoviKandidat> votes = DataReaderConverter.ToList<GlasoviKandidat>(dataReader);
                        dataReader.Close();
                        transaction.Commit();
                        return votes[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateVotesOfCandidate(GlasoviKandidat votes)
        {
            try
            {
                string connectionString = ConnectionStringHelper.GetConnectionString(_configuration);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        ExecutorService repository = new ExecutorService(connection, transaction);
                        List<SqlParameter> parameters = new List<SqlParameter>();
                        repository.AddParameterInList("@Id", votes.id, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@BrojGlasova", votes.brojGlasova, SqlDbType.Int, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.UPDATE_NUMBER_OF_VOTES_CANDIDATE, parameters);
                        dataReader.Close();
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}