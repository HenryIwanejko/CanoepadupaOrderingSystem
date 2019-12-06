using System;
using System.Windows.Forms;
using CanoepadupaOrderingSystem.Controllers;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Segues;

namespace CanoepadupaOrderingSystem.Forms
{
    public partial class OrderBasketForm : Form
    {
        private readonly Customer customer = CustomerForm.Customer;

        private readonly OrderBasketFormController orderBasketController = new OrderBasketFormController();

        private readonly OrderBasket orderBasket = new OrderBasket(CustomerForm.Customer);

        public OrderBasketForm()
        {
            InitializeComponent();
            SetUpForm();
        }

        private void SetUpForm()
        {
            orderBasketController.PopulateProductList(ref cmbProductNameValue);
            this.Text = orderBasketController.GetFormText(customer);
            btnRemoveItem.Enabled = false;
            btnClearBasket.Enabled = false;
            btnCheckOut.Enabled = false;
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

            bool ButtonStatus = !orderBasket.IsBasketEmpty();
            btnClearBasket.Enabled = ButtonStatus;
            btnCheckOut.Enabled = ButtonStatus;
            UpdateBasketDetails();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int productNumber = int.Parse(lsvOrderBasket.SelectedItems[0].Text);
            orderBasket.RemoveItem(productNumber);
            PopulateListView();
            IsItemSelected();
        }


        private void btnClearBasket_Click(object sender, EventArgs e)
        {
            ClearBasket();
        }

        private void lsvOrderBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsItemSelected();
        }

        private void IsItemSelected()
        {
            bool buttonStatus = lsvOrderBasket.SelectedItems.Count > 0;
            btnRemoveItem.Enabled = buttonStatus;
        }

        private void ClearBasket()
        {
            orderBasket.ClearBasket();
            lsvOrderBasket.Items.Clear();
            btnClearBasket.Enabled = false;
            btnRemoveItem.Enabled = false;
            btnCheckOut.Enabled = false;
            UpdateBasketDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearBasket();
            AppSegues.SegueToCustomerForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateBasketDetails()
        {
            lblNumberOfItemsValue.Text = orderBasket.NumberOfItems.ToString();
            lblNumberOfProductsValue.Text = orderBasket.NumberOfProducts.ToString();
            lblTotalValue.Text = orderBasket.BasketTotal.ToString("C2");
            lblTotalWithDiscountValue.Text = orderBasket.BasketDiscountedTotal.ToString("C2");
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lsvOrderBasket.Items.Count > 0)
            {
                orderBasketController.AddToBasketToDatabase(orderBasket, customer);
                AppSegues.SegueToOrderHistoryCustomer(this);
            } 
            else
            {
                MessageBox.Show("Transaction can't complete. No items in Basket");
            }
        }
    }
}
