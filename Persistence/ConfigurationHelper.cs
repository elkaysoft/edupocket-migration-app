using Microsoft.Extensions.Configuration;

namespace Persistence
{
    public static class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("WalletDbContext") ?? "";
        }
    }
}
