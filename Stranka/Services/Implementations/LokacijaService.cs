using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Stranka.Services.Common;
using Stranka.Services.Entities;
using Stranka.Services.Interfaces;

namespace Stranka.Services.Implementations
{
    public class LokacijaService : ILokacijaService
    {
        private ConfigurationModel _configuration;

        public LokacijaService(ConfigurationModel configuration)
        {
            _configuration = configuration;
        }

        public List<Lokacija> GetAllLocations()
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_ALL_LOCATIONS);
                        List<Lokacija> constituencies = DataReaderConverter.ToList<Lokacija>(dataReader);
                        dataReader.Close();
                        return constituencies;
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
