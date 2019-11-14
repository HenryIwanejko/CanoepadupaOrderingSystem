using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Models
{
    public class Product
    { 
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal RecommondedRetailPrice { get; set; }
        public decimal WholesalePrice { get; set; }

        public Product(int productNumber, string productName, string description, decimal RRP, decimal wholesalePrice)
        {
            ProductNumber = productNumber;
            ProductName = productName;
            Description = description;
            RecommondedRetailPrice = RRP;
            WholesalePrice = wholesalePrice;
        }
    }
}
