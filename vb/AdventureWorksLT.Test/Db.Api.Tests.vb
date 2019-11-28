Imports System.IO
Imports System.Reflection
Imports DevZest.Data
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class DbTests
    Private Shared Function GetConnectionString() As String
        Dim mdfFilename = "AdventureWorksLT.mdf"
        Dim outputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)
        Dim attachDbFilename = Path.Combine(outputFolder, mdfFilename)
        Return String.Format("Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{0}"";Integrated Security=True", attachDbFilename)
    End Function

    Private Shared Function CreateDb() As Db
        Return New Db(GetConnectionString)
    End Function

    <TestMethod>
    Public Async Function Db_GetSalesOrderHeadersAsync() As Task
        Using db = Await MockSalesOrder.CreateAsync(CreateDb)
            Dim result = Await db.GetSalesOrderHeadersAsync(Nothing, Nothing)
            Assert.AreEqual(4, result.Count)
        End Using
    End Function

    <TestMethod>
    Public Async Function Db_GetSalesOrderHeadersAsync_filter() As Task
        Using db = Await MockSalesOrder.CreateAsync(CreateDb)
            Dim result = Await db.GetSalesOrderHeadersAsync("PO19952192051", Nothing)
            Assert.AreEqual(1, result.Count)
            Assert.AreEqual("PO19952192051", result.Entity.PurchaseOrderNumber(0))
        End Using
    End Function

    <TestMethod>
    Public Async Function Db_GetSalesOrderHeadersAsync_sort() As Task
        Dim orderBy = New IColumnComparer() {DataRow.OrderBy(New SalesOrderHeader().PurchaseOrderNumber, SortDirection.Descending)}

        Using db = Await MockSalesOrder.CreateAsync(CreateDb)
            Dim result = Await db.GetSalesOrderHeadersAsync(Nothing, orderBy)
            Assert.AreEqual(4, result.Count)
            Dim entity = result.Entity
            Assert.AreEqual("PO348186287", entity.PurchaseOrderNumber(0))
            Assert.AreEqual("PO19952192051", entity.PurchaseOrderNumber(1))
            Assert.AreEqual("PO19604173239", entity.PurchaseOrderNumber(2))
            Assert.AreEqual("PO19372114749", entity.PurchaseOrderNumber(3))
        End Using
    End Function

    <TestMethod>
    Public Async Function Db_GetSalesOrderInfoAsync() As Task
        Using db = CreateDb()
            Dim result = Await db.GetSalesOrderInfoAsync(71774)
            Assert.AreEqual(1, result.Count)
            Assert.AreEqual(71774, result.Entity.SalesOrderID(0))
        End Using
    End Function

    <TestMethod>
    Public Async Function Db_DeleteSalesOrder() As Task
        Dim salesOrders = DataSet(Of SalesOrderHeader.Key).Create
        salesOrders.AddRow(
            Sub(x)
                salesOrders.Entity.SalesOrderID(x) = 1
            End Sub)

        Using db = Await MockSalesOrder.CreateAsync(CreateDb)
            Await db.DeleteSalesOrderAsync(salesOrders)
            Assert.AreEqual(3, Await db.SalesOrderHeader.CountAsync)
        End Using
    End Function
End Class
