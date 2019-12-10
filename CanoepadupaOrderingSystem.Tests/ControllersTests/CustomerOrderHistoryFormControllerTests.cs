using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Controllers;
using System.Collections.Generic;
using System;

namespace CanoepadupaOrderingSystem.Tests
{
    public class CustomerOrderHistoryFormControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetFormText()
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

            CustomerOrderHistoryFormController customerOrderHistoryFormController = new CustomerOrderHistoryFormController();

            string formText = customerOrderHistoryFormController.GetFormText(customer);

            Assert.AreEqual(formText, "Current Customer: customerName, Discount: 10%");
        }

        [Test]
        public void TestGetOrder()
        {
            CustomerOrderHistoryFormController customerOrderHistoryFormController = new CustomerOrderHistoryFormController();

            List<Order> listOfOrders = new List<Order>();

            Order testOrder = new Order(1, 1, 10, DateTime.Today, 10);

            listOfOrders.Add(testOrder);

            Order retrievedOrder = customerOrderHistoryFormController.GetOrder(1, listOfOrders);

            Assert.AreEqual(retrievedOrder, testOrder);

            retrievedOrder = customerOrderHistoryFormController.GetOrder(5, listOfOrders);

            Assert.AreEqual(retrievedOrder, null);
        }
    }
}