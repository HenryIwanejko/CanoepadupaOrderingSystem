using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;

namespace CanoepadupaOrderingSystem.Tests
{
    public class BasketItemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWhenBasketItemModelCreatedExpectCorrectProperties()
        {
            BasketItem basketItem = new BasketItem(1, "productName", 5, 5, 10, "description");

            Assert.That(basketItem.ProductNumber.GetType() == typeof(int));
            Assert.That(basketItem.ProductName.GetType() == typeof(string));
            Assert.That(basketItem.WholesalePrice.GetType() == typeof(decimal));
            Assert.That(basketItem.RecommendRetailPrice.GetType() == typeof(decimal));
            Assert.That(basketItem.Quantity.GetType() == typeof(int));
            Assert.That(basketItem.Description.GetType() == typeof(string));
            Assert.AreEqual(basketItem.ProductNumber, 1);
            Assert.AreEqual(basketItem.ProductName, "productName");
            Assert.AreEqual(basketItem.WholesalePrice, 5);
            Assert.AreEqual(basketItem.RecommendRetailPrice, 5);
            Assert.AreEqual(basketItem.Quantity, 10);
            Assert.AreEqual(basketItem.Description, "description");
            Assert.AreEqual(basketItem.TotalValueOfBasketItem, 50);
        }

        [Test]
        public void TestWhenBasketItemModelIncreaseQuantityCalledExpectQuantityChanged()
        {
            BasketItem basketItem = new BasketItem(1, "productName", 5, 5, 10, "description");

            Assert.AreEqual(basketItem.Quantity, 10);

            basketItem.IncreaseQuantity(5);

            Assert.AreEqual(basketItem.Quantity, 15);
        }
    }
}