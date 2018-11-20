using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductCategory
    {
        private string id;

        public int Id { get; set; }
        public string  Name { get; set; }

        public ProductCategory(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public ProductCategory(string id, string name)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.Name = name;
        }
    }
}
