using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormApplicationCourse.Models
{
    public class Product
    {
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }
        [Display(Name = "Price")]
        public decimal ProductPrice { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}