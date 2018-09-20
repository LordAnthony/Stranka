using Microsoft.Extensions.Configuration;

namespace Stranka.Services.Common
{
    public static class ConnectionStringHelper
    {
        public static string GetConnectionString(ConfigurationModel configuration)
        {
            string connectionString = string.Format(Constants.CONNECTION_STRING, configuration.Server, configuration.Database);
            return connectionString;
        }
    }
}
