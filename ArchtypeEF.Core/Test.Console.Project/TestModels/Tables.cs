using ArchtypeEF.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Console.Project.TestModels
{
    [ArchTable]
    public class TableA
    {
        [ArchColoumn(AllowNull = false, IsIdentity = true, IdentityIncrement = 1)]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [ArchTable(TableName = "CustomNameTable")]
    public class TableB
    {
        [ArchColoumn(AllowNull = false, IsIdentity = true, IdentityIncrement = 1)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        [ArchColoumn(ColoumnName = "ArchTest", DataType = "NVARCHAR(50)")]
        public string CustomColoumn { get; set; }
        [ArchIgnore]
        public string IgnoreMe { get; set; }
    }
}
