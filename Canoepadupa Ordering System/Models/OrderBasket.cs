using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Models
{
    class OrderBasket
    {
        private readonly Customer customer = CustomerForm.Customer;
        public List<BasketItem> BasketItems { get; private set; }
        public int NumberOfProducts { get { return BasketItems.Count; } private set { } }
        public int NumberOfItems { get { return GetNumberOfItems(); } private set { } }
        public decimal BasketTotal { get { return GetTotalOfBasket(); } private set { } }
        public decimal BasketDiscountedTotal { get { return BasketTotal * (1 - (customer.Discount / 100m    )); } private set { } }
        public OrderBasket()
        {
            BasketItems = new List<BasketItem>();
        }

        public void AddItem(BasketItem basketItem)
        {
            BasketItems.Add(basketItem);
        }

        public void RemoveItem(int productNumber)
        {
            BasketItem basketItem = GetBasketItem(productNumber);
            if (basketItem != null)
            {
                BasketItems.Remove(basketItem);
            }
        }

        public BasketItem CheckIfBasketAlreadyContainsProduct(int productNumber)
        {
            return GetBasketItem(productNumber);
        }

        private BasketItem GetBasketItem(int productNumber)
        {
            foreach (BasketItem basketItem in BasketItems)
            {
                if (basketItem.ProductNumber == productNumber)
                {
                    return basketItem;
                }
            }
            return null;
        }

        public void ClearBasket()
        {
            BasketItems.Clear();
        }

        public bool IsBasketEmpty()
        {
            return BasketItems.Count == 0;
        }

        private int GetNumberOfItems()
        {
            int numberOfItems = 0;
            foreach (BasketItem basketItem in BasketItems)
            {
                numberOfItems += basketItem.Quantity;
            }
            return numberOfItems;
        }

        private decimal GetTotalOfBasket()
        {
            decimal total = 0;
            foreach (BasketItem basketItem in BasketItems)
            {
                total += basketItem.TotalValueOfBasketItem;
            }
            return total;
        }
    }
}
