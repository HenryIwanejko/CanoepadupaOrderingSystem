using NUnit.Framework;
using CanoepadupaOrderingSystem.Constants;

namespace CanoepadupaOrderingSystem.Tests
{
    public class AppConstanstsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAllSQLQueriesPropertiesHaveCorrectValues()
        {
            Assert.AreEqual(SQLQueries.GET_ALL_CUSTOMERS, "SELECT * FROM Customers");
            Assert.AreEqual(SQLQueries.GET_ALL_PRODUCTS, "SELECT * FROM Products");
            Assert.AreEqual(SQLQueries.GET_ORDERS_FOR_CUSTOMER, "SELECT * FROM Orders WHERE CustomerNumber = ");
            Assert.AreEqual(SQLQueries.GET_ORDER_ITEMS_FOR_ORDER, "SELECT * FROM OrderItems WHERE OrderNumber = ");
            Assert.AreEqual(SQLQueries.ADD_ORDER, "INSERT INTO Orders(CustomerNumber, CustomerDiscount, OrderDate, OrderTotal, OrderStatus) VALUES ");
            Assert.AreEqual(SQLQueries.ADD_ORDER_ITEM, "INSERT INTO OrderItems(OrderNumber, ProductNumber, PurchasePrice, Quantity) VALUES ");
            Assert.AreEqual(SQLQueries.GET_MAX_ORDER_NUMBER, "SELECT max(OrderNumber) as 'OrderNumber' FROM Orders");
            Assert.AreEqual(SQLQueries.GET_MAX_CUSTOMER_NUMBER, "SELECT max(CustomerNumber) as 'CustomerNumber' FROM Customers");
            Assert.AreEqual(SQLQueries.ADD_CUSTOMER, "INSERT INTO Customers(CustomerName, AddressLine1, AddressLine2, AddressLine3, Postcode, Phone, Email, Discount, SecurityQuestion, SecurityQuestionAnswer) VALUES ");
        }

        [Test]
        public void TestAllCustomerFormConstantsPropertiesHaveCorrectValues()
        {
            Assert.AreEqual(CustomersFormConstants.FormText, "Customers");
            Assert.AreEqual(CustomersFormConstants.FormTitle, "Canoepadupa Ordering System");
            Assert.AreEqual(CustomersFormConstants.ListViewTitle, "Customers");
            Assert.AreEqual(CustomersFormConstants.CustomerNumber, "Customer Number:");
            Assert.AreEqual(CustomersFormConstants.CustomerName, "Customer Name:");
            Assert.AreEqual(CustomersFormConstants.Address, "Address:");
            Assert.AreEqual(CustomersFormConstants.Postcode, "Postcode:");
            Assert.AreEqual(CustomersFormConstants.Phonenumber, "Phonenumber:");
            Assert.AreEqual(CustomersFormConstants.EmailAddress, "E-mail Address:");
            Assert.AreEqual(CustomersFormConstants.CustomerDiscount, "Customer Discount:");
            Assert.AreEqual(CustomersFormConstants.SecurityQuestion, "Security Question:");
            Assert.AreEqual(CustomersFormConstants.SecurityQuestionAnswer, "Security Question Answer:");
        }
    }
}