using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Core.Models
{
    public class Review:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
