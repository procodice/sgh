using Sgh1.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Products
{
    public class Category: IValueObject
    {
        public Category(string name)
        {
            Id = new Guid();
            Products = new HashSet<Product>();
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
        public ICollection<Product> Products { get; }
    }
}
