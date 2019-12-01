using Sgh1.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Products.Events
{
    public class ProductCreatedToAdd : IEvent
    {
        public ProductCreatedToAdd(Product product)
        {
            Content = product;
        }
        public string Name { get => "ProductCreatedToAdd"; }


        public object Content { get; private set; }
    }
}
