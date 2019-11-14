using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Models
{
    class BasketItem
    {
        public int ProductNumber { get; private set; }
        public string ProductName { get; private set; }
        public decimal WholesalePrice { get; private set; }
        public decimal RecommendRetailPrice { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }
        public decimal TotalValueOfBasketItem { get { return WholesalePrice * Quantity; } }
        public BasketItem(int productNumber,
            string productName,
            decimal wholesalePrice,
            decimal recommendedRetailPrice,
            int quantity,
            string description)
        {
            ProductNumber = productNumber;
            ProductName = productName;
            WholesalePrice = wholesalePrice;
            RecommendRetailPrice = recommendedRetailPrice;
            Quantity = quantity;
            Description = description;
        }

        public void IncreaseQuantity(int quantity)
        {
            Quantity += quantity;
        }
    }
}
