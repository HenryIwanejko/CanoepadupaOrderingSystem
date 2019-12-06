using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Forms;

namespace CanoepadupaOrderingSystem.Controllers
{
    public class CustomerOrderHistoryFormController
    {
        public CustomerOrderHistoryFormController()
        {

        }

        public string GetFormText(Customer customer)
        {
            return "Current Customer: " + customer.CustomerName + ", Discount: " + customer.Discount + "%";
        }

        public Order GetOrder(int orderNumber, List<Order> orders)
        {
            foreach (Order order in orders)
            {
                if (orderNumber == order.OrderNumber)
                {
                    return order;
                }
            }
            return null;
        }
    }

}
