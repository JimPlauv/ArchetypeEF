using ArchtypeEF.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ArchtypeEF.Core.Attributes;

namespace ArchtypeEF.Core
{
    public class Migration
    {
        public Configuration _configuration;

        public Migration(Configuration configuration)
        {
            _configuration = configuration;
        }

        public async Task RunMigration()
        {
            var typesWithMyAttribute = from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            let attributes = t.GetCustomAttributes(typeof(ArchTable), true)
            where attributes != null && attributes.Length > 0
            select new { Type = t, Attributes = attributes.Cast<ArchTable>() };

            foreach(var table in typesWithMyAttribute)
            {
                string name = table.Type.Name;
            }
        }
    }
}
