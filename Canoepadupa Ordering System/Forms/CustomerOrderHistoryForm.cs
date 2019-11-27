using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Services;
using CanoepadupaOrderingSystem.Controllers;

namespace CanoepadupaOrderingSystem.Forms
{
    public partial class CustomerOrderHistoryForm : Form
    {
        private readonly Customer customer = CustomerForm.Customer;

        private readonly CustomerOrderHistoryFormController customerOrderHistoryFormController = new CustomerOrderHistoryFormController();

        private List<Order> listOfOrders = new List<Order>();

        public CustomerOrderHistoryForm()
        {
            InitializeComponent();
            SetUpForm();
        }

        private void SetUpForm()
        {
            this.Text = customerOrderHistoryFormController.GetFormText(customer);
            ResizeListViewColumns();
            PopulateOrdersListView();
        }

        private void ResizeListViewColumns()
        {
            lsvOrderList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvOrderList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.Closed += (s, args) => this.Close();
            customerForm.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lsvOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lsvOrderList.SelectedItems.Count > 0)) { return; }
            int orderNumber = int.Parse(lsvOrderList.SelectedItems[0].Text);
            Order order = customerOrderHistoryFormController.GetOrder(orderNumber, listOfOrders) ;
            PopulateOrderDetailsListView(order);
        }

        private void PopulateOrdersListView()
        {
            listOfOrders = DatabaseService.GetAllOrdersForCustomer(customer);
            foreach (Order order in listOfOrders)
            {
                AddToOrderListView(order);
            }
        }

        private void AddToOrderListView(Order order)
        {
            lsvOrderList.Items.Add(new ListViewItem(new string[] {
                order.OrderNumber.ToString(),
                order.OrderDate.ToString("dd MMMM yyyy"),
                order.ConvertOrderStatus(order.OrderStatus).ToString(),
                order.OrderTotal.ToString("C2"),
                order.DiscountedOrderTotal.ToString("C2")
            }));
        }

        private void PopulateOrderDetailsListView(Order order)
        {
            lsvOrderDetails.Items.Clear();
            List<OrderItem> listOfOrderItems = DatabaseService.GetAllOrderItemsForOrder(order);
            foreach (OrderItem orderItem in listOfOrderItems)
            {
                AddToOrderDetailsListView(orderItem);
            }
        }

        private void AddToOrderDetailsListView(OrderItem orderItem)
        {
            lsvOrderDetails.Items.Add(new ListViewItem(new string[] {
                orderItem.OrderNumber.ToString(),
                orderItem.ProductNumber.ToString(),
                orderItem.Quantity.ToString(),
                orderItem.PurchasePrice.ToString("C2")
            }));
        }
    }
}
