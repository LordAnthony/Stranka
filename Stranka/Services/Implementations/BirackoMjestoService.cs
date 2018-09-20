using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Stranka.Services.Common;
using Stranka.Services.Entities;
using Stranka.Services.Interfaces;

namespace Stranka.Services.Implementations
{
    public class BirackoMjestoService: IBirackoMjestoService
    {
        private ConfigurationModel _configuration;
        public BirackoMjestoService(ConfigurationModel configuration)
        {
            _configuration = configuration;
        }

        public List<BirackoMjesto> GetAllPollingStations()
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_ALL_POLLINGSTATIONS);
                        List<BirackoMjesto> pollingStations = DataReaderConverter.ToList<BirackoMjesto>(dataReader);
                        dataReader.Close();
                        return pollingStations;
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
