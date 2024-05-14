using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Core.Models
{
    public class Product : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string Sizes { get; set; }
        public string Colors { get; set; } = null!;
        public int Count { get; set; }
        public int ReviewId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ImageUrl { get; set; }
        [Required]
        [NotMapped]
        public IFormFile formFile { get; set; }
        public Review Review { get; set; }
        public List<Category> Categories { get; set; }

    }
}
