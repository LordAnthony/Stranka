using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Stranka.Services.Common;
using Stranka.Services.Entities;
using Stranka.Services.Interfaces;

namespace Stranka.Services.Implementations
{
    public class IzboriService : IIzboriService
    {
        private ConfigurationModel _configuration;
        public IzboriService(ConfigurationModel configuration)
        {
            _configuration = configuration;
        }

        public List<Izbori> GetAllElections()
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_ALL_ELECTIONS);
                        List<Izbori> elections = DataReaderConverter.ToList<Izbori>(dataReader);
                        dataReader.Close();
                        return elections;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long AddElections(Izbori elections)
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
                        repository.AddParameterInList("@VrstaIzboraId", elections.vrstaIzboraId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@NivoIzboraId", elections.nivoIzboraId, SqlDbType.BigInt, ref parameters);
                        repository.AddParameterInList("@DatumOdrzavanja", elections.datumOdrzavanja, SqlDbType.Date, ref parameters);
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.ADD_ELECTIONS, parameters);
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

        public List<Kategorija> GetCategoriesForElections(long electionsId)
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_CATEGORIES_BY_ELECTIONS, parameters);
                        List<Kategorija> categories = DataReaderConverter.ToList<Kategorija>(dataReader);
                        dataReader.Close();
                        transaction.Commit();
                        return categories;
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
