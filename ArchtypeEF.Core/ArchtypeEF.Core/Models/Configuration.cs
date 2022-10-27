using ArchtypeEF.Core.CoreType;

namespace ArchtypeEF.Core.Models
{
    public class Configuration
    {
        public SourceType Source { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConnectionString { get; set; }

        internal string GetConnectionString()
        {
            if(!string.IsNullOrEmpty(ConnectionString))
            {
                return ConnectionString;
            }

            switch(Source)
            {
                case SourceType.MSSQL:
                    return "";
                case SourceType.MySQL:
                    return "";
                case SourceType.Mongo:
                    return "";
                default:
                    return "";
            }
        }
    }
}
