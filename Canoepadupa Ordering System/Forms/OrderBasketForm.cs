using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanoepadupaOrderingSystem.Controllers;
using CanoepadupaOrderingSystem.Models;

namespace CanoepadupaOrderingSystem.Forms
{
    public partial class OrderBasketForm : Form
    {
        private readonly Customer customer = CustomerForm.Customer;

        private readonly OrderBasketFormController orderBasketController = new OrderBasketFormController();

        private readonly OrderBasket orderBasket = new OrderBasket();

        public OrderBasketForm()
        {
            InitializeComponent();
            SetUpForm();
        }

        private void SetUpForm()
        {
            orderBasketController.PopulateProductList(ref cmbProductNameValue);
            this.Text = orderBasketController.GetFormText(customer);
        }
        
        private void DisplayProductInfomation(Product product)
        {
            lblDescriptionValue.Text = product.Description;
            lblWholesalePriceValue.Text = product.WholesalePrice.ToString("C2");
            lblRRPValue.Text = product.RecommondedRetailPrice.ToString("C2");
        }

        private void cmbProductNameValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductNameValue.SelectedItem != null)
            {
                ProductItem productItem = (ProductItem)cmbProductNameValue.SelectedItem;
                Product product = orderBasketController.GetProduct(productItem.ID);
                DisplayProductInfomation(product);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductToBasket();
            PopulateListView();
        }

        private void AddProductToBasket()
        {
            ProductItem productItem = (ProductItem)cmbProductNameValue.SelectedItem;
            BasketItem basketItem = orderBasket.CheckIfBasketAlreadyContainsProduct(productItem.ID);
            if (basketItem != null)
            {
                basketItem.IncreaseQuantity(int.Parse(nudQuantity.Value.ToString()));
            }
            else
            {
                AddNewBasketItem(productItem.ID);
            }
        }

        private void AddNewBasketItem(int productNumber)
        {
            Product product = orderBasketController.GetProduct(productNumber);
            BasketItem newBasketItem = new BasketItem(
                product.ProductNumber,
                product.ProductName,
                product.WholesalePrice,
                product.RecommondedRetailPrice,
                int.Parse(nudQuantity.Value.ToString()),
                product.Description
            );
            orderBasket.AddItem(newBasketItem);
        }


        private void PopulateListView()
        {
            lsvOrderBasket.Items.Clear();
            foreach (BasketItem basketItem in orderBasket.BasketItems)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                        basketItem.ProductNumber.ToString(),
                        basketItem.ProductName.ToString(),
                        basketItem.Quantity.ToString(),
                        basketItem.WholesalePrice.ToString("C2"),
                        basketItem.RecommendRetailPrice.ToString("C2"),
                        basketItem.TotalValueOfBasketItem.ToString("C2"),
                        basketItem.Description.ToString()
                    });
                lsvOrderBasket.Items.Add(listViewItem);
            }
        }
    }
}
