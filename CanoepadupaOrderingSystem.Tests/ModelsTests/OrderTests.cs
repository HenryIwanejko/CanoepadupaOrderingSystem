using NUnit.Framework;
using System;
using CanoepadupaOrderingSystem.Models;

namespace CanoepadupaOrderingSystem.Tests
{
    public class OrderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWhenOrderCreatedForAddingToDatabaseExpectCorrectProperties()
        {
            Order testOrder = new Order(0, 1, 10, DateTime.Today, 10);

            Assert.AreEqual(testOrder.OrderNumber, 0);
            Assert.AreEqual(testOrder.CustomerNumber, 1);
            Assert.AreEqual(testOrder.CustomerDiscount, 10);
            Assert.AreEqual(testOrder.OrderDate, DateTime.Today);
            Assert.AreEqual(testOrder.OrderTotal, 10);
            Assert.AreEqual(testOrder.OrderStatus, 1);
        }

        [Test]
        public void TestWhenOrderCreatedForRetrievingFromDatabaseExpectStringValueOfOrderStatus()
        {
            Order testOrder = new Order(1, 2, 5, DateTime.Today, 10, 1);

            Assert.AreEqual(testOrder.OrderNumber, 1);
            Assert.AreEqual(testOrder.CustomerNumber, 2);
            Assert.AreEqual(testOrder.CustomerDiscount, 0.95);
            Assert.AreEqual(testOrder.OrderDate, DateTime.Today);
            Assert.AreEqual(testOrder.OrderTotal, 10);
            Assert.AreEqual(testOrder.OrderStatus, 1);
            Assert.AreEqual(testOrder.DiscountedOrderTotal, 9.5);
        }

        [Test]
        public void TestWhenConvertOrderStatusCalledExpectCorrectStringReturned()
        {
            Order takenOrder = new Order(1, 2, 5, DateTime.Today, 10, 1);
            string takenStatus = takenOrder.ConvertOrderStatus();
            Assert.AreEqual(takenStatus, "Taken");

            Order dispatchedOrder = new Order(1, 2, 5, DateTime.Today, 10, 2);
            string dispatchedStatus = dispatchedOrder.ConvertOrderStatus();
            Assert.AreEqual(dispatchedStatus, "Dispatched");
        }
    }
}