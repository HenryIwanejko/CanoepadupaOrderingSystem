using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;
using System.Collections.Generic;

namespace CanoepadupaOrderingSystem.Tests
{
    public class OrderBasketTests
    {
        private Customer customer = new Customer(1, "customerName",
                "AddressLine1",
                "AddressLine2",
                "AddressLine3",
                "QF458RH",
                "8767876",
                "test@gmail.com",
                10,
                "Question?",
                "Answer");

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWhenCreatedExpectCorrectProperties()
        {
            OrderBasket orderBasket = new OrderBasket(customer);
            Assert.That(orderBasket.BasketItems.GetType() == typeof(List<BasketItem>));
            Assert.That(orderBasket.NumberOfProducts.GetType() == typeof(int));
            Assert.That(orderBasket.NumberOfItems.GetType() == typeof(int));
            Assert.That(orderBasket.BasketTotal.GetType() == typeof(decimal));
            Assert.That(orderBasket.BasketDiscountedTotal.GetType() == typeof(decimal));
            Assert.AreEqual(orderBasket.BasketItems.Count, 0);
            Assert.AreEqual(orderBasket.NumberOfProducts, 0);
            Assert.AreEqual(orderBasket.NumberOfItems, 0);
            Assert.AreEqual(orderBasket.BasketTotal, 0);
            Assert.AreEqual(orderBasket.BasketDiscountedTotal, 0);
        }

        [Test]
        public void TestAddItemWhenCalledExpectNewItemInBasket()
        {
            OrderBasket orderBasket = new OrderBasket(customer);
            BasketItem basketItem = new BasketItem(1, "productName", 5, 5, 10, "description");

            orderBasket.AddItem(basketItem);

            Assert.AreEqual(orderBasket.NumberOfProducts, 1);
            Assert.AreEqual(orderBasket.NumberOfItems, 10);
            Assert.AreEqual(orderBasket.BasketTotal, 50);
            Assert.AreEqual(orderBasket.BasketDiscountedTotal, 45);
        }

        [Test]
        public void TestRemoveItemWhenItemInBasket()
        {
            OrderBasket orderBasket = new OrderBasket(customer);
            BasketItem basketItem = new BasketItem(1, "productName", 5, 5, 10, "description");

            orderBasket.AddItem(basketItem);

            Assert.AreEqual(orderBasket.NumberOfProducts, 1);
            Assert.AreEqual(orderBasket.NumberOfItems, 10);
            Assert.AreEqual(orderBasket.BasketTotal, 50);
            Assert.AreEqual(orderBasket.BasketDiscountedTotal, 45);

            orderBasket.RemoveItem(basketItem.ProductNumber);

            Assert.AreEqual(orderBasket.NumberOfProducts, 0);
            Assert.AreEqual(orderBasket.NumberOfItems, 0);
            Assert.AreEqual(orderBasket.BasketTotal, 0);
            Assert.AreEqual(orderBasket.BasketDiscountedTotal, 0);
        }

        [Test]
        public void TestCheckIfBasketAlreadyContainsProduct()
        {
            OrderBasket orderBasket = new OrderBasket(customer);
            BasketItem basketItem = new BasketItem(1, "productName", 5, 5, 10, "description");

            orderBasket.AddItem(basketItem);

            BasketItem retrievedbasketItem = orderBasket.CheckIfBasketAlreadyContainsProduct(basketItem.ProductNumber);

            Assert.AreEqual(retrievedbasketItem.ProductNumber, 1);
            Assert.AreEqual(retrievedbasketItem.ProductName, "productName");
            Assert.AreEqual(retrievedbasketItem.WholesalePrice, 5);
            Assert.AreEqual(retrievedbasketItem.RecommendRetailPrice, 5);
            Assert.AreEqual(retrievedbasketItem.Quantity, 10);
            Assert.AreEqual(retrievedbasketItem.Description, "description");
            Assert.AreEqual(retrievedbasketItem.TotalValueOfBasketItem, 50);
        }

        [Test]
        public void TestClearBasketItems()
        {
            OrderBasket orderBasket = new OrderBasket(customer);
            BasketItem basketItem = new BasketItem(1, "productName", 5, 5, 10, "description");

            orderBasket.AddItem(basketItem);

            Assert.AreEqual(orderBasket.NumberOfProducts, 1);
            Assert.AreEqual(orderBasket.NumberOfItems, 10);
            Assert.AreEqual(orderBasket.BasketTotal, 50);
            Assert.AreEqual(orderBasket.BasketDiscountedTotal, 45);

            orderBasket.ClearBasket();

            Assert.AreEqual(orderBasket.NumberOfProducts, 0);
            Assert.AreEqual(orderBasket.NumberOfItems, 0);
            Assert.AreEqual(orderBasket.BasketTotal, 0);
            Assert.AreEqual(orderBasket.BasketDiscountedTotal, 0);
        }

        [Test]
        public void TestIsBasketEmpty()
        {
            OrderBasket orderBasket = new OrderBasket(customer);
            BasketItem basketItem = new BasketItem(1, "productName", 5, 5, 10, "description");

            Assert.AreEqual(orderBasket.IsBasketEmpty(), true);

            orderBasket.AddItem(basketItem);

            Assert.AreEqual(orderBasket.IsBasketEmpty(), false);
        }
    }
}
