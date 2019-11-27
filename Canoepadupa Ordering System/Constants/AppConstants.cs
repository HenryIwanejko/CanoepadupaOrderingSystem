using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Constants
{
    public class SQLQueries
    {
        public static string GET_ALL_CUSTOMERS = "SELECT * FROM Customers";
        public static string GET_ALL_PRODUCTS = "SELECT * FROM Products";
        public static string GET_ORDERS_FOR_CUSTOMER = "SELECT * FROM Orders WHERE CustomerNumber = ";
        public static string GET_ORDER_ITEMS_FOR_ORDER = "SELECT * FROM OrderItems WHERE OrderNumber = ";
        public static string ADD_ORDER = "INSERT INTO Orders(CustomerNumber, CustomerDiscount, OrderDate, OrderTotal, OrderStatus) VALUES ";
        public static string ADD_ORDER_ITEM = "INSERT INTO OrderItems(OrderNumber, ProductNumber, PurchasePrice, Quantity) VALUES ";
        public static string GET_MAX_ORDER_NUMBER = "SELECT max(OrderNumber) as 'OrderNumber' FROM Orders";
    }

    public class CustomersFormConstants
    {
        public static String FormText = "Customers";
        public static String FormTitle = "Canoepadupa Ordering System";
        public static String ListViewTitle = "Customers";
        public static String CustomerNumber = "Customer Number:";
        public static String CustomerName = "Customer Name:";
        public static String Address = "Address:";
        public static String Postcode = "Postcode:";
        public static String Phonenumber = "Phonenumber:";
        public static String EmailAddress = "E-mail Address:";
        public static String CustomerDiscount = "Customer Discount:";
        public static String SecurityQuestion = "Security Question:";
        public static String SecurityQuestionAnswer = "Security Question Answer:";
    }

}
