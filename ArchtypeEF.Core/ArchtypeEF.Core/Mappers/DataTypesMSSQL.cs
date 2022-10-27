using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchtypeEF.Core.Mappers
{
    internal class DataTypesMSSQL
    {
        internal string ConversionTable(Type type)
        {
            var typeDict = new Dictionary<Type, string>();
            typeDict.Add(typeof(int), "int");
            typeDict.Add(typeof(decimal), "decimal");
            typeDict.Add(typeof(float), "float");
            typeDict.Add(typeof(double), "float");
            typeDict.Add(typeof(string), "ntext");
            typeDict.Add(typeof(bool), "bit");
            typeDict.Add(typeof(byte), "binary");
            typeDict.Add(typeof(Byte[]), "binary");
            typeDict.Add(typeof(Guid), "uniqueidentifier");
            typeDict.Add(typeof(DateTime), "datetime");
            typeDict.Add(typeof(DateTimeOffset), "datetimeoffset");

            return typeDict.SingleOrDefault(i=>i.Key.Name == type.Name).Value;
        }
    }
}
