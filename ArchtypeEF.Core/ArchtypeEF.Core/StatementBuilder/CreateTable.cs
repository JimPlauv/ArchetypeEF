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
            StringBuilder sb = new StringBuilder();

            sb.Append("CREATE TABLE " + StatementHelper.TableName(table) + " (");
            foreach(var property in table.GetProperties())
            {

            }
            sb.Append(");");

            return "";
        }
    }
}
