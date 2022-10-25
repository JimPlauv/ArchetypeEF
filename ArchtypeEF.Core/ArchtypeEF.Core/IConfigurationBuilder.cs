using ArchtypeEF.Core.CoreType;
using ArchtypeEF.Core.Models;

namespace ArchtypeEF.Core
{
    public interface IConfigurationBuilder
    {
        Configuration Build();
        ConfigurationBuilder SetSource(SourceType sourceType);
    }
}
