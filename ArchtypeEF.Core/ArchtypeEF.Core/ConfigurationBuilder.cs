using ArchtypeEF.Core.CoreType;
using ArchtypeEF.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchtypeEF.Core
{
    public class ConfigurationBuilder : IConfigurationBuilder
    {
        private Configuration _configuration = new Configuration();
        public Configuration Build() => _configuration;

        public ConfigurationBuilder SetSource(SourceType sourceType)
        {
            _configuration.SourceType = sourceType;
            return this;
        }
    }
}
