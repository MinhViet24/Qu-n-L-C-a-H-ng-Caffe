using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Tables
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public Tables(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        
    }
}
