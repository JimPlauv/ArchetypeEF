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
                .SetConnectionString("Server=127.0.0.1,1433;Database=ArchTest;User Id=sa;Password=BONGOjoey1105;")
                .RunMigrationAtStartUp()
                .Init();

            System.Console.WriteLine(ConfigurationManager.Config.Source);
        }
    }
}
