using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormApplicationCourse.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }


        [Display(Name = "Urun Adı")]
        public string ProductName { get; set; } = null!;


        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Display(Name = "Category")]

        [Required]
        public int? CategoryId { get; set; }

    }
}