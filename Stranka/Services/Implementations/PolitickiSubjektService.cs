using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Stranka.Services.Common;
using Stranka.Services.Entities;
using Stranka.Services.Interfaces;

namespace Stranka.Services.Implementations
{
    public class PolitickiSubjektService : IPolitickiSubjektService
    {
        private ConfigurationModel _configuration;

        public PolitickiSubjektService(ConfigurationModel configuration)
        {
            _configuration = configuration;
        }

        public long AddPoliticalSubject(PolitickiSubjekt politickiSubjekt)
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
                        repository.AddParameterInList("@Sifra", politickiSubjekt.sifra, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Naziv", politickiSubjekt.naziv, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Adresa", politickiSubjekt.adresa, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Grad", politickiSubjekt.grad, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Telefon", politickiSubjekt.telefon, SqlDbType.Text, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.ADD_POLITICALSUBJECT, parameters);
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

        public PolitickiSubjekt GetPoliticalSubject(long id)
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_POLITICALSUBJECT, parameters);
                        PolitickiSubjekt politicalSubject = DataReaderConverter.ToObject<PolitickiSubjekt>(dataReader);
                        dataReader.Close();
                        return politicalSubject;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PolitickiSubjekt> GetAllPoliticalSubjects()
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_ALL_POLITICALSUBJECT);
                        List<PolitickiSubjekt> politicalSubjects = DataReaderConverter.ToList<PolitickiSubjekt>(dataReader);
                        dataReader.Close();
                        return politicalSubjects;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdatePoliticalSubject(PolitickiSubjekt politickiSubjekt)
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
                        repository.AddParameterInList("@Id", politickiSubjekt.id, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@Sifra", politickiSubjekt.sifra, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Naziv", politickiSubjekt.naziv, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Adresa", politickiSubjekt.adresa, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Grad", politickiSubjekt.grad, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Telefon", politickiSubjekt.telefon, SqlDbType.Text, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.UPDATE_POLITICALSUBJECT, parameters);
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

        public void DeletePoliticalSubject(long id)
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.DELETE_POLITICALSUBJECT, parameters);
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

        public List<GlasoviPolitickiSubjekt> GetVotesByPollingStation(long electionsId, long categoryId, long pollingStationId)
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_POLITICALSUBJECTS_VOTES_BY_CATEGORY_AND_POLLINGSTATION, parameters);
                        List<GlasoviPolitickiSubjekt> votes = DataReaderConverter.ToList<GlasoviPolitickiSubjekt>(dataReader);
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


        public List<GlasoviPolitickiSubjekt> GetVotesByPoliticalSubject(long electionsId, long categoryId, long politicalSubjectId)
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
                        repository.AddParameterInList("@PolitickiSubjektId", politicalSubjectId, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_POLITICALSUBJECT_VOTES_BY_CATEGORY, parameters);
                        List<GlasoviPolitickiSubjekt> votes = DataReaderConverter.ToList<GlasoviPolitickiSubjekt>(dataReader);
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

        public GlasoviPolitickiSubjekt GetVotesById(long id)
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_POLITICALSUBJECTS_VOTES_BY_ID, parameters);
                        List<GlasoviPolitickiSubjekt> votes = DataReaderConverter.ToList<GlasoviPolitickiSubjekt>(dataReader);
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

        public void UpdateVotesOfPoliticalSubject(GlasoviPolitickiSubjekt votes)
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.UPDATE_NUMBER_OF_VOTES_POLITICALSUBJECT, parameters);
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