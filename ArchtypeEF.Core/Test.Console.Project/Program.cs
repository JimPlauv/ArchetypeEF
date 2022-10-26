using ArchtypeEF.Core;
using System;

namespace Test.Console.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder
                .SetSource(ArchtypeEF.Core.CoreType.SourceType.MSSQL)
                .RunMigrationAtStartUp()
                .Init();

            System.Console.WriteLine(ConfigurationManager.Config.SourceType);
        }
    }
}
