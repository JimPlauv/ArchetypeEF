using ArchtypeEF.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchtypeEF.Core.StatementBuilder
{
    internal class CreateTable
    {
        internal string MSSQL(Type table, IEnumerable<ArchTable> attributes)
        {
            var tableAttribute = (ArchTable)Attribute.GetCustomAttribute(table, typeof(ArchTable));

            //string tableName = table.Attributes table.Name;

            StringBuilder sb = new StringBuilder();

            sb.Append("CREATE TABLE (");
            sb.Append(");");

            return "";
        }
    }
}
