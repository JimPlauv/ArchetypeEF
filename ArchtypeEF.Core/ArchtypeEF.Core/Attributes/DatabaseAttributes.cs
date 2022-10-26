using System;
using System.Collections.Generic;
using System.Text;

namespace ArchtypeEF.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ArchTable : Attribute
    {
        public virtual string tableName { get; set; }
        public ArchTable(string tableName = "")
        {
            this.tableName = tableName;
        }
    }


}
