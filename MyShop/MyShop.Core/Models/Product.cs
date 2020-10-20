using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal SalesPrice { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
