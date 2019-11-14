using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanoepadupaOrderingSystem.Models
{
    public class ProductItem
    {
        public int ID { get; private set; }
        public string Text { get; private set; }
        public ProductItem(int id, string text)
        {
            this.ID = id;
            this.Text = text;
        }
    }
}
