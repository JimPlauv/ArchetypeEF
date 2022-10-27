using ArchtypeEF.Core.Attributes;
using ArchtypeEF.Core.Mappers;
using System;
using System.Collections.Generic;
using System.Reflection;
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

        internal static string CouloumnName(PropertyInfo property)
        {
            var coloumnAttribute = (ArchColoumn)Attribute.GetCustomAttribute(property, typeof(ArchColoumn));

            if (coloumnAttribute != null && !string.IsNullOrEmpty(coloumnAttribute.ColoumnName))
                return coloumnAttribute.ColoumnName;

            return property.Name;
        }

        internal static string CouloumnDatatype(PropertyInfo property)
        {
            var coloumnAttribute = (ArchColoumn)Attribute.GetCustomAttribute(property, typeof(ArchColoumn));
            
            if (coloumnAttribute != null && !string.IsNullOrEmpty(coloumnAttribute.DataType))
                return coloumnAttribute.DataType;

            var conversion = new DataTypesMSSQL();

            return conversion.ConversionTable(property.PropertyType);
        }
    }
}
