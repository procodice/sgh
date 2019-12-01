using Sgh1.Core.Abstract;
using Sgh1.Products.Events;
using Sgh1.Products.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Products.Events
{
    public class ProductAddedHandler : IEventHandler<IEvent>
    {
        private IEvent _event;
        public IEvent Event => _event;
        public string EventName => "ProductCreatedToAdd";


        public ProductAddedHandler()
        {
        }

        public void Handle(IEvent @event)
        {
            _event = @event;
            //to powinno byc wstkrzyniete za pomoca dependency injection
            ProductRepository.Create(_event.Content as Product);
        }
    }
}
