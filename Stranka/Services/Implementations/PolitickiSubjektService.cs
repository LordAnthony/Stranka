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
                        repository.AddParameterInList("@Sifra", politickiSubjekt.Sifra, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Naziv", politickiSubjekt.Naziv, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Adresa", politickiSubjekt.Adresa, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Grad", politickiSubjekt.Grad, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Telefon", politickiSubjekt.Telefon, SqlDbType.Text, ref parameters);
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
                        repository.AddParameterInList("@Id", politickiSubjekt.Id, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@Sifra", politickiSubjekt.Sifra, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Naziv", politickiSubjekt.Naziv, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Adresa", politickiSubjekt.Adresa, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Grad", politickiSubjekt.Grad, SqlDbType.Text, ref parameters);
                        repository.AddParameterInList("@Telefon", politickiSubjekt.Telefon, SqlDbType.Text, ref parameters);
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

        public List<GlasoviPolitickiSubjekt> GetVotesByPoolingStation(long politicalSubjectId, long electionsId, long constituencyId, long categoryId, long pollingStationId)
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
                        repository.AddParameterInList("@PolitickiSubjektId", politicalSubjectId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@IzboriId", electionsId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@IzbornaJedinicaId", constituencyId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@KategorijaId", categoryId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@BirackoMjestoId", pollingStationId, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_VOTES_OF_POLITICALSUBJECT_BY_POLLINGSTATION_AND_CATEGORY, parameters);
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


        public List<GlasoviPolitickiSubjekt> GetVotesByConstituency(long politicalSubjectId, long electionsId, long constituencyId, long categoryId)
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
                        repository.AddParameterInList("@PolitickiSubjektId", politicalSubjectId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@IzboriId", electionsId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@IzbornaJedinicaId", constituencyId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@KategorijaId", categoryId, SqlDbType.BigInt, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_VOTES_OF_POLITICALSUBJECT_BY_CONSTITUENCY_AND_CATEGORY, parameters);
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
                        repository.AddParameterInList("@Id", votes.Id, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@BrojGlasova", votes.BrojGlasova, SqlDbType.Int, ref parameters);
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