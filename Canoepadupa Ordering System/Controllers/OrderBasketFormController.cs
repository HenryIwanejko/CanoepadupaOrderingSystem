using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Services;
using System.Windows.Forms;

namespace CanoepadupaOrderingSystem.Controllers
{

    public class OrderBasketFormController
    {
        private static List<Product> ListOfProducts = new List<Product>();

        public OrderBasketFormController(List<Product> listOfProducts = null)
        {
            ListOfProducts = listOfProducts ?? DatabaseService.GetAllProducts();
        }

        public void PopulateProductList(ref ComboBox comboBox)
        {
            List<ProductItem> listOfProductItem = new List<ProductItem>();
            foreach (Product product in ListOfProducts)
            {
                ProductItem productItem = new ProductItem(product.ProductNumber, product.ProductName);
                listOfProductItem.Add(productItem);
            }
            comboBox.DataSource = listOfProductItem;
            comboBox.ValueMember = "id";
            comboBox.DisplayMember = "text";
        }

        public Product GetProduct(int productNumber)
        {
            foreach (Product product in ListOfProducts)
            {
                if (productNumber == product.ProductNumber)
                {
                    return product;
                }
            }
            return null;
        }

        public string GetFormText(Customer customer)
        {
            return "Current Customer: " + customer.CustomerName + ", Discount: " + customer.Discount + "%";
        }

        public void AddToBasketToDatabase(OrderBasket orderBasket, Customer customer)
        {
            int orderNumber = DatabaseService.GetNextOrderNumber();
            Order order = new Order(
                orderNumber,
                customer.CustomerNumber,
                customer.Discount,
                DateTime.Now,
                orderBasket.BasketTotal
                );
            AddOrderToDatabase(order);
            AddOrderItemsToDatabase(orderBasket, order);
        }

        private void AddOrderToDatabase(Order order)
        {
            DatabaseService.AddOrder(order);
        }

        private void AddOrderItemsToDatabase(OrderBasket orderBasket, Order order)
        {
            foreach (BasketItem basketItem in orderBasket.BasketItems)
            {
                OrderItem orderItem = new OrderItem(order.OrderNumber, basketItem.ProductNumber, basketItem.WholesalePrice, basketItem.Quantity);
                DatabaseService.AddOrderItem(orderItem);
            }
        }

    }
}