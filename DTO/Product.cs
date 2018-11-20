using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float purchasePrice { get; set; }
        public float sellingPrice { get; set; }
        public int categoryId { get; set; }
        public string supplierId { get; set; }

        public Product(string Id, string Name, float purchasePrice, float sellingPrice, int categoryId, string supplierId)
        {
            this.Id = Id;
            this.Name = Name;
            this.purchasePrice = purchasePrice;
            this.sellingPrice = sellingPrice;
            this.categoryId = categoryId;
            this.supplierId = supplierId;
        }
    }
}
