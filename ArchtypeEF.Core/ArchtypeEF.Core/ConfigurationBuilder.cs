using ArchtypeEF.Core.CoreType;
using ArchtypeEF.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void Init()
        {
            ConfigurationManager.Config = Config;
        }
    }
}
