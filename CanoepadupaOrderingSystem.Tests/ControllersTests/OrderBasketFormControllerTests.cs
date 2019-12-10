using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Controllers;
using System.Collections.Generic;

namespace CanoepadupaOrderingSystem.Tests
{
    public class OrderBasketFormControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetProductExpectProductReturned()
        {
            List<Product> testListOfProducts = new List<Product>();
            Product product = new Product(1, "name", "description", 10, 8);
            testListOfProducts.Add(product);

            OrderBasketFormController orderBasketFormController = new OrderBasketFormController(testListOfProducts);

            Product retrievedProduct = orderBasketFormController.GetProduct(1);

            Assert.AreEqual(retrievedProduct, product);

            retrievedProduct = orderBasketFormController.GetProduct(4);

            Assert.AreEqual(retrievedProduct, null);
        }

        [Test]
        public void TestgetFromText()
        {
            Customer customer = new Customer(1, "customerName",
                "AddressLine1",
                "AddressLine2",
                "AddressLine3",
                "QF458RH",
                "8767876",
                "test@gmail.com",
                10,
                "Question?",
                "Answer");

            List<Product> testListOfProducts = new List<Product>();
            OrderBasketFormController orderBasketFormController = new OrderBasketFormController(testListOfProducts);

            string formText = orderBasketFormController.GetFormText(customer);

            Assert.AreEqual(formText, "Current Customer: customerName, Discount: 10%");
        }
    }
}