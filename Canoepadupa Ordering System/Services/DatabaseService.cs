using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Constants;

namespace CanoepadupaOrderingSystem.Services
{
    public class DatabaseService
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=Canoepadupa;Integrated Security=True";

        public DatabaseService()
        {

        }

        private static SqlConnection createSQLConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static List<Customer> getAllCustomers()
        {
            SqlConnection connection = createSQLConnection();
            connection.Open();
            string query = SQLQueries.GET_ALL_CUSTOMERS;
            SqlCommand command = new SqlCommand(query, connection);
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

            connection.Close();

            return listOfCustomers;
        }

        public static List<Product> getAllProducts()
        {
            SqlConnection connection = createSQLConnection();
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

            connection.Close();

            return listOfProducts;
        }
    }
}
