using ArchtypeEF.Core.CoreType;
using ArchtypeEF.Core.Models;

namespace ArchtypeEF.Core
{
    public interface IConfigurationBuilder
    {
        Configuration Build();
        ConfigurationBuilder SetSource(SourceType sourceType);
        ConfigurationBuilder SetConnectionString(string connectionStirng);
        ConfigurationBuilder SetConnectionParameters(string server, string database, string username, string password);
        ConfigurationBuilder RunMigrationAtStartUp();
        void Init();
    }
}
