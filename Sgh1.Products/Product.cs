using Sgh1.Core.Abstract;
using Sgh1.Events;
using Sgh1.Products.Events;
using System;

namespace Sgh1.Products
{
    public class Product: Aggregate
    {
        public string Name { get; }
        public decimal Price { get; }
        public Category Category { get; }

        public Product(Category category, string name, decimal price):
            base(new EventsDefaultDispatcher())
        {
            Id = new Guid();
            Category = category;
            Name = name;
            Price = price;

            _eventDispatcher.AddHandler(new ProductAddedHandler());
        }

        public void Save()
        {
            _eventDispatcher.AddEvent(new ProductCreatedToAdd(this));
        }

        public override void DispatchEvents()
        {
            _eventDispatcher.DispatchEvents();
        }
    }
}
