using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public int CustomerNumber { get; private set; }
        public decimal CustomerDiscount { get; private set; }
        public DateTime OrderDate { get; private set; }
        public decimal OrderTotal { get; private set; }
        public int OrderStatus { get; private set; }
        public decimal DiscountedOrderTotal { get { return OrderTotal * CustomerDiscount;  } private set { } }

        // Use to retrieve from the database to get all values
        public Order(int orderNumber, int customerNumber, int customerDiscount, DateTime orderDate, decimal orderTotal, int orderStatus)
        {
            OrderNumber = orderNumber;
            CustomerNumber = customerNumber;
            CustomerDiscount = (1 - (customerDiscount / 100M));
            OrderDate = orderDate;
            OrderTotal = orderTotal;
            OrderStatus = orderStatus;
        }

        // Use to create the order when adding to the database
        public Order(int orderNumber, int customerNumber, int customerDiscount, DateTime orderDate, decimal orderTotal)
        {
            OrderNumber = orderNumber;
            CustomerNumber = customerNumber;
            CustomerDiscount = customerDiscount;
            OrderDate = orderDate;
            OrderTotal = orderTotal;
            OrderStatus = 1;
        }

        public string ConvertOrderStatus(int status)
        { 
            switch (status)
            {
                case 1:
                    return "Taken";
                case 2:
                    return "Dispatched";
                default:
                    return "Unspecified Status";
            }
        }
    }
}
