using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Models
{
    public class OrderItem
    {
        public int OrderItemNumber { get; private set; }
        public int OrderNumber { get; private set; }
        public int ProductNumber { get; private set; }
        public decimal PurchasePrice { get; private set; }
        public int Quantity { get; private set; }

        // Use to retrieve from database as it will include the order item number
        public OrderItem(int orderItemNumber, int orderNumber, int productNumber, decimal purchasePrice, int quantity)
        {
            OrderItemNumber = orderItemNumber;
            OrderNumber = orderNumber;
            ProductNumber = productNumber;
            PurchasePrice = purchasePrice;
            Quantity = quantity;
        }

        // Use to add to database as orderitemNumber created automatically in database
        public OrderItem(int orderNumber, int productNumber, decimal purchasePrice, int quantity)
        {
            OrderNumber = orderNumber;
            ProductNumber = productNumber;
            PurchasePrice = purchasePrice;
            Quantity = quantity;
        }

    }
}
