using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;

namespace CanoepadupaOrderingSystem.Tests
{
    public class ProductItemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWhenProductCreatedHasCorrectProperties()
        {
            ProductItem productItem = new ProductItem(1, "productName");
            Assert.That(productItem.ID.GetType() == typeof(int));
            Assert.That(productItem.Text.GetType() == typeof(string));
            Assert.AreEqual(productItem.ID, 1);
            Assert.AreEqual(productItem.Text, "productName");
        }
    }
}