using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Services;
using CanoepadupaOrderingSystem.Controllers;
using CanoepadupaOrderingSystem.Segues;

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

        // On initialization set form up to add customers to listview
        private void SetUpForm()
        {
            this.Text = customerOrderHistoryFormController.GetFormText(customer);
            ResizeListViewColumns();
            PopulateOrdersListView();
        }

        // Resize Columns to fit listview width
        private void ResizeListViewColumns()
        {
            lsvOrderList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvOrderList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lsvOrderDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvOrderDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        // Cancel Button Pressed Return to Customer Form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            AppSegues.SegueToCustomerForm(this);
        }

        // Exit Button Press Close Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // On Item Selected, Update the orderList listview
        private void lsvOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lsvOrderList.SelectedItems.Count > 0)) { return; }
            int orderNumber = int.Parse(lsvOrderList.SelectedItems[0].Text);
            Order order = customerOrderHistoryFormController.GetOrder(orderNumber, listOfOrders) ;
            PopulateOrderDetailsListView(order);
        }

        // Retrive Orders from database and add to the Orders list view
        private void PopulateOrdersListView()
        {
            listOfOrders = DatabaseService.GetAllOrdersForCustomer(customer);
            foreach (Order order in listOfOrders)
            {
                AddToOrderListView(order);
            }
        }

        // Add Order to the listView to be Displayed
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

        // Add Data to the Order Details Listview
        private void PopulateOrderDetailsListView(Order order)
        {
            lsvOrderDetails.Items.Clear();
            List<OrderItem> listOfOrderItems = DatabaseService.GetAllOrderItemsForOrder(order);
            foreach (OrderItem orderItem in listOfOrderItems)
            {
                AddToOrderDetailsListView(orderItem);
            }
        }

        // Add the orderItems to the listview
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
