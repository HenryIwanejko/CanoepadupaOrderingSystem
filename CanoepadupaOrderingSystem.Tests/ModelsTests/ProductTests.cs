using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;

namespace CanoepadupaOrderingSystem.Tests
{
    public class ProductTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWhenProductCreatedHasCorrectProperties()
        {
            Product product = new Product(1, "name", "description", 10, 8);
            Assert.That(product.ProductNumber.GetType() == typeof(int));
            Assert.That(product.ProductName.GetType() == typeof(string));
            Assert.That(product.Description.GetType() == typeof(string));
            Assert.That(product.RecommondedRetailPrice.GetType() == typeof(decimal));
            Assert.That(product.WholesalePrice.GetType() == typeof(decimal));
            Assert.AreEqual(product.ProductNumber, 1);
            Assert.AreEqual(product.ProductName, "name");
            Assert.AreEqual(product.Description, "description");
            Assert.AreEqual(product.RecommondedRetailPrice, 10);
            Assert.AreEqual(product.WholesalePrice, 8);
        }
    }
}
