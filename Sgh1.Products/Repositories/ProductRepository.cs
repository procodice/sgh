using Sgh1.Products;
using Sgh1.Products.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sgh1.Products.Repositories
{
    public static class ProductRepository
    {
        private static List<Product> _products = new List<Product>();
        private static List<Product> Products { get { return _products; } set { _products = value; } }

        public static void Create(Product product)
        {
            if(Products.FirstOrDefault(x => x.Name != product.Name && x.Category.Name != product.Category.Name) == null)
            {
                Products.Add(product);
            }
        }

        public static ICollection<Product> GetProducts()
        {
            return Products.ToList();
        }
    }
}
