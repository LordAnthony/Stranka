using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Stranka.Services.Common;
using Stranka.Services.Entities;
using Stranka.Services.Interfaces;

namespace Stranka.Services.Implementations
{
    public class OpcinaService : IOpcinaService
    {
        private ConfigurationModel _configuration;

        public OpcinaService(ConfigurationModel configuration)
        {
            _configuration = configuration;
        }

        public List<Opcina> GetAllMunicipalities()
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
                        SqlDataReader dataReader = repository.ExecuteProcedure(Constants.GET_ALL_MUNICIPALITIES);
                        List<Opcina> opcine = DataReaderConverter.ToList<Opcina>(dataReader);
                        dataReader.Close();
                        return opcine;
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
