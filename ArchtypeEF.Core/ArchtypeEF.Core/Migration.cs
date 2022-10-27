using ArchtypeEF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArchtypeEF.Core.Attributes;

namespace ArchtypeEF.Core
{
    internal class Migration
    {
        public Configuration _configuration;

        internal Migration(Configuration configuration)
        {
            _configuration = configuration;
        }

        internal async Task RunMigration()
        {
            var typesWithMyAttribute = from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            let attributes = t.GetCustomAttributes(typeof(ArchTable), true)
            where attributes != null && attributes.Length > 0
            select new { Type = t, Attributes = attributes.Cast<ArchTable>() };

            foreach(var table in typesWithMyAttribute)
            {
                await CreateTable(table.Type, table.Attributes);
            }
        }

        internal async Task CreateTable(Type table, IEnumerable<ArchTable> attributes)
        {
            string connStr = _configuration.GetConnectionString();
        }
    }
}
