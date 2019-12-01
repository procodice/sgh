using Sgh1.Products;
using Sgh1.Products.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sgh1.DataAccess.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private List<Product> Products { get; set; }

        public void Create(Product product)
        {
            if(Products.FirstOrDefault(x => x.Name != product.Name && x.Category.Name != product.Category.Name) == null)
            {
                Products.Add(product);
            }
        }

        public ICollection<Product> GetProducts()
        {
            return Products.ToList();
        }
    }
}
