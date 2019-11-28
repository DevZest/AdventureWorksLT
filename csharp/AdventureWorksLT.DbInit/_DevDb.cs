using DevZest.Data.DbInit;
using System.IO;

namespace DevZest.Samples.AdventureWorksLT
{
    /**********************************************************************************************************
     *  You can generate an empty database via right clicking anywhere in the code editor of this class in
     *  Visual Studio, then select "Generate Db..." context menu item.
     *  
     *  To do that, Visual Studio extension RDO.Tools is required. To install:
     *  Select Visual Studio menu "Tools" -> "Extensions and Update...", then search for "DevZest.Data.Tools".
     *  The extension requires Visual Studio 15.3 or later.
     *********************************************************************************************************/
    [EmptyDb]
    public sealed class _DevDb : DbSessionProvider<Db>
    {
        public override Db Create(string projectPath)
        {
            var dbFolder = Path.Combine(projectPath, @"LocalDb");
            string attachDbFilename = Path.Combine(dbFolder, "AdventureWorksLT.DbInit.mdf");
            File.Copy(Path.Combine(dbFolder, "EmptyDb.mdf"), attachDbFilename, true);
            File.Copy(Path.Combine(dbFolder, "EmptyDb_log.ldf"), Path.Combine(dbFolder, "AdventureWorksLT.DbInit_log.ldf"), true);
            var connectionString = string.Format(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{0}"";Integrated Security=True", attachDbFilename);
            return new Db(connectionString);
        }
    }
}
