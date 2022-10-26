using System;
using System.Collections.Generic;
using System.Text;

namespace ArchtypeEF.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ArchTable : Attribute
    {
        public virtual string TableName { get; set; }
        public ArchTable(string tableName = "")
        {
            this.TableName = tableName;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ArchIgnore : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKey : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ArchColoumn : Attribute
    {
        public virtual bool AllowNull { get; set; }
        public virtual string DataType { get; set; }
        public virtual string DefaultValue { get; set; }
        public virtual bool IsIdentity { get; set; }
        public virtual int IdentityIncrement { get; set; }
        public virtual int IdentitySeed { get; set; }
        public virtual string ColoumnName { get; set; }

        public ArchColoumn(bool allowNull = false, string dataType = "", string defaultValue = "", bool isIdentity = false,
            int identityIncrement = 0, int identitySeed = 0, string coloumnName = "")
        {
            this.AllowNull = allowNull;
            this.DataType = dataType;
            this.DefaultValue = defaultValue;
            this.IsIdentity = isIdentity;
            this.IdentityIncrement = identityIncrement;
            this.IdentitySeed = identitySeed;
        }
    }
}
