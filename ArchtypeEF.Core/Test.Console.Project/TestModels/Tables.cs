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
    }
}
