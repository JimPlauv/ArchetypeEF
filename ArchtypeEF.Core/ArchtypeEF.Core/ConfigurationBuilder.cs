using ArchtypeEF.Core.CoreType;
using ArchtypeEF.Core.Models;

namespace ArchtypeEF.Core
{
    public class ConfigurationBuilder : IConfigurationBuilder
    {
        public Configuration Config = new Configuration();
        public Configuration Build() => Config;

        public ConfigurationBuilder SetSource(SourceType sourceType)
        {
            Config.SourceType = sourceType;
            return this;
        }

        public ConfigurationBuilder SetConnectionString(string connectionStirng)
        {
            Config.ConnectionString = connectionStirng;
            return this;
        }

        public ConfigurationBuilder SetConnectionParameters(string server, string database, string username, string password)
        {
            Config.Database = database;
            Config.Server = server;
            Config.Username = username;
            Config.Password = password;
            return this;
        }

        public void Init()
        {
            ConfigurationManager.Config = Config;
        }
    }
}
