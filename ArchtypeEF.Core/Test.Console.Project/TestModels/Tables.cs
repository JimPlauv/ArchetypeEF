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

    [ArchTable(tableName = "CustomNameTable")]
    public class TableB
    {
    }
}
