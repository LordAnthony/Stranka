using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Stranka.Services.Interfaces;

namespace Stranka.Services.Implementations
{
    public class ExecutorService: IExecutorService
    {
        private SqlConnection _connection;

        private SqlTransaction _transaction;

        public ExecutorService(SqlConnection connection, SqlTransaction transaction = null)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public SqlDataReader ExecuteProcedure(string procedureName, List<SqlParameter> parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(procedureName))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null && parameters.Count > 0)
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                    }
                    command.Connection = _connection;
                    command.Transaction = _transaction;
                    SqlDataReader result = command.ExecuteReader();
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddParameterInList(string parameterName, object parameterValue, SqlDbType dbType, ref List<SqlParameter> parameters)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            parameter.SqlDbType = dbType;
            parameters.Add(parameter);
        }

    }
}
