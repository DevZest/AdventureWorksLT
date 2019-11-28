using DevZest.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace DevZest.Samples.AdventureWorksLT
{
    [TestClass]
    public class DbTests
    {
        private static string GetConnectionString()
        {
            string mdfFilename = "AdventureWorksLT.mdf";
            string outputFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string attachDbFilename = Path.Combine(outputFolder, mdfFilename);
            return string.Format(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{0}"";Integrated Security=True", attachDbFilename);
        }

        private static Db CreateDb()
        {
            return new Db(GetConnectionString());
        }

        [TestMethod]
        public async Task Db_GetSalesOrderHeadersAsync()
        {
            using (var db = await MockSalesOrder.CreateAsync(CreateDb()))
            {
                var result = await db.GetSalesOrderHeadersAsync(null, null);
                Assert.AreEqual(4, result.Count);
            }
        }

        [TestMethod]
        public async Task Db_GetSalesOrderHeadersAsync_filter()
        {
            using (var db = await MockSalesOrder.CreateAsync(CreateDb()))
            {
                var result = await db.GetSalesOrderHeadersAsync("PO19952192051", null);
                Assert.AreEqual(1, result.Count);
                Assert.AreEqual("PO19952192051", result._.PurchaseOrderNumber[0]);
            }
        }

        [TestMethod]
        public async Task Db_GetSalesOrderHeadersAsync_sort()
        {
            var orderBy = new IColumnComparer[] { DataRow.OrderBy(new SalesOrderHeader().PurchaseOrderNumber, SortDirection.Descending) };
            using (var db = await MockSalesOrder.CreateAsync(CreateDb()))
            {
                var result = await db.GetSalesOrderHeadersAsync(null, orderBy);
                Assert.AreEqual(4, result.Count);
                var _ = result._;
                Assert.AreEqual("PO348186287", _.PurchaseOrderNumber[0]);
                Assert.AreEqual("PO19952192051", _.PurchaseOrderNumber[1]);
                Assert.AreEqual("PO19604173239", _.PurchaseOrderNumber[2]);
                Assert.AreEqual("PO19372114749", _.PurchaseOrderNumber[3]);
            }
        }

        [TestMethod]
        public async Task Db_GetSalesOrderInfoAsync()
        {
            using (var db = CreateDb())
            {
                var result = await db.GetSalesOrderInfoAsync(71774);
                Assert.AreEqual(1, result.Count);
                var _ = result._;
                Assert.AreEqual(71774, _.SalesOrderID[0]);
            }
        }

        [TestMethod]
        public async Task Db_InsertSalesOrder()
        {
            var salesOrder = DataSet<SalesOrder>.Create();
            salesOrder.AddRow(x =>
            {
                var _ = salesOrder._;
                _.RevisionNumber[x] = 2;
                _.OrderDate[x] = new DateTime(2008, 6, 1);
                _.DueDate[x] = new DateTime(2008, 6, 13);
                _.Status[x] = SalesOrderStatus.InProcess;
                _.CustomerID[x] = 29847;
                _.ShipMethod[x] = "CARGO TRANSPORT 5";
            });
            var salesOrderDetails = salesOrder._.SalesOrderDetails.GetChildDataSet(0);
            salesOrderDetails.AddRow(x =>
            {
                var _ = salesOrderDetails._;
                _.ProductID[x] = 1;
                _.OrderQty[x] = 1;
                _.UnitPrice[x] = 100;
            });

            using (var db = await MockEmptySalesOrder.CreateAsync(CreateDb()))
            {
                await db.InsertAsync(salesOrder);

                Assert.AreEqual(1, await db.SalesOrderHeader.CountAsync());
                Assert.AreEqual(1, await db.SalesOrderDetail.CountAsync());
            }
        }

        [TestMethod]
        public async Task Db_DeleteSalesOrder()
        {
            var salesOrders = DataSet<SalesOrderHeader.Key>.Create();
            salesOrders.AddRow(x =>
            {
                salesOrders._.SalesOrderID[x] = 1;
            });

            using (var db = await MockSalesOrder.CreateAsync(CreateDb()))
            {
                await db.DeleteSalesOrderAsync(salesOrders);
                Assert.AreEqual(3, await db.SalesOrderHeader.CountAsync());
            }
        }
    }
}