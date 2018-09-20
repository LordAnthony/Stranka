using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Stranka.Services.Interfaces
{
    public interface IExecutorService
    {
        SqlDataReader ExecuteProcedure(string procedureName, List<SqlParameter> parameters = null);
        void AddParameterInList(string parameterName, object parameterValue, SqlDbType dbType, ref List<SqlParameter> parameters);
    }
}
