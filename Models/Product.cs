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

        [Required(ErrorMessage = "Zorunlu bir alan")]
        [StringLength(100)]
        [Display(Name = "Urun Adı")]
        public string ProductName { get; set; } = null!;

        [Required]
        [Range(0, 100000)]
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