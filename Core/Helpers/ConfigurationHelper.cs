using Microsoft.Extensions.Configuration;

namespace Core.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                // Microsoft.Extensions.Configuration.FileExtensions
                .SetBasePath(Directory.GetCurrentDirectory())
                // Microsoft.Extensions.Configuration.Json
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("MsSqlConnection");
            return connectionString;
        }
    }
}
