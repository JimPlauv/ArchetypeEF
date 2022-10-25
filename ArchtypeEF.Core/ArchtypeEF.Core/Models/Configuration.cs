using ArchtypeEF.Core.CoreType;

namespace ArchtypeEF.Core.Models
{
    public class Configuration
    {
        public SourceType SourceType { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConnectionString { get; set; }
    }
}
