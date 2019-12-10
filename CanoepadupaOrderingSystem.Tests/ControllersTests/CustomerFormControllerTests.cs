using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Controllers;
using System.Collections.Generic;

namespace CanoepadupaOrderingSystem.Tests
{
    public class CustomerFormControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetCustomer()
        {
            List<Customer> listOfCustomers = new List<Customer>();
            Customer testCustomer = new Customer(1, "customerName",
                "AddressLine1",
                "AddressLine2",
                "AddressLine3",
                "QF458RH",
                "8767876",
                "test@gmail.com",
                10,
                "Question?",
                "Answer");
            listOfCustomers.Add(testCustomer);

            CustomerFormController customerFormController = new CustomerFormController(listOfCustomers);

            Customer retrievedCustomer = customerFormController.GetCustomer(1);

            Assert.AreEqual(retrievedCustomer, testCustomer);

            retrievedCustomer = customerFormController.GetCustomer(0);

            Assert.AreEqual(retrievedCustomer, null);
        }

        [Test]
        public void TestSearchForCustomer()
        {
            List<Customer> listOfCustomers = new List<Customer>();
            Customer testCustomer = new Customer(1, "customerName",
                "AddressLine1",
                "AddressLine2",
                "AddressLine3",
                "QF458RH",
                "8767876",
                "test@gmail.com",
                10,
                "Question?",
                "Answer");
            listOfCustomers.Add(testCustomer);

            CustomerFormController customerFormController = new CustomerFormController(listOfCustomers);

            string searchText = "customer";

            List<Customer> retrievedCustomers = customerFormController.SearchForCustomer(searchText);

            Assert.AreEqual(retrievedCustomers, new List<Customer> { testCustomer });

            searchText = "fajkdsvm";

            retrievedCustomers = customerFormController.SearchForCustomer(searchText);

            Assert.AreEqual(retrievedCustomers, new List<Customer>());
        }
    }
}