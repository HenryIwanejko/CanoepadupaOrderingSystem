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
        private Customer customer = CustomerForm.Customer;

        private OrderBasketController orderBasketController = new OrderBasketController();

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

        }
    }
}
