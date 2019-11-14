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
    public class ProductItem
    {
        public int ID { get; private set; }
        public string Text { get; private set; }
        public ProductItem(int id, string text)
        {
            this.ID = id;
            this.Text = text;
        }
    }

    class OrderBasketController
    {
        public static List<Product> listOfProducts = new List<Product>();

        public OrderBasketController()
        {
            listOfProducts = DatabaseService.getAllProducts();
        }

        public void PopulateProductList(ref ComboBox comboBox)
        {
            List<ProductItem> listOfProductItem = new List<ProductItem>();
            foreach (Product product in listOfProducts)
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
            foreach (Product product in listOfProducts)
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
    }
}