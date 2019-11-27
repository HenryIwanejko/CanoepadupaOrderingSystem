using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Constants;

namespace CanoepadupaOrderingSystem.Services
{
    public class DatabaseService
    {
        public DatabaseService()
        {

        }

        private static SqlConnection createSQLConnection()
        {
            string connectionString = @"Data Source=.;Initial Catalog=Canoepadupa;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        public static List<Customer> getAllCustomers()
        {
            using (SqlConnection connection = createSQLConnection())
            {
                string query = SQLQueries.GET_ALL_CUSTOMERS;
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                List<Customer> listOfCustomers = new List<Customer>();

                while (dataReader.Read())
                {
                    Customer customer = new Customer(
                        int.Parse(dataReader["CustomerNumber"].ToString()),
                        dataReader["CustomerName"].ToString(),
                        dataReader["AddressLine1"].ToString(),
                        dataReader["AddressLine2"].ToString(),
                        dataReader["AddressLine3"].ToString(),
                        dataReader["Postcode"].ToString(),
                        dataReader["Phone"].ToString(),
                        dataReader["Email"].ToString(),
                        int.Parse(dataReader["Discount"].ToString()),
                        dataReader["SecurityQuestion"].ToString(),
                        dataReader["SecurityQuestionAnswer"].ToString()
                        );
                    listOfCustomers.Add(customer);
                };
                return listOfCustomers;
            }
        }

        public static List<Product> getAllProducts()
        {
            using (SqlConnection connection = createSQLConnection())
            {
                string query = SQLQueries.GET_ALL_PRODUCTS;
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                List<Product> listOfProducts = new List<Product>();

                while (dataReader.Read())
                {
                    Product product = new Product(
                            int.Parse(dataReader["ProductNumber"].ToString()),
                            dataReader["ProductName"].ToString(),
                            dataReader["Description"].ToString(),
                            decimal.Parse(dataReader["RecommendedRetailPrice"].ToString()),
                            decimal.Parse(dataReader["WholesalePrice"].ToString())
                        );
                    listOfProducts.Add(product);
                }
                return listOfProducts;
            }
        }

        public static List<Order> GetAllOrdersForCustomer(Customer customer)
        {
            using (SqlConnection connection = createSQLConnection())
            {
                string query = SQLQueries.GET_ORDERS_FOR_CUSTOMER + customer.CustomerNumber.ToString();
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                List<Order> listOfOrders = new List<Order>();

                while (dataReader.Read())
                {
                    Order order = new Order(
                        int.Parse(dataReader["OrderNumber"].ToString()),
                        int.Parse(dataReader["CustomerNumber"].ToString()),
                        int.Parse(dataReader["CustomerDiscount"].ToString()),
                        DateTime.Parse(dataReader["OrderDate"].ToString()),
                        decimal.Parse(dataReader["OrderTotal"].ToString()),
                        int.Parse(dataReader["OrderStatus"].ToString())
                        );
                    listOfOrders.Add(order);
                }
                return listOfOrders;
            }

        }

        public static List<OrderItem> GetAllOrderItemsForOrder(Order order)
        {
            using (SqlConnection connection = createSQLConnection())
            {
                string query = SQLQueries.GET_ORDER_ITEMS_FOR_ORDER + order.OrderNumber.ToString();
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                List<OrderItem> listOfOrderItems = new List<OrderItem>();

                while (dataReader.Read())
                {
                    OrderItem orderItem = new OrderItem(
                        int.Parse(dataReader["OrderItemNumber"].ToString()),
                        int.Parse(dataReader["OrderNumber"].ToString()),
                        int.Parse(dataReader["ProductNumber"].ToString()),
                        decimal.Parse(dataReader["PurchasePrice"].ToString()),
                        int.Parse(dataReader["Quantity"].ToString())
                        );
                    listOfOrderItems.Add(orderItem);
                }
                return listOfOrderItems;

            }
        }

        public static void AddOrder(Order order)
        {
            string query = SQLQueries.ADD_ORDER + String.Format("({0}, {1}, '{2}', {3}, {4})",
                    order.CustomerNumber,
                    order.CustomerDiscount,
                    order.OrderDate.ToString("yyyy-MM-dd"),
                    order.OrderTotal.ToString("0.##"),
                    order.OrderStatus
                    );
            using (SqlConnection connection = createSQLConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void AddOrderItem(OrderItem orderItem)
        {
            string query = SQLQueries.ADD_ORDER_ITEM + String.Format("({0}, {1}, {2}, {3})",
                        orderItem.OrderNumber,
                        orderItem.ProductNumber,
                        orderItem.PurchasePrice,
                        orderItem.Quantity
                    );
            using (SqlConnection connection = createSQLConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static int GetNextOrderNumber()
        {
            string query = SQLQueries.GET_MAX_ORDER_NUMBER;
            using (SqlConnection connection = createSQLConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                string orderNumber = "";
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    orderNumber = dataReader["OrderNumber"].ToString();
                }
                return int.Parse(orderNumber) + 1;
            }
        }
    }
}
