using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;

namespace CanoepadupaOrderingSystem.Tests
{
    public class CustomerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWhenCustomerModelCreatedExpectCorrectProperties()
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

            Assert.That(customer.CustomerNumber.GetType() == typeof(int));
            Assert.That(customer.CustomerName.GetType() == typeof(string));
            Assert.That(customer.CustomerAddressLine1.GetType() == typeof(string));
            Assert.That(customer.CustomerAddressLine2.GetType() == typeof(string));
            Assert.That(customer.CustomerAddressLine3.GetType() == typeof(string));
            Assert.That(customer.Postcode.GetType() == typeof(string));
            Assert.That(customer.Phone.GetType() == typeof(string));
            Assert.That(customer.Email.GetType() == typeof(string));
            Assert.That(customer.Discount.GetType() == typeof(int));
            Assert.That(customer.SecurityQuestion.GetType() == typeof(string));
            Assert.That(customer.SecurityQuestionAnswer.GetType() == typeof(string));
            Assert.AreEqual(customer.CustomerNumber, 1);
            Assert.AreEqual(customer.CustomerName, "customerName");
            Assert.AreEqual(customer.CustomerAddressLine1, "AddressLine1");
            Assert.AreEqual(customer.CustomerAddressLine2, "AddressLine2");
            Assert.AreEqual(customer.CustomerAddressLine3, "AddressLine3");
            Assert.AreEqual(customer.Postcode, "QF458RH");
            Assert.AreEqual(customer.Phone, "8767876");
            Assert.AreEqual(customer.Email, "test@gmail.com");
            Assert.AreEqual(customer.Discount, 10);
            Assert.AreEqual(customer.SecurityQuestion, "Question?");
            Assert.AreEqual(customer.SecurityQuestionAnswer, "Answer");
        }
    }
}