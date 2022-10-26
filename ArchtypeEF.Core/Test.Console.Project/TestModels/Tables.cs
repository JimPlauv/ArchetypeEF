using ArchtypeEF.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Console.Project.TestModels
{
    [ArchTable]
    public class TableA
    {
    }

    [ArchTable(TableName = "CustomNameTable")]
    public class TableB
    {
        [ArchColoumn(AllowNull = false, IsIdentity = true, IdentityIncrement = 1)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        [ArchIgnore]
        public string IgnoreMe { get; set; }
    }
}
