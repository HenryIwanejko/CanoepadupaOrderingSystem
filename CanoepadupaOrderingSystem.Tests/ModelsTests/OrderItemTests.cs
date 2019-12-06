using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;

namespace CanoepadupaOrderingSystem.Tests
{
    public class OrderItemTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestWhenOrderItemCreatedExpectCorrectProperties()
        {
            OrderItem orderItem = new OrderItem(1, 10, 20, 4);
            Assert.That(orderItem.OrderNumber.GetType() == typeof(int));
            Assert.That(orderItem.ProductNumber.GetType() == typeof(int));
            Assert.That(orderItem.PurchasePrice.GetType() == typeof(decimal));
            Assert.That(orderItem.Quantity.GetType() == typeof(int));
            Assert.AreEqual(orderItem.OrderNumber, 1);
            Assert.AreEqual(orderItem.ProductNumber, 10);
            Assert.AreEqual(orderItem.PurchasePrice, 20);
            Assert.AreEqual(orderItem.Quantity, 4);
        }

        [Test]
        public void TestWhenOrderItemCreatedForRetrievingFromTheDatabaseExpectCorrectProperties()
        {
            OrderItem orderItem = new OrderItem(1, 1, 4, 20, 4);
            Assert.That(orderItem.OrderItemNumber.GetType() == typeof(int));
            Assert.That(orderItem.OrderNumber.GetType() == typeof(int));
            Assert.That(orderItem.ProductNumber.GetType() == typeof(int));
            Assert.That(orderItem.PurchasePrice.GetType() == typeof(decimal));
            Assert.That(orderItem.Quantity.GetType() == typeof(int));
            Assert.AreEqual(orderItem.OrderItemNumber, 1);
            Assert.AreEqual(orderItem.OrderNumber, 1);
            Assert.AreEqual(orderItem.ProductNumber, 4);
            Assert.AreEqual(orderItem.PurchasePrice, 20);
            Assert.AreEqual(orderItem.Quantity, 4);
        }
    }
}