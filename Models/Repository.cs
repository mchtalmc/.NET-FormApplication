using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormApplicationCourse.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();
        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, CategoryName = "Phone" });
            _categories.Add(new Category { CategoryId = 2, CategoryName = "Computer" });

            _products.Add(new Product { ProductId = 1, ProductName = "IPhone14", ProductPrice = 4000, Image = "1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, ProductName = "IPhone15", ProductPrice = 5000, Image = "2.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, ProductName = "IPhone16", ProductPrice = 6000, Image = "3.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, ProductName = "IPhone17", ProductPrice = 7000, Image = "4.jpg", CategoryId = 1 });

            _products.Add(new Product { ProductId = 5, ProductName = "M1 Mac", ProductPrice = 6000, Image = "5.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, ProductName = "Benim Cop Toshiba", ProductPrice = 500, Image = "6.jpg", CategoryId = 2 });
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}