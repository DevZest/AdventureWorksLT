﻿Imports System.Threading
Imports DevZest.Data
Imports DevZest.Data.Primitives
Imports DevZest.Data.DbInit

'*****************************************************************************************************************************
'*  You can generate testing data by:
'*  1. Right click anywhere in the code editor of this class in Visual Studio, then select "Generate Db..." context menu item,
'*     a local database \LocalDb\AdventureWorksLT.DbInit.mdf (as defined in class _DevDb) will be generated.
'*  2. Use SQL Server Management Studio to open this local database And edit table data;
'*  3. Right click anywhere in the code editor of this class in Visual Studio, then select "Generate DataSet..." context menu
'*     item, the testing data code will be generated automatically for method Headers() And Details().
'*  
'*  To do that, Visual Studio extension RDO.Tools Is required. To install:
'*  Select Visual Studio menu "Tools" -> "Extensions and Update...", then search for "DevZest.Data.Tools".
'*  The extension requires Visual Studio 15.3 Or later.
'*****************************************************************************************************************************

Public Class MockSalesOrder
    Inherits DbMock(Of Db)

    Public Shared Function CreateAsync(db As Db, Optional progress As IProgress(Of DbInitProgress) = Nothing, Optional ct As CancellationToken = Nothing) As Task(Of Db)
        Return New MockSalesOrder().MockAsync(db, progress, ct)
    End Function

    '*******************************************************************
    '*  The body of this method Is generated automatically by RDO.Tools.
    '*******************************************************************
    Private Shared Function Headers() As DataSet(Of SalesOrderHeader)
        Dim result As DataSet(Of SalesOrderHeader) = DataSet(Of SalesOrderHeader).Create().AddRows(4)
        Dim x As SalesOrderHeader = result.Entity
        x.SuspendIdentity()
        x.SalesOrderID(0) = 1
        x.SalesOrderID(1) = 2
        x.SalesOrderID(2) = 3
        x.SalesOrderID(3) = 4
        x.RevisionNumber(0) = CByte(2)
        x.RevisionNumber(1) = CByte(2)
        x.RevisionNumber(2) = CByte(2)
        x.RevisionNumber(3) = CByte(2)
        x.OrderDate(0) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.OrderDate(1) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.OrderDate(2) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.OrderDate(3) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.DueDate(0) = Convert.ToDateTime("2008-06-13T00:00:00.000")
        x.DueDate(1) = Convert.ToDateTime("2008-06-13T00:00:00.000")
        x.DueDate(2) = Convert.ToDateTime("2008-06-13T00:00:00.000")
        x.DueDate(3) = Convert.ToDateTime("2008-06-13T00:00:00.000")
        x.ShipDate(0) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.ShipDate(1) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.ShipDate(2) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.ShipDate(3) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.Status(0) = SalesOrderStatus.Shipped
        x.Status(1) = SalesOrderStatus.Shipped
        x.Status(2) = SalesOrderStatus.Shipped
        x.Status(3) = SalesOrderStatus.Shipped
        x.OnlineOrderFlag(0) = False
        x.OnlineOrderFlag(1) = False
        x.OnlineOrderFlag(2) = False
        x.OnlineOrderFlag(3) = False
        x.PurchaseOrderNumber(0) = "PO348186287"
        x.PurchaseOrderNumber(1) = "PO19952192051"
        x.PurchaseOrderNumber(2) = "PO19604173239"
        x.PurchaseOrderNumber(3) = "PO19372114749"
        x.AccountNumber(0) = "10-4020-000609"
        x.AccountNumber(1) = "10-4020-000106"
        x.AccountNumber(2) = "10-4020-000340"
        x.AccountNumber(3) = "10-4020-000582"
        x.CustomerID(0) = 29847
        x.CustomerID(1) = 30072
        x.CustomerID(2) = 30113
        x.CustomerID(3) = 29485
        x.ShipToAddressID(0) = 1092
        x.ShipToAddressID(1) = 640
        x.ShipToAddressID(2) = 653
        x.ShipToAddressID(3) = 1086
        x.BillToAddressID(0) = 1092
        x.BillToAddressID(1) = 640
        x.BillToAddressID(2) = 653
        x.BillToAddressID(3) = 1086
        x.ShipMethod(0) = "CARGO TRANSPORT 5"
        x.ShipMethod(1) = "CARGO TRANSPORT 5"
        x.ShipMethod(2) = "CARGO TRANSPORT 5"
        x.ShipMethod(3) = "CARGO TRANSPORT 5"
        x.CreditCardApprovalCode(0) = Nothing
        x.CreditCardApprovalCode(1) = Nothing
        x.CreditCardApprovalCode(2) = Nothing
        x.CreditCardApprovalCode(3) = Nothing
        x.SubTotal(0) = 880.3484D
        x.SubTotal(1) = 78.81D
        x.SubTotal(2) = 38418.6895D
        x.SubTotal(3) = 39785.3304D
        x.TaxAmt(0) = 70.4279D
        x.TaxAmt(1) = 6.3048D
        x.TaxAmt(2) = 3073.4952D
        x.TaxAmt(3) = 3182.8264D
        x.Freight(0) = 22.0087D
        x.Freight(1) = 1.9703D
        x.Freight(2) = 960.4672D
        x.Freight(3) = 994.6333D
        x.Comment(0) = Nothing
        x.Comment(1) = Nothing
        x.Comment(2) = Nothing
        x.Comment(3) = Nothing
        x.RowGuid(0) = New Guid("89e42cdc-8506-48a2-b89b-eb3e64e3554e")
        x.RowGuid(1) = New Guid("8a3448c5-e677-4158-a29b-dd33069be0b0")
        x.RowGuid(2) = New Guid("a47665d2-7ac9-4cf3-8a8b-2a3883554284")
        x.RowGuid(3) = New Guid("f1be45a5-5c57-4a50-93c6-5f8be44cb7cb")
        x.ModifiedDate(0) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.ModifiedDate(1) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.ModifiedDate(2) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.ModifiedDate(3) = Convert.ToDateTime("2008-06-08T00:00:00.000")
        x.ResumeIdentity()
        Return result
    End Function

    '*******************************************************************
    '*  The body of this method Is generated automatically by RDO.Tools.
    '*******************************************************************
    Private Shared Function Details() As DataSet(Of SalesOrderDetail)
        Dim result As DataSet(Of SalesOrderDetail) = DataSet(Of SalesOrderDetail).Create().AddRows(32)
        Dim x As SalesOrderDetail = result.Entity
        x.SuspendIdentity()
        x.SalesOrderID(0) = 1
        x.SalesOrderID(1) = 1
        x.SalesOrderID(2) = 2
        x.SalesOrderID(3) = 3
        x.SalesOrderID(4) = 3
        x.SalesOrderID(5) = 3
        x.SalesOrderID(6) = 3
        x.SalesOrderID(7) = 3
        x.SalesOrderID(8) = 3
        x.SalesOrderID(9) = 3
        x.SalesOrderID(10) = 3
        x.SalesOrderID(11) = 3
        x.SalesOrderID(12) = 3
        x.SalesOrderID(13) = 3
        x.SalesOrderID(14) = 3
        x.SalesOrderID(15) = 3
        x.SalesOrderID(16) = 3
        x.SalesOrderID(17) = 3
        x.SalesOrderID(18) = 3
        x.SalesOrderID(19) = 3
        x.SalesOrderID(20) = 3
        x.SalesOrderID(21) = 3
        x.SalesOrderID(22) = 3
        x.SalesOrderID(23) = 3
        x.SalesOrderID(24) = 3
        x.SalesOrderID(25) = 3
        x.SalesOrderID(26) = 3
        x.SalesOrderID(27) = 3
        x.SalesOrderID(28) = 3
        x.SalesOrderID(29) = 3
        x.SalesOrderID(30) = 3
        x.SalesOrderID(31) = 3
        x.SalesOrderDetailID(0) = 1
        x.SalesOrderDetailID(1) = 2
        x.SalesOrderDetailID(2) = 3
        x.SalesOrderDetailID(3) = 4
        x.SalesOrderDetailID(4) = 5
        x.SalesOrderDetailID(5) = 6
        x.SalesOrderDetailID(6) = 7
        x.SalesOrderDetailID(7) = 8
        x.SalesOrderDetailID(8) = 9
        x.SalesOrderDetailID(9) = 10
        x.SalesOrderDetailID(10) = 11
        x.SalesOrderDetailID(11) = 12
        x.SalesOrderDetailID(12) = 13
        x.SalesOrderDetailID(13) = 14
        x.SalesOrderDetailID(14) = 15
        x.SalesOrderDetailID(15) = 16
        x.SalesOrderDetailID(16) = 17
        x.SalesOrderDetailID(17) = 18
        x.SalesOrderDetailID(18) = 19
        x.SalesOrderDetailID(19) = 20
        x.SalesOrderDetailID(20) = 21
        x.SalesOrderDetailID(21) = 22
        x.SalesOrderDetailID(22) = 23
        x.SalesOrderDetailID(23) = 24
        x.SalesOrderDetailID(24) = 25
        x.SalesOrderDetailID(25) = 26
        x.SalesOrderDetailID(26) = 27
        x.SalesOrderDetailID(27) = 28
        x.SalesOrderDetailID(28) = 29
        x.SalesOrderDetailID(29) = 30
        x.SalesOrderDetailID(30) = 31
        x.SalesOrderDetailID(31) = 32
        x.OrderQty(0) = 1S
        x.OrderQty(1) = 1S
        x.OrderQty(2) = 1S
        x.OrderQty(3) = 4S
        x.OrderQty(4) = 2S
        x.OrderQty(5) = 6S
        x.OrderQty(6) = 2S
        x.OrderQty(7) = 1S
        x.OrderQty(8) = 1S
        x.OrderQty(9) = 1S
        x.OrderQty(10) = 4S
        x.OrderQty(11) = 2S
        x.OrderQty(12) = 4S
        x.OrderQty(13) = 1S
        x.OrderQty(14) = 6S
        x.OrderQty(15) = 1S
        x.OrderQty(16) = 2S
        x.OrderQty(17) = 3S
        x.OrderQty(18) = 1S
        x.OrderQty(19) = 2S
        x.OrderQty(20) = 2S
        x.OrderQty(21) = 3S
        x.OrderQty(22) = 3S
        x.OrderQty(23) = 2S
        x.OrderQty(24) = 3S
        x.OrderQty(25) = 5S
        x.OrderQty(26) = 3S
        x.OrderQty(27) = 1S
        x.OrderQty(28) = 2S
        x.OrderQty(29) = 1S
        x.OrderQty(30) = 7S
        x.OrderQty(31) = 1S
        x.ProductID(0) = 836
        x.ProductID(1) = 822
        x.ProductID(2) = 907
        x.ProductID(3) = 905
        x.ProductID(4) = 983
        x.ProductID(5) = 988
        x.ProductID(6) = 748
        x.ProductID(7) = 990
        x.ProductID(8) = 926
        x.ProductID(9) = 743
        x.ProductID(10) = 782
        x.ProductID(11) = 918
        x.ProductID(12) = 780
        x.ProductID(13) = 937
        x.ProductID(14) = 867
        x.ProductID(15) = 985
        x.ProductID(16) = 989
        x.ProductID(17) = 991
        x.ProductID(18) = 992
        x.ProductID(19) = 993
        x.ProductID(20) = 984
        x.ProductID(21) = 986
        x.ProductID(22) = 987
        x.ProductID(23) = 981
        x.ProductID(24) = 982
        x.ProductID(25) = 783
        x.ProductID(26) = 809
        x.ProductID(27) = 810
        x.ProductID(28) = 935
        x.ProductID(29) = 925
        x.ProductID(30) = 869
        x.ProductID(31) = 880
        x.UnitPrice(0) = 356.898D
        x.UnitPrice(1) = 356.898D
        x.UnitPrice(2) = 63.9D
        x.UnitPrice(3) = 218.454D
        x.UnitPrice(4) = 461.694D
        x.UnitPrice(5) = 112.998D
        x.UnitPrice(6) = 818.7D
        x.UnitPrice(7) = 323.994D
        x.UnitPrice(8) = 149.874D
        x.UnitPrice(9) = 809.76D
        x.UnitPrice(10) = 1376.994D
        x.UnitPrice(11) = 158.43D
        x.UnitPrice(12) = 1391.994D
        x.UnitPrice(13) = 48.594D
        x.UnitPrice(14) = 41.994D
        x.UnitPrice(15) = 112.998D
        x.UnitPrice(16) = 323.994D
        x.UnitPrice(17) = 323.994D
        x.UnitPrice(18) = 323.994D
        x.UnitPrice(19) = 323.994D
        x.UnitPrice(20) = 112.998D
        x.UnitPrice(21) = 112.998D
        x.UnitPrice(22) = 112.998D
        x.UnitPrice(23) = 461.694D
        x.UnitPrice(24) = 461.694D
        x.UnitPrice(25) = 1376.994D
        x.UnitPrice(26) = 37.152D
        x.UnitPrice(27) = 72.162D
        x.UnitPrice(28) = 24.294D
        x.UnitPrice(29) = 149.874D
        x.UnitPrice(30) = 41.994D
        x.UnitPrice(31) = 32.994D
        x.UnitPriceDiscount(0) = 0D
        x.UnitPriceDiscount(1) = 0D
        x.UnitPriceDiscount(2) = 0D
        x.UnitPriceDiscount(3) = 0D
        x.UnitPriceDiscount(4) = 0D
        x.UnitPriceDiscount(5) = 0.4D
        x.UnitPriceDiscount(6) = 0D
        x.UnitPriceDiscount(7) = 0D
        x.UnitPriceDiscount(8) = 0D
        x.UnitPriceDiscount(9) = 0D
        x.UnitPriceDiscount(10) = 0D
        x.UnitPriceDiscount(11) = 0D
        x.UnitPriceDiscount(12) = 0D
        x.UnitPriceDiscount(13) = 0D
        x.UnitPriceDiscount(14) = 0D
        x.UnitPriceDiscount(15) = 0.4D
        x.UnitPriceDiscount(16) = 0D
        x.UnitPriceDiscount(17) = 0D
        x.UnitPriceDiscount(18) = 0D
        x.UnitPriceDiscount(19) = 0D
        x.UnitPriceDiscount(20) = 0.4D
        x.UnitPriceDiscount(21) = 0.4D
        x.UnitPriceDiscount(22) = 0.4D
        x.UnitPriceDiscount(23) = 0D
        x.UnitPriceDiscount(24) = 0D
        x.UnitPriceDiscount(25) = 0D
        x.UnitPriceDiscount(26) = 0D
        x.UnitPriceDiscount(27) = 0D
        x.UnitPriceDiscount(28) = 0D
        x.UnitPriceDiscount(29) = 0D
        x.UnitPriceDiscount(30) = 0D
        x.UnitPriceDiscount(31) = 0D
        x.RowGuid(0) = New Guid("e3a1994c-7a68-4ce8-96a3-77fdd3bbd730")
        x.RowGuid(1) = New Guid("5c77f557-fdb6-43ba-90b9-9a7aec55ca32")
        x.RowGuid(2) = New Guid("6dbfe398-d15d-425e-aa58-88178fe360e5")
        x.RowGuid(3) = New Guid("377246c9-4483-48ed-a5b9-e56f005364e0")
        x.RowGuid(4) = New Guid("43a54bcd-536d-4a1b-8e69-24d083507a14")
        x.RowGuid(5) = New Guid("12706fab-f3a2-48c6-b7c7-1ccde4081f18")
        x.RowGuid(6) = New Guid("b12f0d3b-5b4e-4f1f-b2f0-f7cde99dd826")
        x.RowGuid(7) = New Guid("f117a449-039d-44b8-a4b2-b12001dacc01")
        x.RowGuid(8) = New Guid("92e5052b-72d0-4c91-9a8c-42591803667e")
        x.RowGuid(9) = New Guid("8bd33bed-c4f6-4d44-84fb-a7d04afcd794")
        x.RowGuid(10) = New Guid("686999fb-42e6-4d00-9a14-83ffa86833e3")
        x.RowGuid(11) = New Guid("82940b03-c70b-4183-8660-6b3418908429")
        x.RowGuid(12) = New Guid("644b0cd6-b2c3-4e4d-ab43-091c2ef6c829")
        x.RowGuid(13) = New Guid("7f5feb17-8ef4-4236-9f1c-15046d9638f0")
        x.RowGuid(14) = New Guid("ac78838d-b503-41a5-9791-480e528f028c")
        x.RowGuid(15) = New Guid("2c10a282-a13d-442a-8f45-f4d6b23a7d9c")
        x.RowGuid(16) = New Guid("654fb79e-70df-4b92-9832-9fa67013215b")
        x.RowGuid(17) = New Guid("3d6ca7ab-055e-4536-8940-76234cc9bcde")
        x.RowGuid(18) = New Guid("560feee1-dd54-4c34-abb1-4f8841d0aa41")
        x.RowGuid(19) = New Guid("19570052-4023-4658-bc56-dc5c619bd00e")
        x.RowGuid(20) = New Guid("27562675-f8c3-4a38-bd9e-b366b83e5204")
        x.RowGuid(21) = New Guid("e193ce39-ef33-4969-87b1-468d2f7b48ad")
        x.RowGuid(22) = New Guid("e38e076f-5072-437a-a771-ada53b5ab803")
        x.RowGuid(23) = New Guid("26c00b7d-6e19-4fbf-b9f1-23c2609e8893")
        x.RowGuid(24) = New Guid("6666a81b-90a1-4204-a39e-9f660ca43e5f")
        x.RowGuid(25) = New Guid("332dcf9e-dfd2-4345-9015-f4b53ac396ee")
        x.RowGuid(26) = New Guid("c2b08405-a9be-4f71-906c-5d7b1e26bde4")
        x.RowGuid(27) = New Guid("351a29fb-ceb1-4ca6-bb36-506d87b82a95")
        x.RowGuid(28) = New Guid("1918cfd2-69e8-4593-b4d6-8677f18b8f62")
        x.RowGuid(29) = New Guid("21624302-ca0f-402f-8a46-5a3fffa7d5f3")
        x.RowGuid(30) = New Guid("169c75f6-a364-46e3-8ddb-033528177458")
        x.RowGuid(31) = New Guid("c3fbb3ec-3ff6-4ee1-88cf-230e128815f3")
        x.ModifiedDate(0) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(1) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(2) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(3) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(4) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(5) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(6) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(7) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(8) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(9) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(10) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(11) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(12) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(13) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(14) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(15) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(16) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(17) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(18) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(19) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(20) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(21) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(22) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(23) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(24) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(25) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(26) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(27) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(28) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(29) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(30) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ModifiedDate(31) = Convert.ToDateTime("2008-06-01T00:00:00.000")
        x.ResumeIdentity()
        Return result
    End Function

    Protected Overrides Sub Initialize()
        Mock(Db.SalesOrderHeader, AddressOf Headers)
        Mock(Db.SalesOrderDetail, AddressOf Details)
    End Sub
End Class
