using ArchtypeEF.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchtypeEF.Core.StatementBuilder
{
    internal static class StatementHelper
    {
        internal static string TableName(Type type)
        {
            var tableAttribute = (ArchTable)Attribute.GetCustomAttribute(type, typeof(ArchTable));

            if(!string.IsNullOrEmpty(tableAttribute.TableName))
                return tableAttribute.TableName;

            return type.Name;
        }
    }
}
