Imports System.IO
Imports DevZest.Data.DbInit

'**********************************************************************************************************
'*  You can generate an empty database via right clicking anywhere in the code editor of this class in
'*  Visual Studio, then select "Generate Db..." context menu item.
'*  
'*  To do that, Visual Studio extension RDO.Tools Is required. To install:
'*  Select Visual Studio menu "Tools" -> "Extensions and Update...", then search for "DevZest.Data.Tools".
'*  The extension requires Visual Studio 15.3 Or later.
'**********************************************************************************************************

<EmptyDb>
Public Class _DevDb
    Inherits DbSessionProvider(Of Db)

    Public Overrides Function Create(projectPath As String) As Db
        Dim dbFolder = Path.Combine(projectPath, "LocalDb")
        Dim attachDbFilename = Path.Combine(dbFolder, "AdventureWorksLT.DbInit.mdf")
        File.Copy(Path.Combine(dbFolder, "EmptyDb.mdf"), attachDbFilename, True)
        File.Copy(Path.Combine(dbFolder, "EmptyDb_log.ldf"), Path.Combine(dbFolder, "AdventureWorksLT.DbInit_log.ldf"), True)
        Dim connectionString = String.Format("Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{0}"";Integrated Security=True", attachDbFilename)
        Return New Db(connectionString)
    End Function
End Class
