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
            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });

            _products.Add(new Product { ProductId = 1, ProductName = "IPhone 14", Price = 40000, IsActive = true, Image = "1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, ProductName = "IPhone 15", Price = 50000, IsActive = false, Image = "2.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, ProductName = "IPhone 16", Price = 60000, IsActive = true, Image = "3.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, ProductName = "IPhone 17", Price = 70000, IsActive = false, Image = "4.jpg", CategoryId = 1 });

            _products.Add(new Product { ProductId = 5, ProductName = "Macbook Air", Price = 80000, IsActive = false, Image = "5.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, ProductName = "Macbook Pro", Price = 90000, IsActive = true, Image = "6.jpg", CategoryId = 2 });
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
        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}